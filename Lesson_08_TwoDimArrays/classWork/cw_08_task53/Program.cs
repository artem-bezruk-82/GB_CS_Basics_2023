//Семинар #8
//Задача #53
//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

namespace cw_08_task53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] array2D = new int[random.Next(3, 9), random.Next(3, 9)];
            FillInArray2DRandom(array2D, -20, 20);
            Console.WriteLine("Initial array:");
            PrintArray2DConsole(array2D);

            Console.WriteLine("Final array:");

            for (int j = 0; j < array2D.GetUpperBound(1) + 1; j++)
            {
                (array2D[0,j], array2D[array2D.GetUpperBound(0),j]) =
                    (array2D[array2D.GetUpperBound(0), j], array2D[0, j]);
            }

            PrintArray2DConsole(array2D);
        }

        static void PrintArray2DConsole(int[,] array)
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

        static void FillInArray2DRandom(int[,] array, int startRange, int endRange)
        {
            Random random = new Random();

            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    array[i, j] = random.Next(startRange, endRange + 1);
                }
            }
        }
    }
}