//Семинар #7
//задача #49
//Задайте двумерный массив.
//Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cw_07_task49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            int cols = 5;
            int[,] array2D = new int[rows,cols];

            FillInArray2DRandom(array2D, 1, 9);

            Console.WriteLine("Initial array:");
            PrintArray2DConsole(array2D);

            for (int i = 0; i < array2D.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array2D.GetUpperBound(1) + 1; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
                    {
                        array2D[i, j] *= array2D[i, j];
                    }
                }
            }

            Console.WriteLine("Final array:");
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

        static void FillInArray2DRandom(int[,] array, int rangeStart, int rangeEnd)
        {
            Random random = new Random();

            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    array[i, j] = random.Next(rangeStart,rangeEnd);
                }
            }
        }
    }
}