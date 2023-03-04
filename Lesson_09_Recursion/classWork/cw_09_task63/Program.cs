//Семинар #9
//Задача #63
//Задайте значение N.
//Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.


namespace cw_09_task63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = GetConsoleInput($"Please enter {nameof(value)} [{typeof(int)}]");
            Console.WriteLine(GetRangeRec(value));
        }

        static string GetRangeRec(int value) 
        {
            if (value == 1) 
            {
                return $"1";
            }
            if (value <= 0) 
            {
                return GetRangeRec(value + 1) + $" {value}";
            }
            return GetRangeRec(value - 1) + $" {value}";
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