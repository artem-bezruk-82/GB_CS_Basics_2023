//Семинар #7
//Задача #46
//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

using System;

namespace cw_07_task46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 3;
            int n = 4;

            int[,] array2D = new int[m, n];

            FillInArray2DRandom(array2D, 1, 20);

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