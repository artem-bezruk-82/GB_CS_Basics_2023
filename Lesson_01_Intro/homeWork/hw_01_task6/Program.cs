//Семинар #1
//Задача #6
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.

namespace hw_01_task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, our program checks whether the user defined value is even or odd!");

            while (EndProgram("Start new calculation?"))
            {
                int value = GetConsoleInput($"\nPlease enter value {nameof(value)}");

                Console.WriteLine($"{value} is " + (value % 2 == 0 ? "even" : "odd"));
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


        static bool EndProgram(string requestText)
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