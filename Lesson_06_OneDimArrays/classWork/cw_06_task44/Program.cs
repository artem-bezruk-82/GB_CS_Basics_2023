//Семинар #6
//Задача #44
//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

namespace cw_06_task44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int first = 0;
            int second = 1;
            int result = 0;

            Console.Write($"{first} {second} ");

            while (second < n)
            {
                result = first + second;
                Console.Write($"{result} ");

                first = second;
                second = result;
            };


        }
    }
}