using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_03_task17
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
