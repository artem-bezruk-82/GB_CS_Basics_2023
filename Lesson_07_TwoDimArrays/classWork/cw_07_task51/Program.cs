//Семитнар #7
//Задача #51
//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cw_07_task51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = new Random().Next(3,10);
            int[,] array2D = new int[size, size];
            FillInArray2DRandom(array2D, 1, 25);
            PrintArray2DConsole(array2D);
            int sumMainDiag = 0;

            for (int i = 0; i < array2D.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array2D.GetUpperBound(1) + 1; j++)
                {
                    if (i == j)
                    {
                        sumMainDiag += array2D[i, j];
                    }
                }
            }

            Console.WriteLine($"{nameof(sumMainDiag)} = {sumMainDiag}");
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