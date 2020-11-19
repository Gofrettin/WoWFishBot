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
            Console.WriteLine(message);
            if (showInStatusBar) Program.mainForm.UpdateStatusBar(message);
        }

    }
}
