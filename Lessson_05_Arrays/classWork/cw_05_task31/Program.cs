//Семинар #5
//Задача #31
//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.

namespace cw_05_task31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[12];
            Random random = new Random();

            int sumPositive = 0;
            int sumNegative = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-9,10);

                if (arr[i] > 0)
                {
                    sumPositive += arr[i];
                }
                if (arr[i] < 0) 
                {
                    sumNegative += arr[i];
                }
            }

            Console.WriteLine($"[{string.Join(',', arr)}]");
            Console.WriteLine($"{nameof(sumPositive)} = {sumPositive};\n{nameof(sumNegative)} = {sumNegative}");

        }
    }
}