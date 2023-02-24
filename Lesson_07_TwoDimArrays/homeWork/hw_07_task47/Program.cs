//Семинар #7
//Задача #47
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

namespace hw_07_task47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 3;
            int n = 4;
            double[,] array2D = new double[m,n];

            FillInArray2DRandom(array2D);
            PrintArray2DConsole(array2D);

        }

        static void PrintArray2DConsole(double[,] array)
        {
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        static void FillInArray2DRandom(double[,] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    array[i, j] = Math.Round(random.NextDouble() * 100, 1);
                }
            }
        }
    }
}