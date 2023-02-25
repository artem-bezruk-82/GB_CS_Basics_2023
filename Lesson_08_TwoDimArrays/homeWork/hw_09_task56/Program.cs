//Семинар #8
//Задача #56
//Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

namespace hw_09_task56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int size = random.Next(3,9);
            int[,] array2D = new int[size,size];
            FillInArray2DRandom(array2D, 1, 10);

            int[] rowSum = new int[size];
            int? minSum = null;
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    rowSum[i] += array2D[i, j];
                    Console.Write($"{array2D[i, j]}\t");
                }
                Console.Write($"sum row{i} = {rowSum[i]}");
                Console.WriteLine();
                if (i == 0) 
                {
                    minSum = rowSum[i];
                }
                if (minSum > rowSum[i])
                {
                    minSum = rowSum[i];
                }
            }

            Console.WriteLine($"row {Array.IndexOf(rowSum, minSum)} has minimal sum");
        }


        static void FillInArray2DRandom(int[,] array, int startRange, int endRange)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    array[i, j] = random.Next(startRange, endRange);
                }
            }
        }
    }
}