//Семинар #8
//Задача #61
//Вывести первые N строк треугольника Паскаля.
//Сделать вывод в виде равнобедренного треугольника

namespace hw_08_task61
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rows = 5;
            PrintTriangleConsole(rows);
        }

        static int GetFactorial(int value)
        {
            int factorial = 1;
            for (int i = 1; i <= value; i++)
            {
                factorial *= i;
            }
            return factorial;
        }


        static void PrintTriangleConsole(int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= (rows - i); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                    Console.Write(GetFactorial(i) / (GetFactorial(j) * GetFactorial(i - j)));
                }
                Console.WriteLine();
            }
        }
    }
}