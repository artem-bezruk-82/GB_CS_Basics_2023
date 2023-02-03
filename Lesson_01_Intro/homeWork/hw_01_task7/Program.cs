//Семинар #1
//Задача #7
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

using System.Text;

namespace hw_01_task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, our program returns the least significant digit of 3-digits number");

            while (EndProgram("\nWould you like to start program?"))
            {
                Console.WriteLine("\nPlease enter 3-digits number");
                string threeDigitsТumberStr = Console.ReadLine() ?? string.Empty;
                try
                {
                    int threeDigitsТumber = Convert.ToInt32(threeDigitsТumberStr);
                    if (threeDigitsТumberStr.Length == 3)
                    {
                        Console.WriteLine($"The least significant digit of {threeDigitsТumber} is {threeDigitsТumber % 10}");
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

            Console.WriteLine("Thank you for using our program. Goodbye!");
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