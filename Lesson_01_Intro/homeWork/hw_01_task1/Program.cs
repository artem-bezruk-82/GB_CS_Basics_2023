//Задача 1
//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).


namespace hw_01_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte power = 2;
            Console.WriteLine($"Hi our program receives number teturs its power of {power}");

            while (EndProgram("Start new calculation?")) 
            {
                Console.WriteLine("\nPlease enter value");
                try
                {
                    double value = double.Parse(Console.ReadLine() ?? string.Empty);
                    Console.WriteLine($"{value}^{power} = {Math.Pow(value, power)}");
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }


            }

            Console.WriteLine("\nThank you for using our program! Goodbuy!");
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