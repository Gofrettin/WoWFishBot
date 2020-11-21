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
        public static float sleepMultiplier { get; set; }
        public static bool useLure { get; set; }
        public static Point topLeftCords { get; set; }
        public static Point bottomRightCords { get; set; }
        public static Point lureLocation { get; set; }
        public static Point skillLocation { get; set; }
        public static Color searchColor { get; set; }


        /// <summary>
        /// Captures all settings
        /// </summary>
        public static void CaptureAll()
        {
            Logger.Log("Capturing settings");
            ClearAllCaptureInputs();

            // START CAPTURE PEAK VOLUME
            Audio.GetPeakVolume();

            // TOP LEFT
            Util.Sleep(1000);
            CaptureTopLeft();
            //Console.Beep();

            // BOTTOM RIGHT
            Util.Sleep(1000);
            CaptureBottomRight();
            Screen.CaptureScreen();
            //Console.Beep();

            // LURE
            Util.Sleep(1000);
            CaptureLureSkill();
            //Console.Beep();

            // SKILL
            Util.Sleep(1000);
            CaptureFishSkill();
            //Console.Beep();

            // COLOR => TODO
            Util.Sleep(1000);
            CaptureBobberColor();
            //Console.Beep();

            Logger.Log("All captures complete");
        }

        public static void CaptureTopLeft(int captureDelay = 0)
        {
            Program.mainForm.Inp_TopLeft.Text = "Capturing...";
            Util.Sleep(captureDelay);
            topLeftCords = Mouse.CurrentLocation();
            Program.mainForm.Inp_TopLeft.Text = topLeftCords.ToString();
            Logger.Log($"Top left captured: {topLeftCords}");
        }
        public static void CaptureBottomRight(int captureDelay = 0)
        {
            Program.mainForm.Inp_BottomRight.Text = "Capturing...";
            Util.Sleep(captureDelay);
            bottomRightCords = Mouse.CurrentLocation();
            Program.mainForm.Inp_BottomRight.Text = bottomRightCords.ToString();
            Logger.Log($"Bottom right captured: {bottomRightCords}");
        }
        public static void CaptureLureSkill(int captureDelay = 0)
        {
            Program.mainForm.Inp_LureSkill.Text = "Capturing...";
            Util.Sleep(captureDelay);
            lureLocation = Mouse.CurrentLocation();
            Program.mainForm.Inp_LureSkill.Text = lureLocation.ToString();
            Logger.Log($"Lure skill captured: {lureLocation}");
        }
        public static void CaptureFishSkill(int captureDelay = 0)
        {
            Program.mainForm.Inp_FishSkill.Text = "Capturing...";
            Util.Sleep(captureDelay);
            skillLocation = Mouse.CurrentLocation();
            Program.mainForm.Inp_FishSkill.Text = skillLocation.ToString();
            Logger.Log($"Fish skill captured: {skillLocation}");
        }
        public static void CaptureBobberColor(int captureDelay = 0)
        {
            Program.mainForm.Inp_BobberColor.Text = "Capturing...";
            Util.Sleep(captureDelay);
            searchColor = Screen.GetColorAtLocation();
            Program.mainForm.Inp_BobberColor.Text = $"{searchColor.R}, {searchColor.G}, {searchColor.B}";
            Logger.Log($"Bobber color captured: {searchColor}");
        }

        public static void ClearAllCaptureInputs()
        {
            Program.mainForm.UpdatePeakVolueControls(0);
            Program.mainForm.Inp_TopLeft.Text = string.Empty;
            Program.mainForm.Inp_BottomRight.Text = string.Empty;
            Program.mainForm.Inp_LureSkill.Text = string.Empty;
            Program.mainForm.Inp_FishSkill.Text = string.Empty;
            Program.mainForm.Inp_BobberColor.Text = string.Empty;
            Logger.Log("Cleared all capture inputs");
        }

        public static void ValidateConfig()
        {
            
        }
    }

}
