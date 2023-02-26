//Семинар #8
//Задание #57
//Составить частотный словарь элементов двумерного массива.
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных

namespace cw_08_task57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,] array2D = new int[random.Next(3,5), random.Next(3, 5)];
            FillInArray2DRandom(array2D, 1, 9);
            PrintArray2DConsole(array2D);

            int[] uniqElementsArray = new int[array2D.GetLength(0) * array2D.GetLength(1)];
            int uniqElementsIndex = 0;

            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(0); j++)
                {
                    if (Array.IndexOf(uniqElementsArray, array2D[i, j]) == -1)
                    {
                        uniqElementsArray[uniqElementsIndex] = array2D[i, j];
                        uniqElementsIndex++;
                    }

                }
            }

            for (int k = 0; k < uniqElementsIndex; k++)
            {
                int uniqElementsCounter = 0;

                for (int i = 0; i < array2D.GetLength(0); i++)
                {
                    for (int j = 0; j < array2D.GetLength(1); j++)
                    {
                        if (uniqElementsArray[k] == array2D[i,j]) 
                        { 
                            uniqElementsCounter++;
                        }
                    }
                }
                Console.WriteLine($"{uniqElementsArray[k]} met {uniqElementsCounter} times");
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
                    array[i, j] = random.Next(startRange, endRange);
                }
            }
        }
    }
}