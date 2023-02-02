//Семинар #1
//Задание #1
//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.


namespace hw_01_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi our program checks if valueA == balueB^2 or not");

            while (EndProgram("Start new calculation?"))
            {
                int valueA = GetConsoleInput($"\nPlease enter {nameof(valueA)}");
                int valueB = GetConsoleInput($"Please enter {nameof(valueB)}");

                Console.WriteLine(valueA == Math.Pow(valueB, 2) ? $"{valueA} = {valueB}^2" : $"{valueA} != {valueB}^2");
            }

            Console.WriteLine("Thank you for using our program! Goodbye!");

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