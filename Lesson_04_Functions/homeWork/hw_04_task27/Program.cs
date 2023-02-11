//Семинар #4
//Задача #27
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


namespace hw_04_task27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = GetConsoleInput($"Please enter {nameof(value)} ({typeof(int).Name})");
            int sum = 0;

            while (value != 0)
            {
                sum += value % 10;
                value /= 10;
            }

            Console.WriteLine(Math.Abs(sum));
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