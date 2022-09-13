using Bugtracker.Capture.LogProcessing;
using Bugtracker.Capture.Screen;
using Bugtracker.Configuration;
using Bugtracker.InternalApplication;
using Bugtracker.Logging;
using Bugtracker.Problem_Descriptors;
using Bugtracker.Send;
using Bugtracker.Utils;
using Bugtracker_UI.GUI;
using Bugtracker_UI.Utils;
using Bugtracker_UI.Extensions;
using Application = Bugtracker.InternalApplication.Application;

namespace Bugtracker.GUI
{
    /// <summary>
    /// Default Form-Window for GUI
    /// </summary>
    public partial class Bugtracker_Main_Form : Form
    {
        private readonly RunningConfiguration runningConfiguration = RunningConfiguration.GetInstance();
        private readonly TextBox loggingBox;
        private bool showLogging = false;
        private PCInfo pcinfo;
        private System.Windows.Forms.Timer ScreenshotTimer = new System.Windows.Forms.Timer();
        private EventHandler DelayScreenshot;

        //Begin: Main Form : dragable

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Bugtracker_Main_Form_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //End: Main Form : dragable

        /// <summary>
        /// /Constructor
        /// </summary>
        public Bugtracker_Main_Form()
        {

            this.CenterToScreen();

            InitializeComponent();

            RunningConfiguration rc = runningConfiguration;
            loggingBox = (TextBox) this.Controls.Find("bugtrackLog", true)[0];

            ScreenshotTimer.Interval = (2000);

            DelayScreenshot = new EventHandler(DelayedScreencapture);

            applicationPanel.VerticalScroll.Enabled = true;
            applicationPanel.VerticalScroll.Visible = true;
            applicationPanel.HorizontalScroll.Enabled = false;
            applicationPanel.HorizontalScroll.Visible = false;
            applicationPanel.AutoScroll = true;

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

            this.Size = new Size(368, 650);
        }

