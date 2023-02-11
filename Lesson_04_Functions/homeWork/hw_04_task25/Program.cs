//Семинар #4
//Задача #25
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Нельзя использовать Math.Pow();

namespace hw_04_task25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = GetConsoleInput($"Please enter {nameof(value)} ({typeof(int).Name})");
            int power = GetConsoleInput($"Please enter {nameof(power)} ({typeof(int).Name})");

            double result = value;

            for (int i = 1; i < Math.Abs(power); i++)
            {
                result *= value;
            }

            if (power < 0)
            {
                result = 1 / result;
            }

            Console.WriteLine($"{value}^{power} = {result}");
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