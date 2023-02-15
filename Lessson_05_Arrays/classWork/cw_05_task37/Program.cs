//Семинар #5
//Задача #37
//Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.

namespace cw_05_task37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = new int[new Random().Next(2, 16)];

            for (int i = 0; i < initialArray.Length; i++)
            {
                initialArray[i] = new Random().Next(1,11);
            }

            int[] resultArray = new int[initialArray.Length/2];

            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = initialArray[i] * initialArray[initialArray.Length - 1 - i];
            }

            Console.WriteLine($"[{string.Join(',', initialArray)}] ({initialArray.Length})");
            Console.WriteLine($"[{string.Join(',',resultArray)}] ({resultArray.Length})");
        }
    }
}