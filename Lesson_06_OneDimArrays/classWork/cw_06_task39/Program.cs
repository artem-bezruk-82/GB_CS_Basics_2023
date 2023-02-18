//Семинар #6
//Задача #39
//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

namespace cw_06_task39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] arr = new int[random.Next(2,15)];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100);
            }

            Console.WriteLine(string.Join(' ',arr));

            Reverse1DArray(arr);

            Console.WriteLine(string.Join(' ', arr));
        }

        static void Reverse1DArray(int[] array) 
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                (array[i], array[array.Length - i - 1]) =(array[array.Length - i - 1], array[i]);
            }
        }
    }
}