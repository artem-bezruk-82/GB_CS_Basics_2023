using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_06_task43
{
    internal class StraightLine
    {
        public double Slope { get; set; }
        public double YaxisIntersection { get; set; }

        public StraightLine(double slope, double yAxisIntersection)
        {
            Slope = slope;
            YaxisIntersection = yAxisIntersection;
        }

        public StraightLine() : this(0.0, 0.0) { }


        public static Point? GetIntersectionPoint(StraightLine lineA, StraightLine lineB)
        {
            if (lineA.Slope == lineB.Slope) 
                return null;

            Point intersectionPoint = new Point();
            intersectionPoint.X = (lineB.YaxisIntersection - lineA.YaxisIntersection)/(lineA.Slope - lineB.Slope);
            intersectionPoint.Y = lineA.Slope * intersectionPoint.X + lineB.YaxisIntersection;
            return intersectionPoint;
        }


        public override string ToString() =>
            this switch
            {
                { Slope: 0, YaxisIntersection: 0 } => $"Y = 0",
                { Slope: 0 } => $"Y = {YaxisIntersection}",
                { YaxisIntersection: 0 } => $"Y = {Slope}X",
                { YaxisIntersection: > 0 } => $"Y = {Slope}X+{YaxisIntersection}",
                { YaxisIntersection: < 0 } => $"Y = {Slope}X{YaxisIntersection}",
                _ => string.Empty,
            };
    };
    
}
