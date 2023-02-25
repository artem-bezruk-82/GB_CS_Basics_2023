//Семинар #8
//Здача #54
//Задайте двумерный массив.
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

namespace hw_08_task54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] array2D = new int[random.Next(3, 5), random.Next(10, 15)];
            FillInArray2DRandom(array2D, -15, 15);
            Console.WriteLine("Initial array:");
            PrintArray2DConsole(array2D);

            for (int i = 0; i < array2D.GetLength(0); i++) 
            {
                for (int k = 0; k < array2D.GetLength(1); k++)
                {
                    for (int j = 0; j < array2D.GetUpperBound(1); j++)
                    {
                        if (array2D[i, j] < array2D[i, j + 1])
                        {
                            (array2D[i, j], array2D[i, j + 1]) = (array2D[i, j + 1], array2D[i, j]);
                        }
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