//Семинар #7
//Задача #50
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.


using System;

namespace hw_07_task50
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] array2D = new int[5, 5];
            FillInArray2DRandom(array2D, 1, 100);
            PrintArray2DConsole(array2D);

            int? valueA = null;
            int? valueB = null;

            try
            {
                valueA = GetArray2DElementValue(array2D, 2, 4);
                valueB = GetArray2DElementValue(array2D, 1, 7);
            }
            catch (Exception exc)
            {

                Console.WriteLine(exc.Message);
            }

            Console.WriteLine($"{nameof(valueA)} = {(valueA is null ? "There are no such element" : valueA)}");
            Console.WriteLine($"{nameof(valueB)} = {(valueB is null ? "There are no such element" : valueB)}");
        }

        static int GetArray2DElementValue(int[,] array, int row, int column) 
        {
            if (row <= array.GetUpperBound(0) && row >= 0)
            {
                if (column <= array.GetUpperBound(1) && column >= 0)
                {
                    return array[row, column];
                } 
                else 
                {
                    throw new ArgumentOutOfRangeException(nameof(row), 
                        message:$"{nameof(row)} is out of {0}...{array.GetUpperBound(0)} range");
                }
            }
            else 
            {
                throw new ArgumentOutOfRangeException(nameof(row),
                    message: $"{nameof(column)} is out of {0}...{array.GetUpperBound(1)} range");
            }
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
                for (int j = 0; j < array.GetUpperBound(1) +1; j++)
                {
                    array[i, j] = random.Next(startRange,endRange + 1);
                }
            }
        }
    }
}