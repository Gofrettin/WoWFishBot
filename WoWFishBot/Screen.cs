using System;
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

        private static int BitBlt(IntPtr hDC, int v1, int v2, int v3, int v4, IntPtr hSrcDC, int x, int y, int sourceCopy)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets color at cursor location
        /// </summary>
        /// <returns></returns>
        public static Color GetColorAtLocation() => GetColorAtLocation(Mouse.CurrentLocation());
    }
}
