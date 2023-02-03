//Семинар #1
//Задача 4
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

namespace hw_01_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, our program returns maximal value out of 3 values defined by user");

            while (EndProgram("New calculation?"))
            {
                double valueA = GetConsoleInput($"\nPlease enter value {nameof(valueA)}");
                double valueB = GetConsoleInput($"Please enter value {nameof(valueB)}");
                double valueC = GetConsoleInput($"Please enter value {nameof(valueC)}");

                double maxValue = valueA;

                if (valueB > maxValue)
                {
                    maxValue = valueB;
                }

                if (valueC > maxValue) 
                {
                    maxValue = valueC;
                }

                Console.WriteLine($"max({valueA}, {valueB}, {valueC},) = {maxValue}");
            }

            Console.WriteLine("\nThank you for using our program! Goodbye!");
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

                    Console.WriteLine($"{exc.Message} Please enter double type value");
                }
            }
            return (double)value;
        }

        public static bool EndProgram(string requestText)
        {
            Console.WriteLine($"\n{requestText}, Yes(y), No(n)");
            char key = Console.ReadKey().KeyChar;
            while (key != 'n' && key != 'y')
            {
                Console.WriteLine("\nThe only 'y' or 'n' are required");
                key = Console.ReadKey().KeyChar;
            }
            if (key == 'y')
            {
                return true;
            }
            return false;
        }
    }
}