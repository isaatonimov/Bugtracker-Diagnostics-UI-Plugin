using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bugtracker.Configuration;
using Bugtracker.Plugin;

namespace Bugtracker.GUI
{
    internal class UiPlugin : IPlugin
    {
        public string Name => "Bugtracker GUI";

        public string Version => "1.1";

        public string Author => "Dominik Beyerle";

        public void OnLoad()
        {
            RunningConfiguration runningConfiguration = RunningConfiguration.GetInstance();

            System.Windows.Forms.Application.EnableVisualStyles();
            
            runningConfiguration.MainGui = new Bugtracker();

            //Hide Console
            runningConfiguration.HideConsole = true;

            System.Windows.Forms.Application.Run(RunningConfiguration.GetInstance().MainGui);
        }
    }


}
