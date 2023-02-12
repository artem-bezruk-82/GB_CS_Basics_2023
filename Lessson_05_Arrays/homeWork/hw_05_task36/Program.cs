//Семинар #5
//Задача #36
//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

namespace hw_05_task36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[random.Next(5,26)];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1,100);
            }

            int sumOfOddValues = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sumOfOddValues += arr[i];
                }
            }

            Console.WriteLine($"{nameof(sumOfOddValues)} = {sumOfOddValues}");
        }
    }
}