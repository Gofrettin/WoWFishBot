using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWFishBot
{
    static public class Logger
    {
        public enum Level { Trace, Debug, Info, Warn, Error }

        static public void Log(string message, Level level, bool showInStatusBar)
        {
            // show in status bar
            if (showInStatusBar) Program.mainForm.UpdateStatusBar(message);

            // add timestamp
            DateTime now = DateTime.Now;
            message = $"[{now.Hour}:{now.Minute}:{now.Millisecond}] [{level}] {message}";

            // write
            Console.WriteLine(message);
            Program.mainForm.UpdateLog(message);
        }

        static public void Log(string message) => Log(message, Level.Trace, false);
        static public void StatusBar(string message) => Log(message, Level.Trace, false);
    }
}
