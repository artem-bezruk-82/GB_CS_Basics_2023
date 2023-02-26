//Семинар #8
//Задача #58
//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

namespace hw_08_task58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] array2D_A = new int[random.Next(2, 5), random.Next(2, 5)];
            int[,] array2D_B = new int[array2D_A.GetLength(1), random.Next(2, 5)];
            FillInArray2DRandom(array2D_A, 1, 10);
            FillInArray2DRandom(array2D_B, 1, 10);
            Console.WriteLine($"{nameof(array2D_A)}:");
            PrintArray2DConsole(array2D_A);
            Console.WriteLine($"{nameof(array2D_B)}:");
            PrintArray2DConsole(array2D_B);

            try
            {
                int[,] array2D_C = GetProductArray2D(array2D_A, array2D_B);
                Console.WriteLine($"{nameof(array2D_C)}:");
                PrintArray2DConsole(array2D_C);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

        }

        static int[,] GetProductArray2D(int[,] arrayA, int[,] arrayB) 
        {
            if (arrayA.GetLength(1) != arrayB.GetLength(0))
            {
                throw new ArgumentException();
            }

            int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

            for (int i = 0; i < arrayC.GetLength(0); i++)
            {
                for (int j = 0; j < arrayC.GetLength(1); j++)
                {
                    arrayC[i, j] = 0;
                    for (int k = 0; k < arrayA.GetLength(1); k++)
                    {
                        arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
                    }
                }
            }

            return arrayC;
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