        private void CheckStandardApplications(RunningConfiguration rc)
        {
            List<Control> applicationCheckboxes = new List<Control>(Controls.Find("applicationCheckbox", true));

            foreach (var app in rc.Applications.Applications)
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

        private async void UpdateServerStatus(object sender, EventArgs args)
        {
            if(runningConfiguration.ServerStatus == ServerStatus.Available)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    serverStatusLabel.Text = "Available";
                }));
                
            }
            else
            {
                serverStatusLabel.Text = "Not Available";
            }

            this.Invoke(new MethodInvoker(delegate
            {
                lastConnectionTimeLabel.Text = runningConfiguration.ServerLastConnectionTime.ToLongTimeString();
            }));

        }

        private void AppendLogs(object sender, EventArgs args)
        {
            LoggedNewLineEventArgs eventArgs = (LoggedNewLineEventArgs) args;
            
            if(!this.IsDisposed)
                loggingBox.AppendText(eventArgs.Message + Environment.NewLine);
        }

        private void LoadAllApplicationsAsCheckboxes(RunningConfiguration rc)
        {

            FlowLayoutPanel flp = (FlowLayoutPanel) this.Controls.Find("applicationPanel", true)[0];

            foreach (var application in rc.Applications.GetApplications())
            {
                if ((application.ShowSpecifier == Application.ShowAppSpecifier.installed && application.IsInstalled) || 
                    application.ShowSpecifier == Application.ShowAppSpecifier.always)
                {

                    CheckBox cb = new CheckBox();

                    cb.Text = application.Name;
                    cb.Name = "applicationCheckbox";
                    cb.AutoSize = false;

                    cb.Anchor = (AnchorStyles)((int)AnchorStyles.Top + (int)AnchorStyles.Left);
                    cb.Margin = new Padding(2,2,2,2);
                    cb.MaximumSize = new Size(240, 33);
                    cb.Size = new Size(240, 33);

                    cb.CheckStateChanged += new EventHandler(CheckstateChangeLog);
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


            foreach (var problemCategory in rc.ProblemCategories.ProblemCategories)
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

            lb.Text = Bugtracker.Globals_and_Information.PCInfo.Hostname;
        }

        private void problemCategories_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ChangeCheckBoxState(false);

            var cb = (ComboBox) sender;

            var description =
                runningConfiguration.ProblemCategories.GetDescriptionForProblemByName((string) cb.SelectedItem);

            var tb = (TextBox) this.Controls.Find("problemDescription", true)[0];

            tb.Text = description + Environment.NewLine;

            CheckApplicationCheckboxesAccordingToProblemCategoryName((string)cb.SelectedItem);

            runningConfiguration.SelectedProblemCategory = runningConfiguration.ProblemCategories.GetProblemCategoryByName((string) cb.SelectedItem);

            Logger.Log("Changed Problem Category to " + (string) cb.SelectedItem, LoggingSeverity.Info);
        }
        
        public void CheckApplicationCheckboxesAccordingToProblemCategoryName(string problemCategoryName)
        {
            var pc = RunningConfiguration.GetInstance().ProblemCategories.GetProblemCategoryByName(problemCategoryName);

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
            this.Size = new Size(704, 650);
            showLogging = true;
        }

        private void HideLoggingWindow()
        {
            ToggleLog.Checked = false;
            this.Size = new Size(368, 650);
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
            SendHandler sh = new SendHandler(runningConfiguration.Targets.GetDefaultTargets());
            sh.Send(GetCurrentProblemDescriptor());

            this.Dispose();
            ScreenshotTimer.Stop();
            ScreenshotTimer.Dispose();
        }

        public void ChangeBugtrackerVersioName()
        {
            //if (ApplicationDeployment.IsNetworkDeployed)
             //   myVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion;
        }

        public List<InternalApplication.Application> GetAllTargetedApplications()
        {
            List<InternalApplication.Application> targetedApplications = new List<InternalApplication.Application>();
            ApplicationManager am = runningConfiguration.Applications;

            foreach (string app in GetApplicationsChecked())
            {
                if (am.GetApplicationByName(app) != null)
                    targetedApplications.Add(am.GetApplicationByName(app));
            }

            foreach (var app in runningConfiguration.Applications.Applications)
            {
                if (app.IsStandard)
                    targetedApplications.Add(app);
            }

            return targetedApplications;
        }

        private void StartScreenshotRoutine()
        {
            //if (screenshotCheckbox.Checked)
            //{
            //    ScreenshotTimer.Tick += DelayScreenshot;
            //    this.WindowState = FormWindowState.Minimized;
            //    ScreenshotTimer.Start();
            //}
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
                ProblemCategory = runningConfiguration.ProblemCategories.GetProblemCategoryByName((string) cb.SelectedItem),
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

        private void ComputerInfoToolStrip(object sender, EventArgs e)
        {
            if (pcinfo == null || pcinfo.IsDisposed)
                pcinfo = new PCInfo();

            pcinfo.ShowDialog(this);
        }

        private void ExitToolStrip(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Bugtracker_Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void support_button_Click(object sender, EventArgs e)
        {

        }

        private void selection_screenshot_button_Click(object sender, EventArgs e)
        {
            ScreenCaptureHandler sch = new ScreenCaptureHandler();
            sch.GenerateScreenshotFromBitmap(runningConfiguration.NewestBugtrackerFolder.FullName, new Bitmap(SnippingTool.Snip()));
            UtilFunctions.PlayShutterSound();
        }

        private void full_screenshot_button_Click(object sender, EventArgs e)
        {
            BugtrackerUtils.GenerateScreenCapture();
            UtilFunctions.PlayShutterSound();
        }

        private void procedure_screenshot_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Reproduzirbar reprodForm = new Reproduzirbar();
            reprodForm.BugtrackerMainForm = this;
            reprodForm.TopMost = true;
            reprodForm.Show(this);

            reprodForm.Disposed += new EventHandler(MaximizeBugtracker);
        }

        private void faq_button_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void screenshotCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
