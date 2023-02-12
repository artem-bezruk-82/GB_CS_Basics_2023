//Семинар #5
//Задача #33
//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

namespace hw_05_task34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[10];

            int numOfEvens = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100, 1000);
                if (arr[i] % 2 == 0)
                {
                    numOfEvens++;
                }
            }

            Console.WriteLine($"{string.Join(',',arr)}");
            Console.WriteLine($"Array contains {numOfEvens} even values");
        }
    }
}