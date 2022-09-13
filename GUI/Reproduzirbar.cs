using Bugtracker.Capture.LogProcessing;
using Bugtracker.Capture.Screen;
using Bugtracker.Configuration;
using Bugtracker.GUI;
using Bugtracker_UI.Utils;

namespace Bugtracker_UI.GUI
{
    public partial class Reproduzirbar : Form
    {
        public Bugtracker_Main_Form BugtrackerMainForm;

        private bool isRecording;
        ScreenCaptureHandler sch;
        System.Windows.Forms.Timer screenshotTimer = new System.Windows.Forms.Timer();
        Graphics g = Graphics.FromHwnd(IntPtr.Zero);

        public Reproduzirbar()
        {
            InitializeComponent();

            this.BringToFront();
            this.Activate();
            this.Focus();

            screenshotTimer.Tick += new EventHandler(screenshotTimerTick);
            screenshotTimer.Interval = 250;

            sch = new ScreenCaptureHandler();

            //this.Deactivate += generateScreenshot;
            //this.DoubleBuffered = true;

            BackColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Bounds = Screen.PrimaryScreen.Bounds;
            TransparencyKey = BackColor;

        }

        void OnMouseClick()
        {

        }

        private void Form_Load(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
            this.Left = workingArea.Left + workingArea.Width - this.Size.Width;
            this.Top = workingArea.Top + workingArea.Height - this.Size.Height;
        }

        private void screenshotTimerTick(object sender, EventArgs e)
        {
            //if()
        }

        private void generateScreenshot(object sender, EventArgs e)
        {
            if (isRecording)
            {
                this.WindowState = FormWindowState.Minimized;

                System.Diagnostics.Debug.WriteLine("Took screenshot");
                sch.GenerateScreenshot(RunningConfiguration.GetInstance().NewestBugtrackerFolder.FullName, true);
                UtilFunctions.PlayShutterSound();

                screenshotTimer.Start();

                this.BringToFront();
                this.Activate();
                this.Focus();
            }
        }

        private void startButtonClick(object sender, EventArgs e)
        {
            string targetApps = "";

            foreach(var Target in BugtrackerMainForm.GetAllTargetedApplications())
            {
                targetApps += Target.Name + Environment.NewLine;
            }

            DialogResult dialogResult = MessageBox.Show("Möchten sie die Logs vor aufzeichnung für folgende Applikationen löschen?:\n\n" + targetApps
                , "Logs löschen?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                LogProcessor.DeleteAllTargeted(BugtrackerMainForm.GetAllTargetedApplications());
            }

            stopButton.Size = new Size(stopButton.Size.Width, 40);
            startButton.Size = new Size(startButton.Size.Width, 0);

            isRecording = true;

        }

        private void stopButtonClick(object sender, EventArgs e)
        {
            startButton.Size = new Size(startButton.Size.Width, 40);
            stopButton.Size = new Size(stopButton.Size.Width, 0);
            isRecording = false;
            Dispose();
        }
    }
}
