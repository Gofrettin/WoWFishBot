using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWFishBot
{
    public static class Mouse
    {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        /// <summary>
        /// Gets mouse location as a Point
        /// </summary>
        /// <returns></returns>
        public static Point CurrentLocation() => new Point(Cursor.Position.X, Cursor.Position.Y);

        /// <summary>
        /// Moves mouse to specified point/XY
        /// </summary>
        /// <param name="loc"></param>
        public static void MouseMove(Point loc) => SetCursorPos(loc.X, loc.Y);
        public static void MouseMove(int X, int Y) => SetCursorPos(X, Y);

        /// <summary>
        /// Moves mouse in a more natural motion
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="step"></param>
        public static void SmoothMouseMove(int X, int Y, int step = 5) => SmoothMouseMove(new Point(X, Y), 100);
        public static void SmoothMouseMove(Point newPosition, int steps = 10, int delay = 2)
        {
            Point startLocation = CurrentLocation();
            PointF iterPoint = startLocation;

            PointF slope = new PointF(newPosition.X - startLocation.X, newPosition.Y - startLocation.Y);

            slope.X = slope.X / steps;
            slope.Y = slope.Y / steps;

            //Move mouse smoothly
            for (int i = 0; i < steps; i++)
            {
                iterPoint = new PointF(iterPoint.X + slope.X, iterPoint.Y + slope.Y);
                MouseMove(Point.Round(iterPoint));
                Util.Sleep(delay);
            }
            MouseMove(newPosition);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chanceToDo">% chance to sway the mouse</param>
        /// <param name="swayDistance">Max pixels mouse may move</param>
        public static void RandomSway(int chanceToDo = 1, int swayDistance = 10)
        {
            // Only do X % of the time
            if (Util.rand.Next(1, 100) >= chanceToDo)
                return;

            Point currentLoc = CurrentLocation();
            Point newLoc = new Point(
                currentLoc.X + Util.rand.Next(-swayDistance, swayDistance), 
                currentLoc.Y + Util.rand.Next(-swayDistance, swayDistance));
            SmoothMouseMove(newLoc, 10, 10); // sway to random spot
            SmoothMouseMove(currentLoc, 10, 10); // return to starting point
        }

        public static void Click(int x = 0, int y = 0, bool leftClick = true)
        {
            if (x < 0 || y < 0)
                throw new Exception("Error: Cannot use negative numbers for click action (conversion to uint fails)");

            //Click in current mouse location
            if (x == 0 & y == 0)
            {
                x = Cursor.Position.X;
                y = Cursor.Position.Y;
                if (leftClick)
                    mouse_event(0x02 | 0x04, Convert.ToUInt32(x), Convert.ToUInt32(y), 0, 0);
                else
                    mouse_event(0x08 | 0x10, Convert.ToUInt32(x), Convert.ToUInt32(y), 0, 0);
            }
            else //Move mouse and click at specified location
            {
                SmoothMouseMove(x, y);
                Util.RandomSleep(100, 600);
                if (leftClick)
                    mouse_event(0x02 | 0x04, Convert.ToUInt32(x), Convert.ToUInt32(y), 0, 0);
                else
                    mouse_event(0x08 | 0x10, Convert.ToUInt32(x), Convert.ToUInt32(y), 0, 0);
                Util.RandomSleep(100, 600);
            }
        }
    }
}
