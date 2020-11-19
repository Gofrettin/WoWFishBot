using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWFishBot
{
    public static class Config
    {
        // CONFIG
        public static float triggerVolumePercent { get; set; }
        public static float sleepChancePercent { get; set; }
        public static float delayMultiplyer { get; set; }
        public static bool useLure { get; set; }
        public static Point topLeftCords { get; set; }
        public static Point bottomRightCords { get; set; }
        public static Point lureLocation { get; set; }
        public static Point skillLocation { get; set; }
        public static Color searchColor { get; set; }

        // GLOBALS
        private static Random randomNumber = new Random();
        private static float saturationFactor_MAYBE = 1;
        private static float brightnessFactor_MAYBE = 1;
        private static Bitmap screenCapture = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        private static Size searchRectangleSize;
        private static List<Color> foundColorList = new List<Color>();
        private static List<Point> locationList = new List<Point>();

        //Lure
        private static System.Timers.Timer lureTimer;
        private static bool lureBuffExpired = false;

        public static void CaptureAll()
        {
            Logger.Log("Capturing settings");
            Program.mainForm.ClearAllCaptureInputs();

            // TOP LEFT
            Bot.Sleep(1000);
            CaptureTopLeft();
            Console.Beep();

            // BOTTOM RIGHT
            Bot.Sleep(1000);
            CaptureBottomRight();
            Console.Beep();

            // LURE
            Bot.Sleep(1000);
            CaptureLureSkill();
            Console.Beep();

            // SKILL
            Bot.Sleep(1000);
            CaptureFishSkill();
            Console.Beep();

            // COLOR
            //Bot.Sleep(1000);
            //topLeftCords = Bot.GetMouseLocation();
        }

        public static void CaptureTopLeft(int captureDelay = 0)
        {
            Bot.Sleep(captureDelay);
            topLeftCords = Bot.GetMouseLocation();
            Program.mainForm.TopLeft.Text = topLeftCords.ToString();
            Logger.Log($"Top left captured: {topLeftCords}");
        }
        public static void CaptureBottomRight(int captureDelay = 0)
        {
            Bot.Sleep(captureDelay);
            bottomRightCords = Bot.GetMouseLocation();
            Program.mainForm.BottomRight.Text = bottomRightCords.ToString();
            Logger.Log($"Bottom right captured: {bottomRightCords}");
        }
        public static void CaptureLureSkill(int captureDelay = 0)
        {
            Bot.Sleep(captureDelay);
            lureLocation = Bot.GetMouseLocation();
            Program.mainForm.LureSkill.Text = lureLocation.ToString();
            Logger.Log($"Lure skill captured: {lureLocation}");
        }
        public static void CaptureFishSkill(int captureDelay = 0)
        {
            Bot.Sleep(captureDelay);
            skillLocation = Bot.GetMouseLocation();
            Program.mainForm.FishSkill.Text = skillLocation.ToString();
            Logger.Log($"Fish skill captured: {skillLocation}");
        }
        public static void CaptureBobberColor(int captureDelay = 0)
        {
            Bot.Sleep(captureDelay);
            // TODO
            Program.mainForm.BobberColor.Text = "TODO";
            Logger.Log($"Bobber color captured: TODO");
        }

    }

}
