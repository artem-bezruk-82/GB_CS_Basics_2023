using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_06_task43
{
    internal class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X= x; Y= y;
        }

        public Point() : this(0.0, 0.0) { }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

    }
}
