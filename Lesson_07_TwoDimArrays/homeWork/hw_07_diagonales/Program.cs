//Семинар #7
//Дополнительная задача
//
//Даны 2 числа m и n.
//Создать масив A[m][n] и заполнить его по диагонали 

using System.Data;

namespace hw_07_diagonales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 4;
            int n = 10;
            int[,] array2D = new int[m, n];
            int element = 0;

            int col = 0;

            for (int i = 0; i < array2D.GetUpperBound(1) + 1; i++)
            {
                col = i;

                for (int row = 0; row < array2D.GetUpperBound(0) + 1; row++)
                {
                    array2D[row, col] = element;
                    element++;
                    col--;
                    if (col < 0)
                    {
                        break;
                    }
                }
            }


            int count = 1;
            while (element < m * n) 
            {
                col = array2D.GetUpperBound(1);
                for (int row = count; row < array2D.GetUpperBound(0) + 1; row++)
                {
                    array2D[row, col] = element;
                    element++;
                    col--;
                    if (col < 0)
                    {
                        break;
                    }
                }
                count++;
            }





            PrintArray2DConsole(array2D);

        }

        static void PrintArray2DConsole(int[,] array) 
        {
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    Console.Write($"{array[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}