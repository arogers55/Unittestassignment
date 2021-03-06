﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointLib
{

    public class Point
    {
        private double x;
        private double y;



        public Point()
        {
            x = y = 0;
        }

        public Point(double newX, double newY)
        {
            x = newX;
            y = newY;
        }

        // returns x and y values of the point, respectively
        public double getX() { return x; }
        public double getY() { return y; }

        // Stretches the point by increasing the distance between the point and zero
        // by the factor scale.  For example, applying stretch(3) to the point (2,3)
        // should yield (6,9).  Only non-negative scale values should be allowed.
        public void Stretch(double scale)
        {
            if (scale > 0)
            {
                x = x * scale;
                y = y * scale;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        // calculates the stright-line distance between two points.  The value should
        // always be non-negative.
        /* public double Distance(Point p1, Point p2)
         {

         double x = p2.getX() - p1.getX();
         double y = p2.getY() - p1.getY();

         double xsq = Math.Pow(x, 2);
         double ysq = Math.Pow(y, 2);

         double add = xsq + ysq;

         double ans = Math.Sqrt(add);

         return ans;
     }*/

        public double Distance()
        {
            return 0;
        }

        // Rotates the point counter-clockwise by deg degrees.  For example, applying
        // a 90 degree rotation to (1, 0) should give (0, 1).
        public void Rotate(double deg)
        {
            double rotCos = Math.Cos(deg * Math.PI / 180);
            double rotSin = Math.Sin(deg * Math.PI / 180);
            double oldX = x;
            double oldY = y;
            x = oldX * rotCos - oldY * rotSin;
            y = oldX * rotSin + oldY * rotCos;
        }

        // returns a string of the form "(x, y)" to display the point, x and y are
        // given to one decimal place
        public override String ToString()
        {
            string output = "(" + getX().ToString() + "," + getY().ToString() + ")";
            return output;
        }
         
        // returns true if the distance of the point to (0,0) is closer than from
        // other to (0,0), false otherwise.
        public static bool operator <(Point p1, Point p2)
        {
            double p1x = p1.getX();
            double p2x = p2.getX();
            if (p1x < p2x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // returns true if the distance of the point to (0,0) is further than from
        // other to (0,0), false otherwise.
        public static bool operator >(Point p1, Point p2)
        {
            double p1x = p1.getX();
            double p2x = p2.getX();
            if (p1x > p2x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
