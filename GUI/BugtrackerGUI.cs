using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Bugtracker.Capture.Log;
using Bugtracker.Configuration;
using Bugtracker.Globals_and_Information;
using Bugtracker.InternalApplication;
using Bugtracker.Logging;
using Bugtracker.Problem_Descriptors;
using Bugtracker.Sending;

namespace Bugtracker.GUI
{
    /// <summary>
    /// Default Form-Window for GUI
    /// </summary>
    public partial class Bugtracker : Form
    {
        private readonly RunningConfiguration runningConfiguration = new RunningConfiguration();
        private readonly TextBox loggingBox;
        private bool showLogging = false;
        private bool screenshotEnabled = false;
        private PCInfo pcinfo;

        /// <summary>
        /// /Constructor
        /// </summary>
        public Bugtracker()
        {
            InitializeComponent();

            RunningConfiguration rc = runningConfiguration;
            loggingBox = (TextBox) this.Controls.Find("bugtrackLog", true)[0];



            LoadAllApplicationsAsCheckboxes(rc);
            LoadAllProblemCategories(rc);
            LoadInBugtrackTime(rc);
            LoadInPCName(rc);


            configFileSourceLabel.Text = runningConfiguration.ConfigSource.ToString();

            ServerUtils.CheckedServerStatus += new System.EventHandler(UpdateServerStatus);
            Logger.LoggedNewLine += new System.EventHandler(AppendLogs);
        }


        private void UpdateServerStatus(object sender, EventArgs args)
        {
            if(runningConfiguration.ServerStatus == ServerStatus.Available)
            {
                serverStatusLabel.Text = "Available";
                serverStatusLabel.ForeColor = Color.Green;
            }
            else
            {
                serverStatusLabel.Text = "Not Available";
                serverStatusLabel.ForeColor = Color.Red;
            }

            lastConnectionTimeLabel.Text = runningConfiguration.ServerLastConnectionTime.ToLongTimeString();
        }

        private void AppendLogs(object sender, EventArgs args)
        {
            LoggedNewLineEventArgs eventArgs = (LoggedNewLineEventArgs) args;
            
            if(!this.IsDisposed)
                loggingBox.AppendText(eventArgs.Message + Environment.NewLine);
        }

        private void LoadAllApplicationsAsCheckboxes(RunningConfiguration rc)
        {
            CheckBox cb;
            FlowLayoutPanel flp = (FlowLayoutPanel) this.Controls.Find("applicationPanel", true)[0];

            foreach (var application in rc.ApplicationManager.GetApplications())
            {
                cb = new CheckBox();
                cb.Text = application.Name;
                cb.Name = "applicationCheckbox";
                cb.CheckStateChanged += new System.EventHandler(CheckstateChangeLog);
                flp.Controls.Add(cb);
            }
        }

        private void CheckstateChangeLog(Object sender, EventArgs eventArgs)
        {
            Logger.Log("Checkstate changed from item " + ((CheckBox)sender).Text + " to " + ((CheckBox)sender).Checked, LoggingSeverity.Info);
        }

        private void LoadAllProblemCategories(RunningConfiguration rc)
        {
            ComboBox cb = (ComboBox) this.Controls.Find("problemCategories", true)[0];


            foreach (var problemCategory in rc.ProblemManager.ProblemCategories)
            {
                cb.Items.Add(problemCategory.Name);
            }
        }

        private void LoadInBugtrackTime(RunningConfiguration rc)
        {
            TextBox tb = (TextBox) this.Controls.Find("bugtrackTime", true)[0];

            tb.Text = rc.StartupTime.ToLongDateString() + ", " + rc.StartupTime.ToLongTimeString();
        }

        private void LoadInPCName(RunningConfiguration rc)
        {
            Label lb = (Label) this.Controls.Find("pcName", true)[0];

            lb.Text = rc.PcInfo.GetHostname();
        }

        private void problemCategories_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ChangeCheckBoxIsChecked(false);

            ComboBox cb = (ComboBox) sender;

            string description =
                runningConfiguration.ProblemManager.GetDescriptionForProblemByName((string) cb.SelectedItem);

