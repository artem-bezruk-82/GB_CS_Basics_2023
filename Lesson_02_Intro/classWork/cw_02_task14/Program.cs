//Семинар #2
//Задача #14
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

namespace cw_02_task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int divider1 = 7;
            int divider2 = 23;

            int value = GetConsoleInput($"Please enter {nameof(value)} ({typeof(int).Name})");

            if (value % (divider1 * divider2) == 0)
            {
                Console.WriteLine($"Both {divider1} & {divider2} are deviders of {value}");
            }
            else if (value % divider1 == 0) 
            {
                Console.WriteLine($"{divider1} is devider of {value}");
            }
            else if (value % divider2 == 0)
            {
                Console.WriteLine($"{divider2} is devider of {value}");
            } else 
            {
                Console.WriteLine($"Neither {divider1} & {divider2} are deviders of {value}");
            }

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