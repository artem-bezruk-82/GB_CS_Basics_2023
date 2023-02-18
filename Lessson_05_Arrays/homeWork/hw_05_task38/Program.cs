//Семинар #5
//Задача #38
//Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.


namespace hw_05_task38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[new Random().Next(3,15)];

            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Math.Round(random.NextDouble() * 100, 2);
            }
            Console.WriteLine($"{string.Join(' ', arr)}");

            Array.Sort(arr);

            Console.WriteLine($"{arr[arr.Length - 1]} - {arr[0]} = {arr[arr.Length - 1] - arr[0]}");
        }
    }
}