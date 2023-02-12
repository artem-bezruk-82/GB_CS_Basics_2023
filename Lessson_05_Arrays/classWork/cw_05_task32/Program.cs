//Семинар #5
//Задача #32
//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

namespace cw_05_task32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[random.Next(1,15)];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100, 101);
            }

            Console.WriteLine($"[{string.Join(',', arr)}]");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= -1; 
            }

            Console.WriteLine($"[{string.Join(',', arr)}]");
        }
    }
}