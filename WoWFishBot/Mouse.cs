﻿using System;
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
                Bot.Sleep(delay);
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
            if (Bot.randomNumber.Next(1, 100) >= chanceToDo)
                return;

            Point currentLoc = CurrentLocation();
            Point newLoc = new Point(
                currentLoc.X + Bot.randomNumber.Next(-swayDistance, swayDistance), 
                currentLoc.Y + Bot.randomNumber.Next(-swayDistance, swayDistance));
            SmoothMouseMove(newLoc, 10, 10); // sway to random spot
            SmoothMouseMove(currentLoc, 10, 10); // return to starting point
        }
    }
}
