﻿using Bugtracker.Capture.LogProcessing;
using Bugtracker.Capture.Screen;
using Bugtracker.Configuration;
using Bugtracker.InternalApplication;
using Bugtracker.Logging;
using Bugtracker.Problem_Descriptors;
using Bugtracker.Send;
using Bugtracker.Utils;
using Bugtracker_UI.GUI;
using Application = Bugtracker.InternalApplication.Application;

namespace Bugtracker.GUI
{
    /// <summary>
    /// Default Form-Window for GUI
    /// </summary>
    public partial class Bugtracker_Form : Form
    {
        private readonly RunningConfiguration runningConfiguration = RunningConfiguration.GetInstance();
        private readonly TextBox loggingBox;
        private bool showLogging = false;
        private PCInfo pcinfo;
        private System.Windows.Forms.Timer ScreenshotTimer = new System.Windows.Forms.Timer();
        private EventHandler DelayScreenshot;

        /// <summary>
        /// /Constructor
        /// </summary>
        public Bugtracker_Form()
        {
            this.CenterToScreen();

            InitializeComponent();

            RunningConfiguration rc = runningConfiguration;
            loggingBox = (TextBox) this.Controls.Find("bugtrackLog", true)[0];

            RemoteSessionLabel.Text = runningConfiguration.IsRemoteSession.ToString();

            ScreenshotTimer.Interval = (2000);

            DelayScreenshot = new EventHandler(DelayedScreencapture);

            LoadAllApplicationsAsCheckboxes(rc);
            LoadAllProblemCategories(rc);
            LoadInBugtrackTime(rc);
            LoadInPCName(rc);
            CheckStandardApplications(rc);

            //Load in log file content
            loggingBox.AppendText(BugtrackerUtils.LoadFileContentAsString(Globals_and_Information.Globals.LOG_FILE_PATH));


            configFileSourceLabel.Text = runningConfiguration.ConfigSource.ToString();

            Server.CheckedServerStatus += new System.EventHandler(UpdateServerStatus);
            Logger.LoggedNewLine += new System.EventHandler(AppendLogs);

            this.Size = new Size(450, 640);
        }

        private void CheckStandardApplications(RunningConfiguration rc)
        {
            List<Control> applicationCheckboxes = new List<Control>(Controls.Find("applicationCheckbox", true));

            foreach (var app in rc.ApplicationManager.Applications)
            {
                if (app.IsStandard)
                {
                    foreach (Control c in applicationCheckboxes)
                    {
                        if (c.Text == app.Name)
                            ((CheckBox) c).Checked = true;
                    }
                }
            }
        }

        private void UpdateServerStatus(object sender, EventArgs args)
        {
            if(runningConfiguration.ServerStatus == ServerStatus.Available)
            {
                serverStatusLabel.Text = "Available";
            }
            else
            {
                serverStatusLabel.Text = "Not Available";
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
                if ((application.ShowSpecifier == Application.ShowAppSpecifier.installed && application.IsInstalled) || application.ShowSpecifier == Application.ShowAppSpecifier.always)
                {
                    cb = new CheckBox();
                    cb.Text = application.Name;
                    cb.Name = "applicationCheckbox";
                    cb.AutoSize = false;
                    cb.MinimumSize = new Size(75, 35);
                    cb.CheckStateChanged += new System.EventHandler(CheckstateChangeLog);
                    flp.Controls.Add(cb);
                }

            }
        }

        private void CheckstateChangeLog(object? sender, EventArgs eventArgs)
        {
            Logger.Log("Check-state changed from item " + ((CheckBox)sender).Text + " to " + ((CheckBox)sender).Checked, LoggingSeverity.Info);
        }

        private void LoadAllProblemCategories(RunningConfiguration rc)
        {
            var cb = (ComboBox) this.Controls.Find("problemCategories", true)[0];


            foreach (var problemCategory in rc.ProblemManager.ProblemCategories)
            {
                cb.Items.Add(problemCategory.Name);
            }
        }

        private void LoadInBugtrackTime(RunningConfiguration rc)
        {
            var tb = (TextBox) this.Controls.Find("bugtrackTime", true)[0];

            tb.Text = rc.StartupTime.ToLongDateString() + ", " + rc.StartupTime.ToLongTimeString();
        }

        private void LoadInPCName(RunningConfiguration rc)
        {
            var lb = (Label) this.Controls.Find("pcName", true)[0];

            lb.Text = rc.PcInfo.GetHostname();
        }

        private void problemCategories_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ChangeCheckBoxState(false);

            var cb = (ComboBox) sender;

            var description =
                runningConfiguration.ProblemManager.GetDescriptionForProblemByName((string) cb.SelectedItem);

            var tb = (TextBox) this.Controls.Find("problemDescription", true)[0];

            tb.Text = description + Environment.NewLine;


            CheckApplicationCheckboxesAccordingToProblemCategoryName((string)cb.SelectedItem);

            Logger.Log("Changed Problem Category to " + (string) cb.SelectedItem, LoggingSeverity.Info);
        }
        
