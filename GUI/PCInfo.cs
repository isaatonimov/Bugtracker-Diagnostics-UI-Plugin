using Bugtracker.Configuration;
using Bugtracker.Plugin;

namespace Bugtracker.GUI
{
    public partial class PCInfo : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PCInfo_Form_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public PCInfo()
        {
            InitializeComponent();

            this.CenterToParent();

            LoadVariableList();
            LoadPluginList();
            LoadPCInfo();
        }

        private void LoadPCInfo()
        {
            RunningConfiguration rc = RunningConfiguration.GetInstance();

            TextBox tb = (TextBox)this.Controls.Find("pcInfoText", true)[0];
            tb.Text = Globals_and_Information.PCInfo.Summary();

            foreach(IPlugin pl in RunningConfiguration.GetInstance().LoadedPlugins)
            {
                tb.Text += "\n" + pl.Name + pl.Version;
            }
        }

        private void LoadPluginList()
        {
            var source = RunningConfiguration.GetInstance().LoadedPlugins;
            pluginsList.DataSource = source.ToList();
            System.Diagnostics.Debug.WriteLine("List Count Plugins: " + source.Count);
        }

        private void LoadVariableList()
        { 
            var source = RunningConfiguration.GetInstance().Variables.VariableDictionary;
            dataGridVariables.DataSource = (from entry in source orderby entry.Key select new{entry.Key,entry.Value}).ToList();
        }

        private void pcInfoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
