using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWFishBot
{
    static public class Logger
    {
        static public void Log(string message, bool showInStatusBar = true)
        {
            // show in status bar
            if (showInStatusBar) Program.mainForm.UpdateStatusBar(message);

            // add timestamp
            DateTime now = DateTime.Now;
            message = $"[{now.Hour}:{now.Minute}:{now.Millisecond}] {message}";

            // write
            Console.WriteLine(message);
            Program.mainForm.UpdateLog(message);
        }

    }
}
