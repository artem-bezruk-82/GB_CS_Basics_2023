//Семинар# 4
//Задание# 33
//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

using System.Xml.Linq;

namespace cw_05_task33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 7, 19, 345, 3 };
            int value = 3;

            if (GetIndexBinarySearch(arr, value) != -1)
            {
                Console.WriteLine($"Array contais value {value}");
            }
            else
            {
                Console.WriteLine($"Array does not contain {value}");
            }
        }

        static int GetIndexBinarySearch(int[] array, int element) 
        {
            Array.Sort(array);
            int low = 0;
            int high = array.Length - 1;


            while (low <= high) 
            {
                int mid = (low + high) / 2;
                int guess = array[mid];
                if (guess == element)
                {
                    return mid;
                }
                if (guess > element) 
                {
                    high = mid - 1;
                } else 
                {
                    low = mid + 1;
                }
            }

            return -1;
        }
    }
}