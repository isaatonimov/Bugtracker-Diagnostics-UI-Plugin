using System.Media;
using Bugtracker.Capture.Screen;

namespace Bugtracker_UI.GUI
{
    public partial class Reproduzirbar : Form
    {
        private bool isRecording;

        public Reproduzirbar()
        {
            InitializeComponent();

            this.LostFocus += generateScreenshot;
        }

        private void generateScreenshot(object sender, EventArgs e)
        {
            if (isRecording)
            {
                SystemSounds.Exclamation.Play();
                ScreenCaptureHandler sch = new ScreenCaptureHandler();

                sch.GenerateScreenshotInSequence();
                Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isRecording = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isRecording = false;
            Dispose();
        }
    }
}
