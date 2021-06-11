using System;
using System.IO;
using System.Threading;

namespace WoWFishBot
{
    static public class Logger
    {
        public enum Level { Trace, Debug, Info, Warn, Error }
        private static StreamWriter Writer = new StreamWriter("log.txt");

        static public void Log(string message, Level level = Level.Trace)
        {
            DateTime now = DateTime.Now;
            message = $"[{now.Hour}:{now.Minute}:{now.Millisecond}] [{level}] {message}";

            Console.WriteLine(message);
            Writer.WriteLine(message);
        }
    }
}
