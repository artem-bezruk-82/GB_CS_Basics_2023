//Семинар #2
//Задача #12
//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.

namespace cw_02_task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, our rogram checks multiplicity");

            while (EndProgram("Start new calculation?")) 
            {
                int divider = GetConsoleInput($"\nPlease enter {nameof(divider)}");
                int dividend = GetConsoleInput($"\nPlease enter {nameof(dividend)}");

                if (dividend % divider == 0)
                {
                    Console.WriteLine($"{dividend} is multiple of {divider}");
                }
                else
                {
                    Console.WriteLine($"reminder: {dividend % divider}");
                }
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