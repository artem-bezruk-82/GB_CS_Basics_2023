//Семинар #2
//Задача #13
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

namespace hw_02_task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, our program returns 3rd digit of user defined value");

            while (EndProgram("Start new calculation?"))
            {
                int value = GetConsoleInput($"\nPlease enter {nameof(value)}");
                string valueStr = $"{Math.Abs(value)}";

                Console.WriteLine((valueStr.Length >= 3) ? 
                    $"The 3rd digit of {value} is {valueStr[2]}" : $"{nameof(value)} contains only {valueStr.Length} digits");
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