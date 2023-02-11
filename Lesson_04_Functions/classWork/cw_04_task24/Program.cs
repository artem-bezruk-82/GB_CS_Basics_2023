//Семинар #4
//Задача #24
//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

namespace cw_04_task24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int value = GetConsoleInput($"Please enter {nameof(value)} ({typeof(int).Name})");
            int sum = 0;
            for (int i = 0; i <= value; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
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