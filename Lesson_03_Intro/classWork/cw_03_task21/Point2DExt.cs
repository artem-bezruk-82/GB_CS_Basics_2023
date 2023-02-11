using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_03_task21
{
    public static class Point2DExt
    {
        public static void SetPointConsole(this Point2D point) 
        {
            point.X = GetConsoleInput($"Please enter {nameof(point.X)}");
            point.Y = GetConsoleInput($"Please enter {nameof(point.Y)}");
        }

        static double GetConsoleInput(string requestText)
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
