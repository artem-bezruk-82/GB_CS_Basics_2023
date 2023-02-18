using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_06_task40
{
    public static class TriangleExt
    {
        public static Triangle CreateTriangleConsole() 
        {
            int a = GetConsoleInput("\nPlease enter side A length");
            int b = GetConsoleInput("Please enter side B length");
            int c = GetConsoleInput("Please enter side C length");

            return new Triangle(sideA:a, sideB:b, sideC:c);
        }

        private static int GetConsoleInput(string requestText)
        {
            int? value = null;

            while (value is null)
            {
                Console.WriteLine(requestText);
                try
                {
                    value = int.Parse(Console.ReadLine() ?? "");
                }
                catch (Exception exc)
                {

                    Console.WriteLine($"{exc.Message} Please enter {typeof(int).Name} value");
                }
            }
            return (int)value;
        }
    }
}
