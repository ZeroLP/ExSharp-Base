using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using ExSharpBase.Modules;

namespace ExSharpBase.Events
{
    class Game
    {
        public static void OnGameLoad(object sender, EventArrivedEventArgs e)
        {
            if (e.NewEvent.Properties["ProcessName"].Value.ToString().Equals("League of Legends.exe"))
            {
                //On Game Load event
                LogService.Log("League Started");
            }
        }

        public static void OnGameExit(object sender, EventArrivedEventArgs e)
        {
            if (e.NewEvent.Properties["ProcessName"].Value.ToString().Equals("League of Lege"))
            {
                Environment.Exit(0);
            }
        }
    }
}
