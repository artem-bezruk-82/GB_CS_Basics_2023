using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_06_task43
{
    internal static class StraightLineExt
    {
        public static void SetLineEquastion(this StraightLine line) 
        {
            Console.WriteLine("To define your line properties, you have to define coefficients for equastion Y = aX + b");
            line.Slope = GetConsoleInput("Please enter slope coefficient (a)");
            line.YaxisIntersection = GetConsoleInput("Please enter Y-axis intersection coefficient (b)");
        }

        private static double GetConsoleInput(string requestText)
        {
            double? value = null;

            while (value is null)
            {
                Console.WriteLine(requestText);
                try
                {
                    value = double.Parse(Console.ReadLine() ?? "");
                }
                catch (Exception exc)
                {

                    Console.WriteLine($"{exc.Message} Please enter double value");
                }
            }
            return (double)value;
        }
    }
}
