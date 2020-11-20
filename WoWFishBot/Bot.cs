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
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        //Used to get color
        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);


        // GLOBALS
        private static Bitmap screenCapture = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        private static Random randomNumber = new Random();
        private static float saturationFactor_MAYBE = 1;
        private static float brightnessFactor_MAYBE = 1;
        private static Size searchRectangleSize;
        private static List<Color> foundColorList = new List<Color>();
        private static List<Point> locationList = new List<Point>();

        //Lure
        private static System.Timers.Timer lureTimer;
        private static bool lureBuffExpired = false;
        public static void Sleep(int time) => Task.Delay(time).Wait();

        /// <summary>
        /// Gets mouse location as a Point
        /// </summary>
        /// <returns></returns>
        public static Point GetMouseLocation() => new Point(Cursor.Position.X, Cursor.Position.Y);

        /// <summary>
        /// Gets color at specified location
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public static Color GetColorAtLocation(Point location)
        {
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

        /// <summary>
        /// Gets color at cursor location
        /// </summary>
        /// <returns></returns>
        public static Color GetColorAtLocation() => GetColorAtLocation(GetMouseLocation());

        private static void GenerateCaptureRectangle() => searchRectangleSize = new Size(Config.bottomRightCords.X - Config.topLeftCords.X, Config.bottomRightCords.Y - Config.topLeftCords.Y);

        public static void CaptureScreen()
        {
            GenerateCaptureRectangle();

            Bitmap image = new Bitmap(searchRectangleSize.Width, searchRectangleSize.Height, PixelFormat.Format32bppArgb);
            Graphics screenShot = Graphics.FromImage(image);
            screenShot.CopyFromScreen(Config.topLeftCords.X, Config.topLeftCords.Y, 0, 0, searchRectangleSize, CopyPixelOperation.SourceCopy);
            image.Save("test.bmp");
            Program.mainForm.UpdatePictureBox(image);
        }

        public static void Run()
        {
            // init
            GenerateCaptureRectangle();

        }

    }
}
