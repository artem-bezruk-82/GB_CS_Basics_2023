//Семинар #6
//Задача #45
//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

namespace cw_06_task45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arrA = new int[random.Next(15)];

            for (int i = 0; i < arrA.Length; i++)
            {
                arrA[i] = random.Next(100);
            }

            int[] arrB = CopyArr(arrA);

            Console.WriteLine("Initial array:");
            Console.WriteLine($"[{string.Join(' ', arrA)}]");

            Console.WriteLine("Copy array:");
            Console.WriteLine($"[{string.Join(' ', arrB)}]");
        }


        static int[] CopyArr(int[] array) 
        {
            int[] copy = new int[array.Length];

            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = array[i];
            }

            return copy;
        }
    }
}