using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_03_task21
{
    public class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z) 
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point3D() : this(0, 0, 0) { }

        public static double GetDistance(Point3D pointA, Point3D pointB) 
        {
            return Math.Sqrt(
                Math.Pow((pointA.X - pointB.X), 2) 
                + Math.Pow((pointA.Y - pointB.Y), 2) 
                + Math.Pow((pointA.Z - pointB.Z), 2)
                );
        }

        public override string ToString()
        {
            return $"[x:{X}; y:{Y} z:{Z}]";
        }
    }
}
