//Семинар #2
//Задача #16
//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

namespace cw_02_task16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valueA = GetConsoleInput($"Please enter {nameof(valueA)}");
            int valueB = GetConsoleInput($"Please enter {nameof(valueB)}");

            if (valueA > valueB)
            {
                (valueA,valueB)=(valueB,valueA);
            }

            string sign = (Math.Pow(valueA, 2) == valueB) ? "=" : "!=";
            Console.WriteLine($"{valueA}^2 {sign} {valueB}");

        }

        static int GetConsoleInput(string requestText)
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