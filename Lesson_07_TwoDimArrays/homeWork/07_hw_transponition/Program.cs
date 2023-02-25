//Скминар #7
//Дополнителдьное задание
//Транспонирование
//https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=8&id_topic=120&id_problem=745

//Задана целочисленная матрица, состоящая из N строк и M столбцов.
//ребуется транспонировать ее относительно горизонтали.

//Входные данные
//Первая строка содержит два натуральных числа N и M – количество строк и столбцов матрицы.
//В каждой из последующих N строк записаны M целых чисел – элементы матрицы.
//Все числа во входных данных не превышают 100 по абсолютной величине.

//Выходные данные
//Выведите матрицу, полученную транспонированием исходной матрицы относительно горизонтали.

namespace _07_hw_transponition
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int rows = random.Next(3,7);
            int cols = random.Next(3,7);
            int[,] matrix = new int[rows, cols];
            FillInArray2DRandom(matrix, 1, 100);

            Console.WriteLine("Initial matrix:");
            PrintArray2DConsole(matrix);

            for (int i = 0; i < rows / 2; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    (matrix[i, j], matrix[matrix.GetUpperBound(0) - i, j]) =
                        (matrix[matrix.GetUpperBound(0) - i, j], matrix[i, j]);
                }
            }

            Console.WriteLine("Filal matrix:");
            PrintArray2DConsole(matrix);
        }

        static void FillInArray2DRandom(int[,] array, int startRange, int endRange) 
        {
            Random random = new Random();
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    array[i, j] = random.Next(startRange,endRange);
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
    }
}