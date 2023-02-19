using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_o6_triangle
{
    internal class Triangle
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (IsTriangle(sideA, sideB, sideC))
            {
                SideA = sideA; SideB = sideB; SideC = sideC;
            }
            else
            {
                throw new ArgumentException(message: "Triangle does not fit triangle inequality theorem rule");
            }
        }

        public static bool IsTriangle(double sideA, double sideB, double sideC)
        {
            if (sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB)
            {
                return true;
            }
            return false;
        }

        public double GetPerimeter() 
        {
            return SideA + SideB + SideC;
        }

        public double GetSquare() 
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p*(p - SideA)* (p - SideB)* (p - SideC));
        }

        public override string ToString()
        {
            return $"[{SideA}; {SideB}; {SideC}]";
        }
    }
}
