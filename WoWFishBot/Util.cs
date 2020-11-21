using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWFishBot
{
    public static class Util
    {
        public static Random rand = new Random();

        public static void Sleep(int time) => Task.Delay(time).Wait();

        public static void RandomSleep(int min = 3000, int max = 6000)
        {
            int SleepLength = Convert.ToInt32(rand.Next(min, max) * Config.sleepMultiplier);
            Sleep(SleepLength);
        }
    }
}
