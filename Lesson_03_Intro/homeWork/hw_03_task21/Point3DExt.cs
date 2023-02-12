using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_03_task21
{
    public static class Point3DExt
    {
        public static void SetPointConsole(this Point3D point) 
        {
            point.X = GetConsoleInput($"Please enter {nameof(point.X)}");
            point.Y = GetConsoleInput($"Please enter {nameof(point.Y)}");
            point.Z = GetConsoleInput($"Please enter {nameof(point.Z)}");
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
