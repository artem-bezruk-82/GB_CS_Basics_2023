//Семинар #4
//Задача #30
//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.


namespace cw_04_task30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0,2);
            }
            Console.WriteLine($"[{string.Join(',', arr)}]");
        }
    }
}