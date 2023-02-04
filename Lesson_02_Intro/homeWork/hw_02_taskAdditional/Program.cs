//Семинар #2
//Дополнительная задача
//https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=3&id_topic=35&id_problem=223
//Задана последовательность натуральных чисел, завершающаяся числом 0.
//Требуется определить значение второго по величине элемента в этой последовательности,
//то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.
//последовательность неотрицательных целых чисел, не превышающих значения 100.
//Гарантируется, что во входных данных не более 100 чисел и среди них есть хотя бы одно число 0, перед которым идет как минимум 2 элемента.


using System.Security.Cryptography;

namespace hw_02_taskAdditional
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random randValue = new Random();
            int size = randValue.Next(100);
            string inputStr = string.Empty;

            for (int i = 0; i < size; i++)
            {
                inputStr += $"{randValue.Next(100)} ";
            }
            inputStr += 0;

            Console.WriteLine(inputStr);

            string[] numbersStr = inputStr.Split(' ');

            int? maxFirst = null;
            int? maxSecond = null;
            int current;

            for (int i = 0; i < numbersStr.Length; i++)
            {
                int.TryParse(numbersStr[i], out current);
                if (maxFirst is null)
                {
                    maxFirst = current;
                    continue;
                }
                if (maxSecond is null)
                {
                    maxSecond = current;
                }
                if (maxSecond < current)
                {
                    maxSecond = current;
                }
                if (maxSecond > maxFirst)
                {
                    (maxSecond, maxFirst) = (maxFirst, maxSecond);
                }
            }

            Console.WriteLine($"{nameof(maxSecond)} = {maxSecond}");
        }
    }
}