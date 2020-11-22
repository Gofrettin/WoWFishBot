using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWFishBot
{
    public static class Bot
    { 
        // Lure
        private static System.Timers.Timer lureTimer;
        private static bool lureBuffExpired = false;

        // Misc
        public static int currentVolume { get; set; }

        public static void Run()
        {
            while (true)
            {
                Program.mainForm.UpdateStep(1);

                // use Lure if needed
                //if (useLure && lureBuffExpired)
                //{
                //    //UseLureMacro();
                //    Util.RandomSleep(10000, 12500);
                //}

                Program.mainForm.UpdateStep();
                UseFishSkill();

                Program.mainForm.UpdateStep();
                Util.Sleep(3000); // wait for bobber

                Program.mainForm.UpdateStep();
                FindBobber(2);

                Program.mainForm.UpdateStep();
                if (ListenForSplash())
                {
                    // catch fish
                    Program.mainForm.UpdateStep();
                    Mouse.Click(0, 0, false);
                }

                Program.mainForm.UpdateStep();
                Util.RandomSleep();
            }
        }

        private static bool ListenForSplash(int timeout = 200, int updateRate = 100)
        {
            Program.mainForm.UpdateStatusBar("Listening for spash...");
            Point location;


            for (int i = 0; i < timeout; i++)
            {
                Audio.GetCurrentVolume();

                if (currentVolume >= Config.triggerVolumePercent)
                {
                    // Test for pause
                    location = Mouse.CurrentLocation();
                    if (location.X <= 25 && location.Y <= 25)
                    {
                        Logger.Log("Pause requested");
                        //Pause(); TODO
                        return false;
                    }
                    else
                    {
                        Logger.Log($"Splash detected at {currentVolume}%");
                        return true;
                    }
                }

                Mouse.RandomSway();

                // Rate to check volume
                Util.Sleep(updateRate);
            }

            //Timeout Reached
            Logger.Log("Splash timeout detected");
            location = Mouse.CurrentLocation();
            if (location.X <= 25 && location.Y <= 25)
            {
                Logger.Log("Pause requested");
                //Pause();
            }

            return false;
        }

        private static void UseFishSkill()
        {
            Logger.Log("Using fish skill");
            //TODO: Should this move smoothly here?
            Mouse.Click(
                (uint)(Config.fishSkillCords.X + Util.rand.Next(-5, 5)), 
                (uint)(Config.fishSkillCords.Y + Util.rand.Next(-5, 5)));

            Logger.Log("Moving mouse to random area within search area +/- 100 pixels x/y");
            Mouse.SmoothMouseMove(
                Config.topLeftCords.X + (((Config.bottomRightCords.X - Config.topLeftCords.X) / 2) + Util.rand.Next(-50, 50)),
                Config.topLeftCords.Y + (((Config.bottomRightCords.Y - Config.topLeftCords.Y) / 2) + Util.rand.Next(-50, 50)));
        }

        private static void FindBobber(int mode)
        {
            Logger.Log("Looking for bobber");

            List<Color> foundColorList = new List<Color>();
            List<Point> locationList = new List<Point>();

            // Capture Screenshot
            Bitmap screenShot = Screen.CaptureScreen();

            // Search
            foundColorList.Clear();
            locationList.Clear();

            Logger.Log("Gathering colors in screenshot");
            for (int i = 0; i < screenShot.Width; i++)
            {
                for (int j = 0; j < screenShot.Height; j++)
                {
                    Color pixel = screenShot.GetPixel(i, j);
                    Point location = new Point(i, j);
                    foundColorList.Add(pixel);
                    locationList.Add(location);
                }
            }

            Logger.Log("Looking for closest to configured bobber color");
            int closest = 0;
            switch (mode)
            {
                case 1:
                    closest = Screen.FindColor_Method1(foundColorList, Config.bobberColor);
                    break;
                case 2:
                    closest = Screen.FindColor_Method2(foundColorList, Config.bobberColor);
                    break;
                case 3:
                    closest = Screen.FindColor_Method3(foundColorList, Config.bobberColor);
                    break;
                default:
                    break;
            }

            Logger.Log("Moving mouse to closest color found");
            Mouse.SmoothMouseMove(locationList[closest].X + Config.topLeftCords.X, locationList[closest].Y + Config.topLeftCords.Y);
        }
    }
}
