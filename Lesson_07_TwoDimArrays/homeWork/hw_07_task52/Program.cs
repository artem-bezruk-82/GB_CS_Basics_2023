//Семинар #7
//Зададча #52
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


using System;
using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace hw_07_task52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int rows = random.Next(3,10);
            int cols = random.Next(3, 10);
            double[] avgByColumns = new double[cols];
            int[,] array2D = new int[rows, cols];
            FillInArray2DRandom(array2D, 1, 9);
            PrintArray2DConsole(array2D);

            for (int j = 0; j < array2D.GetUpperBound(1) + 1; j++)
            {
                int sum = 0;
                for (int i = 0; i < array2D.GetUpperBound(0) + 1; i++)
                {
                    sum += array2D[i,j];
                }
                avgByColumns[j] = Math.Round((sum / (double)rows),2);
            }

            Console.WriteLine($"Averages:\n{string.Join('\t', avgByColumns)}");
            
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
                    array[i, j] = random.Next(startRange,endRange);
                }
            }
        }
    }
}