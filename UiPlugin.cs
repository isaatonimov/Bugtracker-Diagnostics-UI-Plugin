using Bugtracker.Configuration;
using Bugtracker.GUI;
using Bugtracker.Plugin;

namespace Bugtracker_UI
{
    internal class UiPlugin : IPlugin
    {
        public string Name => "Bugtracker GUI";

        public string Version => "1.1";

        public string Author => "Dominik Beyerle";

        public void OnLoad()
        {
            RunningConfiguration runningConfiguration = RunningConfiguration.GetInstance();

            Application.EnableVisualStyles();

            runningConfiguration.MainGui = new Bugtracker_Form();

            //Hide Console
            runningConfiguration.HideConsole = true;

            Application.Run(RunningConfiguration.GetInstance().MainGui);
        }
    }


}
