using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bugtracker_UI.Utils
{
    internal static class UtilFunctions
    {
        public static void PlayShutterSound()
        {
            SoundPlayer sb = new SoundPlayer(Bugtracker_UI.Properties.Resources.shutter);
            sb.Play();
        }
    }
}
