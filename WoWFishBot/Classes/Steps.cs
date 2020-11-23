using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWFishBot
{
    public class Steps
    {
        // Not used at this time.

        public string UseFishSkill = "Use fish skill";
        public string FindBobber = "Find bobber";
        public string ListenForSplash = "Listen for splash";
        public string CatchFish = "Catch fish";
        public string RandomSleep = "Random sleep";
        public string Paused = "Paused";

        public string currentStep { get; set; }
    }
}
