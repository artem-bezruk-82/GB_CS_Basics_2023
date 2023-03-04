//Семинар #9
//Задача #67
//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

namespace cw_09_task67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = GetConsoleInput($"Please enter value {nameof(value)}");
            Console.WriteLine(GetSumOfDigitsRec(value));
        }

        static int GetSumOfDigitsRec(int value) 
        {
            if (value < 10 || value / 10 == 0 || value % 10 == value) 
            {
                return value;
            }
            return GetSumOfDigitsRec(value/10) + value % 10;
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

                    Console.WriteLine($"{exc.Message} Please enter {typeof(int)} type value");
                }
            }
            return (int)value;
        }
    }
}