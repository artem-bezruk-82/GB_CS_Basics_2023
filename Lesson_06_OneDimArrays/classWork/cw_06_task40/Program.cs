//Семинар #6
//Задание #40
//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

namespace cw_06_task40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle? triangle = null;
            while (EndProgram("New calculation?")) 
            {
                try
                {
                    triangle = TriangleExt.CreateTriangleConsole();
                    Console.WriteLine(triangle);
                }
                catch (Exception exc)
                {

                    Console.WriteLine(exc.Message);
                }
            }
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