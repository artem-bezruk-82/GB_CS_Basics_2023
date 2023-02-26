//Семинар #8
//Здадание #62
//Напишите программу, которая заполнит спирально массив 4 на 4.

namespace hw_08_task62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 4;
            int[,] array2D = new int[size, size];

            int value = 1;
            int i = 0;
            int j = 0;

            while (value <= size * size)
            {
                array2D[i, j] = value;
                if (i <= j + 1 && i + j < size - 1)
                    j++;
                else if (i < j && i + j >= size - 1)
                    i++;
                else if (i >= j && i + j > size - 1)
                    j--;
                else
                    i--;
                value++;
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