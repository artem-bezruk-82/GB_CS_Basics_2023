//Семинар #2
//Задача #10
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

namespace hw_02_task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, our program returns tge 2nd digit of 3-digits number");

            while (EndProgram("\nWould you like to start program?"))
            {
                Console.WriteLine("\nPlease enter 3-digits number");
                string threeDigitsNumberStr = Console.ReadLine() ?? string.Empty;
                try
                {
                    int threeDigitsNumber = Math.Abs(Convert.ToInt32(threeDigitsNumberStr));
                    threeDigitsNumberStr = $"{threeDigitsNumber}";
                    if (threeDigitsNumberStr.Length == 3)
                    {
                        Console.WriteLine($"2nd digit of {threeDigitsNumber} is {(threeDigitsNumber /= 10) % 10}");
                    }
                    else
                    {
                        Console.WriteLine("Error: The number you are etrering must contain 3 digits");
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }

            Console.WriteLine("\nThank you for using our program! Goodbye!");
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