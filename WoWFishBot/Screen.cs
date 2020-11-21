﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWFishBot
{
    class Screen
    {
        private static Bitmap screenCapture = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        private static float saturationFactor_MAYBE = 1;
        private static float brightnessFactor_MAYBE = 1;

        public static Bitmap CaptureScreen()
        {
            Logger.Log("Capturing new screenshot");
            Size searchRectangleSize = new Size(Config.bottomRightCords.X - Config.topLeftCords.X, Config.bottomRightCords.Y - Config.topLeftCords.Y);

            Bitmap image = new Bitmap(searchRectangleSize.Width, searchRectangleSize.Height, PixelFormat.Format32bppArgb);
            Graphics screenShot = Graphics.FromImage(image);
            screenShot.CopyFromScreen(Config.topLeftCords.X, Config.topLeftCords.Y, 0, 0, searchRectangleSize, CopyPixelOperation.SourceCopy);
            image.Save("test.bmp");
            Program.mainForm.UpdatePictureBox(image);

            return image;
        }

        /// <summary>
        /// Gets color at specified location
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public static Color GetColorAtLocation(Point location)
        {
            Logger.Log($"Getting color at {location}");

            using (Graphics gdest = Graphics.FromImage(screenCapture))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenCapture.GetPixel(0, 0);
        }

        private static int BitBlt(IntPtr hDC, int v1, int v2, int v3, int v4, IntPtr hSrcDC, int x, int y, int sourceCopy)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets color at cursor location
        /// </summary>
        /// <returns></returns>
        public static Color GetColorAtLocation() => GetColorAtLocation(Mouse.CurrentLocation());

        // Find color methods
        public static int FindColor_Method1(List<Color> colors, Color target)
        {
            Logger.Log($"Looking for pixel closest to {target} (Method 1)");

            var hue1 = target.GetHue();
            var diffs = colors.Select(n => GetHueDistance(n.GetHue(), hue1));
            var diffMin = diffs.Min(n => n);
            return diffs.ToList().FindIndex(n => n == diffMin);
        }
        public static int FindColor_Method2(List<Color> colors, Color target)
        {
            Logger.Log($"Looking for pixel closest to {target} (Method 2)");

            var colorDiffs = colors.Select(n => ColorDifference(n, target)).Min(n => n);
            return colors.FindIndex(n => ColorDifference(n, target) == colorDiffs);
        }
        public static int FindColor_Method3(List<Color> colors, Color target)
        {
            Logger.Log($"Looking for pixel closest to {target} (Method 3)");

            float hue1 = target.GetHue();
            var num1 = ColorNumber(target);
            var diffs = colors.Select(n => Math.Abs(ColorNumber(n) - num1) +
                                           GetHueDistance(n.GetHue(), hue1));
            var diffMin = diffs.Min(x => x);
            return diffs.ToList().FindIndex(n => n == diffMin);
        }
        private static float GetBrightness(Color c)
        { return (c.R * 0.299f + c.G * 0.587f + c.B * 0.114f) / 256f; }
        private static float GetHueDistance(float hue1, float hue2)
        {
            float d = Math.Abs(hue1 - hue2); return d > 180 ? 360 - d : d;
        }
        private static float ColorNumber(Color c)
        {
            return c.GetSaturation() * saturationFactor_MAYBE +
                        GetBrightness(c) * brightnessFactor_MAYBE;
        }
        private static int ColorDifference(Color c1, Color c2)
        {
            return (int)Math.Sqrt((c1.R - c2.R) * (c1.R - c2.R)
                                   + (c1.G - c2.G) * (c1.G - c2.G)
                                   + (c1.B - c2.B) * (c1.B - c2.B));
        }
    }
}