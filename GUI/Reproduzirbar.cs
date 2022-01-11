using System.Media;
using Bugtracker.Capture.Screen;
using Bugtracker.Configuration;
using Bugtracker.Utils;

namespace Bugtracker_UI.GUI
{
    public partial class Reproduzirbar : Form
    {
        private bool isRecording;
        ScreenCaptureHandler sch;
        System.Windows.Forms.Timer screenshotTimer = new System.Windows.Forms.Timer();
        Graphics g = Graphics.FromHwnd(IntPtr.Zero);

        public Reproduzirbar()
        {
            InitializeComponent();

            //this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            //this.Load += new System.EventHandler(Form_Load);
            //this.TopMost = true;

            this.BringToFront();
            this.Activate();
            this.Focus();


            screenshotTimer.Tick += new EventHandler(screenshotTimerTick);
            screenshotTimer.Interval = 250;

            sch = new ScreenCaptureHandler();

            this.Deactivate += generateScreenshot;

            this.DoubleBuffered = true;

            BackColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Bounds = Screen.PrimaryScreen.Bounds;
            TransparencyKey = BackColor;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
            this.Left = workingArea.Left + workingArea.Width - this.Size.Width;
            this.Top = workingArea.Top + workingArea.Height - this.Size.Height;
        }

        private void screenshotTimerTick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            screenshotTimer.Stop();
        }

        private void generateScreenshot(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Lost Focus");

            if (isRecording)
            {
                //SystemSounds.Exclamation.Play();

                this.WindowState = FormWindowState.Minimized;

                System.Diagnostics.Debug.WriteLine("Took screenshot");
                sch.GenerateScreenshot(RunningConfiguration.GetInstance().NewestBugtrackerFolder.FullName, true);

                screenshotTimer.Start();

                this.BringToFront();
                this.Activate();
                this.Focus();
            }
        }

        private void startButtonClick(object sender, EventArgs e)
        {
            isRecording = true;
        }

        private void stopButtonClick(object sender, EventArgs e)
        {
            isRecording = false;
            Dispose();
        }
    }
}
