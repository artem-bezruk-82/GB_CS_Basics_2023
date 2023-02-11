using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_03_task21
{
    public class Point2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point2D(double x, double y) 
        {
            X = x;
            Y = y;
        }

        public Point2D() : this(0, 0) { }

        public static double GetDistance(Point2D pointA, Point2D pointB) 
        {
            return Math.Sqrt(Math.Pow((pointB.X - pointA.X),2) + Math.Pow((pointB.Y - pointA.Y), 2));
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
