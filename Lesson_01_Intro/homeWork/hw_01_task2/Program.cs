//Семинар #1
//Задание #2
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


namespace hw_01_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi our program compares 2 values");

            while (EndProgram("Start new calculation?"))
            {
                double valueA = GetConsoleInput($"\nPlease enter value {nameof(valueA)}");
                double valueB = GetConsoleInput($"Please enter value {nameof(valueB)}");

                char sign = valueA == valueB ? '=' : (valueA > valueB ? '>' : '<');

                Console.WriteLine($"{valueA} {sign} {valueB}");
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