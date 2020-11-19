using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWFishBot
{
    public static class Stats
    {
        //Global Stats
        private static int caughtCount = 0;
        private static double totalMinutes = 0;
        private static DateTime startTime = DateTime.Now;
        private static List<double> averageTriggerVolume = new List<double>();
    }
}