//Семинар #8
//Задача #59
//Задайте двумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

namespace cw_08_task59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] array2D = new int[random.Next(3,6), random.Next(3, 6)];
            FillInArray2DRandom(array2D, -15, 15);
            Console.WriteLine("Initial array:");
            PrintArray2DConsole(array2D);

            int rowMinElement;
            int colMinElement;


            FindMinElementIndexArray2D(array2D, out rowMinElement, out colMinElement);
            Console.WriteLine($"Min Elemrnt: ({rowMinElement},{colMinElement})");

            ResizeArray2D(ref array2D, rowMinElement, colMinElement);

            Console.WriteLine("Final array:");
            PrintArray2DConsole(array2D);
        }


        static void ResizeArray2D(ref int[,] array, int rowIndex, int colIndex) 
        {
            int[,] temp = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

            int tempRow = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i != rowIndex) 
                {
                    int tempCol = 0;

                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (j != colIndex) 
                        {
                            temp[tempRow,tempCol] = array[i,j];
                            tempCol++;
                        }
                    }

                    tempRow++;
                }
            }
            array = temp;
        }


        static void FindMinElementIndexArray2D(int[,] array, out int row, out int col) 
        {
            row = 0; 
            col = 0;
            int minElement = array[row, col];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] < minElement)
                    {
                        minElement = array[i,j];
                        row = i;
                        col = j;
                    }
                }
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
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    array[i, j] = random.Next(startRange, endRange + 1);
                }
            }
        }
    }
}