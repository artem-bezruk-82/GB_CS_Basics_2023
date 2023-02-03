//Семинар #1
//Задача #5
//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

namespace hw_01_task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, our program prints integer numbers within user defined range");

            while (EndProgram("Start new calculation?"))
            {
                int startRange = GetConsoleInput($"\nPlease enter value {nameof(startRange)}");
                int endRange = GetConsoleInput($"Please enter value {nameof(endRange)}");

                if (startRange > endRange)
                {
                    (startRange, endRange) = (endRange, startRange);
                }

                for (int i = startRange; i <= endRange; i++)
                {
                    Console.Write($" {i}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nThank you for using our program! Goodbye!");
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

                    Console.WriteLine($"{exc.Message} Please enter integer value");
                }
            }
            return (int)value;
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