﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CollisionExample.Collisions
{
    public static class CollisisionHelper
    {
        /// <summary>
        /// detects collision between two BoundingCircle
        /// </summary>
        /// <param name="a">first bounding circle</param>
        /// <param name="b">second bounding circle</param>
        /// <returns>true for collision, false otherwise</returns>
        public static bool Collides(BoundingCircle a, BoundingCircle b)
        {
            return Math.Pow(a.Radius + b.Radius, 2) >= Math.Pow(a.Center.X - b.Center.X, 2) + Math.Pow(a.Center.Y - b.Center.Y, 2);
        }
        /// <summary>
        /// detects collision between two BoundingRectangle
        /// </summary>
        /// <param name="a">first bounding rectangle</param>
        /// <param name="b">second bounding rectangle</param>
        /// <returns>true for collision, false otherwise</returns>
        public static bool Collides(BoundingRectangle a, BoundingRectangle b)
        {
            return !(a.Right < b.Left || a.Left > b.Right
                || a.Top > b.Bottom || a.Bottom < b.Top);
        }

        /// <summary>
        /// detects collision between a rectangle and a circle
        /// </summary>
        /// <param name="a">the boundingcirlce</param>
        /// <param name="b">the bounding rectangle</param>
        /// <returns>true for collision, false otherwise</returns>
        public static bool Collides(BoundingCircle c, BoundingRectangle r)
        {
            float nearestX = MathHelper.Clamp(c.Center.X, r.Left, r.Right);
            float nearestY = MathHelper.Clamp(c.Center.Y, r.Top, r.Bottom);
            return Math.Pow(c.Radius, 2) >= Math.Pow(c.Center.X - nearestX, 2) + Math.Pow(c.Center.Y - nearestY, 2);
        }
        /// <summary>
        /// detects collision between a rectangle and a circle
        /// </summary>
        /// <param name="a">the boundingcirlce</param>
        /// <param name="b">the bounding rectangle</param>
        /// <returns>true for collision, false otherwise</returns>
        public static bool Collides(BoundingRectangle r, BoundingCircle c)
        {
            float nearestX = MathHelper.Clamp(c.Center.X, r.Left, r.Right);
            float nearestY = MathHelper.Clamp(c.Center.Y, r.Top, r.Bottom);
            return Math.Pow(c.Radius, 2) >= Math.Pow(c.Center.X - nearestX, 2) + Math.Pow(c.Center.Y - nearestY, 2);
        }
    }
}
