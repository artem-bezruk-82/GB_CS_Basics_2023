//Семинар #4
//Задача #28
//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.


namespace cw_04_task28
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int value = GetConsoleInput($"Please enter {nameof(value)} ({typeof(int).Name})");
            int product = 1;

            for (int i = 1; i <= value; i++)
            {
                product *= i;
            }

            Console.WriteLine(product);
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