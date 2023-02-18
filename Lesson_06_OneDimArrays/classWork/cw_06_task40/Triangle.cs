using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_06_task40
{
    public class Triangle
    {
        public int SideA { get; private set; }
        public int SideB { get; private set; }
        public int SideC { get; private set; }

        public Triangle(int sideA, int sideB, int sideC)
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

        public static bool IsTriangle(int sideA, int sideB, int sideC) 
        {
            if (sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB) 
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"[{SideA}; {SideB}; {SideC}]";
        }
    }
}
