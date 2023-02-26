//Семинар #8
//Задача #60
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

namespace hw_08_task60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 3;
            int[,,] array3D = new int[size, size, size];
            int value = 10;

            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        array3D[i, j, k] = value;
                        value++;
                    }
                }
            }

            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        Console.Write($"{array3D[i, j, k]} ({i},{j},{k})\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}