            TextBox tb = (TextBox) this.Controls.Find("problemDescription", true)[0];

            tb.Text = description + Environment.NewLine;


            CheckApplicationCheckboxesAccordingToProblemCategoryName((string)cb.SelectedItem);

            Logger.Log("Changed Problem Category to " + (string) cb.SelectedItem, LoggingSeverity.Info);
        }
        
        public void CheckApplicationCheckboxesAccordingToProblemCategoryName(string problemCategoryName)
        {
            ProblemCategory pc = RunningConfiguration.GetInstance().ProblemManager.GetProblemCategoryByName(problemCategoryName);

            if (pc.SelectAllApplications)
                ChangeCheckBoxIsChecked(true);
                

            foreach(Control c in Controls.Find("applicationCheckbox", true))
            {
                if(c is CheckBox)
                {
                    if (((CheckBox)c).Text == "Screen" && pc.SelectScreenshot)
                        ((CheckBox)c).Checked = true;

                    foreach(InternalApplication.Application a in pc.SelectedApplications)
                    {
                        if(((CheckBox)c).Text == a.Name)
                        {
                            ((CheckBox)c).Checked = true;
                        }
                    }
                }
            }
        }

        public void ChangeCheckBoxIsChecked(bool checkOrNotCheck)
        {
            foreach(Control c in Controls.Find("applicationCheckbox", true))
            {
                if(c is CheckBox)
                {
                    ((CheckBox)c).Checked = checkOrNotCheck;
                }
            }
        }
        

        private void ShowLoggingWindow()
        {
            this.Size = new Size(850, 625);
            showLogging = true;
        }

        private void HideLoggingWindow()
        {
            this.Size = new Size(450, 625);
            showLogging = false;
        }

        private void captureAndSendButton_Click(object sender, EventArgs e)
        {
            //BugtrackerUtils.CreateBugtrackFolder();

            //if(screenshotEnabled)
                BugtrackerUtils.GenerateScreenCapture();

            List<InternalApplication.Application> targetedApplications = new List<InternalApplication.Application>();
            ApplicationManager am = runningConfiguration.ApplicationManager;

            foreach (string app in GetApplicationsChecked())
            {
                if (am.GetApplicationByName(app) != null)
                    targetedApplications.Add(am.GetApplicationByName(app));
            }

            LogfileFetcher lff = new LogfileFetcher(targetedApplications);
            lff.FetchAllLogFiles();

            SendHandler sh = new SendHandler(runningConfiguration.TargetManager.GetDefaultTargets());
            sh.Send(GetCurrentProblemDescriptor());


            if (targetedApplications.Count == 0)
                MessageBox.Show("Keine Applikation ausgewählt.");
        }

        private ProblemDescriptor GetCurrentProblemDescriptor()
        {
            ComboBox cb = (ComboBox) this.Controls.Find("problemCategories", true)[0];
            TextBox tb = (TextBox) this.Controls.Find("problemDescription", true)[0];

            ProblemDescriptor descriptor = new ProblemDescriptor();
            descriptor.ProblemCategory =
                runningConfiguration.ProblemManager.GetProblemCategoryByName((string) cb.SelectedItem);
            descriptor.ProblemDescription = tb.Text;

            return descriptor;
        }

        private List<string> GetApplicationsChecked()
        {
            List<string> applicationNames = new List<string>();

            foreach (var control in this.Controls.Find("applicationCheckbox", true))
            {
                if (control is CheckBox && ((CheckBox) control).Checked)
                {
                    if (((CheckBox)control).Text == "Screen")
                    {
                        screenshotEnabled = true;
                        Logger.Log("Screenshot enabled", LoggingSeverity.Info);
                    }
                        

                    applicationNames.Add(((CheckBox)control).Text);
                }
                    
            }

            return applicationNames;
        }


        private void zeigeLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showLogging == false)
                ShowLoggingWindow();
            else
                HideLoggingWindow();
        }

        private void computerInfosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pcinfo == null || pcinfo.IsDisposed)
                pcinfo = new PCInfo();


            pcinfo.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