        public void CheckApplicationCheckboxesAccordingToProblemCategoryName(string problemCategoryName)
        {
            var pc = RunningConfiguration.GetInstance().ProblemManager.GetProblemCategoryByName(problemCategoryName);

            if (pc.SelectAllApplications)
                ChangeCheckBoxState(true);
                

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

        public void ChangeCheckBoxState(bool @checked)
        {
            foreach(Control c in Controls.Find("applicationCheckbox", true))
            {
                if(c is CheckBox)
                {
                    ((CheckBox)c).Checked = @checked;
                }
            }
        }
        

        private void ShowLoggingWindow()
        {
            ToggleLog.Checked = true;
            this.Size = new Size(850, 625);
            showLogging = true;
        }

        private void HideLoggingWindow()
        {
            ToggleLog.Checked = false;
            this.Size = new Size(450, 625);
            showLogging = false;
        }

        private void DelayedScreencapture(object sender, EventArgs e)
        {
            BugtrackerUtils.GenerateScreenCapture();

            ScreenshotTimer.Stop();

            ScreenshotTimer.Interval = 2000;
            ScreenshotTimer.Start();
            ScreenshotTimer.Tick -= DelayScreenshot;
            ScreenshotTimer.Tick += new EventHandler(DelayedSend);
        }

        private void DelayedSend(object sender, EventArgs e)
        {
            SendHandler sh = new SendHandler(runningConfiguration.TargetManager.GetDefaultTargets());
            sh.Send(GetCurrentProblemDescriptor());

            this.Dispose();
            ScreenshotTimer.Stop();
            ScreenshotTimer.Dispose();
        }

        private List<InternalApplication.Application> GetAllTargetedApplications()
        {
            List<InternalApplication.Application> targetedApplications = new List<InternalApplication.Application>();
            ApplicationManager am = runningConfiguration.ApplicationManager;

            foreach (string app in GetApplicationsChecked())
            {
                if (am.GetApplicationByName(app) != null)
                    targetedApplications.Add(am.GetApplicationByName(app));
            }

            foreach (var app in runningConfiguration.ApplicationManager.Applications)
            {
                if (app.IsStandard)
                    targetedApplications.Add(app);
            }

            return targetedApplications;
        }

        private void StartScreenshotRoutine()
        {
            if (screenshotCheckbox.Checked)
            {
                ScreenshotTimer.Tick += DelayScreenshot;
                this.WindowState = FormWindowState.Minimized;
                ScreenshotTimer.Start();
            }
        }

        private void CaptureSendCloseButton(object sender, EventArgs e)
        {
            StartScreenshotRoutine();

            List<InternalApplication.Application> targetedApplications = GetAllTargetedApplications();

            LogProcessor.FetchAllLogFiles(targetedApplications);

            if (targetedApplications.Count == 0)
                MessageBox.Show("Keine Applikation ausgewählt.");
        }

        private ProblemDescriptor GetCurrentProblemDescriptor()
        {
            ComboBox cb = (ComboBox) this.Controls.Find("problemCategories", true)[0];
            TextBox tb = (TextBox) this.Controls.Find("problemDescription", true)[0];

            ProblemDescriptor descriptor = new ProblemDescriptor
            {
                ProblemCategory = runningConfiguration.ProblemManager.GetProblemCategoryByName((string) cb.SelectedItem),
                ProblemDescription = tb.Text
            };

            return descriptor;
        }

        private List<string> GetApplicationsChecked()
        {
            List<string> applicationNames = new List<string>();

            foreach (var control in this.Controls.Find("applicationCheckbox", true))
            {
                if (control is CheckBox && ((CheckBox) control).Checked)
                {
                    applicationNames.Add(((CheckBox)control).Text);
                }
                    
            }

            return applicationNames;
        }

        private void MaximizeBugtracker(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void ToggleLogToolStrip(object sender, EventArgs e)
        {
            if (showLogging == false)
                ShowLoggingWindow();
            else
                HideLoggingWindow();
        }

        private void RenameTargetedLogsToolStrip(object sender, EventArgs e)
        {
            LogProcessor.RenameAllTargeted(GetAllTargetedApplications());
        }

        private void DeleteTargetedLogsToolStrip(object sender, EventArgs e)
        {
            LogProcessor.DeleteAllTargeted(GetAllTargetedApplications());
        }

        private void ReproducableScreenshotToolStrip(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Reproduzirbar reprodForm = new Reproduzirbar();
            reprodForm.TopMost = true;
            reprodForm.Show(this);
            reprodForm.Disposed += new EventHandler(MaximizeBugtracker);
        }

        private void ScreenshotAllToolStrip(object sender, EventArgs e)
        {
            BugtrackerUtils.GenerateScreenCapture();
        }

        private void ComputerInfoToolStrip(object sender, EventArgs e)
        {
            if (pcinfo == null || pcinfo.IsDisposed)
                pcinfo = new PCInfo();


            pcinfo.Show(this);
        }

        private void SnippingToolToolStrip(object sender, EventArgs e)
        {
            ScreenCaptureHandler sch = new ScreenCaptureHandler();
            sch.GenerateScreenshotFromBitmap(runningConfiguration.NewestBugtrackerFolder.FullName, new Bitmap(SnippingTool.Snip()));
        }

        private void ExitToolStrip(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
