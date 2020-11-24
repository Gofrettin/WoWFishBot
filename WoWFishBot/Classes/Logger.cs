using System;
using System.IO;
using System.Threading;

namespace WoWFishBot
{
    static public class Logger
    {
        public enum Level { Trace, Debug, Info, Warn, Error }

        static public void Log(string message, Level level = Level.Trace)
        {
            DateTime now = DateTime.Now;
            message = $"[{now.Hour}:{now.Minute}:{now.Millisecond}] [{level}] {message}";

            Console.WriteLine(message);
            using (StreamWriter writer = new StreamWriter("log.txt"))
                writer.WriteLine(message);
        }
    }
}
