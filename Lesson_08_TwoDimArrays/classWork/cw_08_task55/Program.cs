//Семинар #8
//Задача #55
//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

namespace cw_08_task55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] array2D = new int[random.Next(3, 9), random.Next(3, 9)];
            FillInArray2DRandom(array2D, 1, 25);
            Console.WriteLine($"Initial array:");
            PrintArray2DConsole(array2D);
            TransposeArray2D(ref array2D);
            Console.WriteLine($"Final array:");
            PrintArray2DConsole(array2D);
        }

        static void TransposeArray2D(ref int[,] array) 
        {
            int[,] temp = new int[array.GetLength(1), array.GetLength(0)];

            for (int i = 0; i < temp.GetLength(0); i++)
            {
                for (int j = 0; j < temp.GetLength(1); j++)
                {
                    temp[i, j] = array[j, i];
                }
            }

            array = temp;
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
                    array[i, j] = random.Next(startRange, endRange);
                }
            }
        }
    }
}