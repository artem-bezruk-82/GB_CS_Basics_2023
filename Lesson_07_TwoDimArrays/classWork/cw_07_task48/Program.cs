//Семинар #7
//Задача #48
//Задайте двумерный массив размера m на n
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
//Выведите полученный массив на экран.

namespace cw_07_task48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 3;
            int n = 4;
            int[,] array2D = new int[m, n];

            for (int i = 0; i < array2D.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array2D.GetUpperBound(1) + 1; j++)
                {
                    array2D[i, j] = i + j;
                }
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
    }
}