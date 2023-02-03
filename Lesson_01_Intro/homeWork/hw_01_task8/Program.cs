//Семинар #1
//Задача #8
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


namespace hw_01_task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, our program prints all the even nymbers starting from 2 to the number defined by user");

            while (EndProgram("Start new calculation?"))
            {
                int value = Math.Abs(GetConsoleInput($"\nPlease enter {nameof(value)}"));

                for (int i = 1; i < value; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($" {i}");
                    }
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