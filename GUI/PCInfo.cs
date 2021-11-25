using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bugtracker.Configuration;

namespace Bugtracker.GUI
{
    public partial class PCInfo : Form
    {
        public PCInfo()
        {
            InitializeComponent();

            LoadPCInfo();
        }

        private void LoadPCInfo()
        {
            RunningConfiguration rc = RunningConfiguration.GetInstance();

            TextBox tb = (TextBox)this.Controls.Find("pcInfoText", true)[0];
            tb.Text = rc.PcInfo.GetPCInformationSummary();
        }
    }
}
