using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private static BackgroundWorker bw = new BackgroundWorker();
        public static int currentVolume { get; set; } = 0;

        public static void Run()
        {
            // todo => only allow one at a time, maybe make the init run on load, but runWorkerAsync only in this method so no dupes
            bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(bw_Run_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_Run_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_Run_Completed);
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.RunWorkerAsync();
        }

        public static void Stop()
        {
            bw.CancelAsync();
        }

        private static void bw_Run_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Program.mainForm.UpdateStep(e.ProgressPercentage);
        }

        private static void bw_Run_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            Program.mainForm.UpdateStep(9);
        }

        //

        private static void bw_Run_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;

            // Lure
            //private static System.Timers.Timer lureTimer;
            //private static bool lureBuffExpired = false;

            while (true)
            {
                if (worker.CancellationPending) break;
                worker.ReportProgress(1);

                // use Lure if needed
                //if (useLure && lureBuffExpired)
                //{
                //    //UseLureMacro();
                //    Util.RandomSleep(10000, 12500);
                //}

                if (worker.CancellationPending) break;
                worker.ReportProgress(2);
                UseFishSkill();

                if (worker.CancellationPending) break;
                worker.ReportProgress(3);
                Util.Sleep(Config.castWaitTime);

                if (worker.CancellationPending) break;
                worker.ReportProgress(4);
                FindBobber();

                if (worker.CancellationPending) break;
                worker.ReportProgress(5);
                if (ListenForSplash())
                {
                    // catch fish
                    if (worker.CancellationPending) break;
                    worker.ReportProgress(6);
                    Mouse.Click(0, 0, false);
                }

                if (worker.CancellationPending) break;
                worker.ReportProgress(8);
                Util.RandomSleep();
            }
        }

        private static bool ListenForSplash(int timeout = 200, int updateRate = 100)
        {
            Logger.Log("Listening for spash...");
            Point location;

            for (int i = 0; i < timeout; i++)
            {
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

        private static void FindBobber(int colorFindMethod = 2)
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
            switch (colorFindMethod)
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
