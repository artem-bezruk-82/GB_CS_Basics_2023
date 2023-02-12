//Семинар #4
//https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=114&id_problem=702
//Дана последовательность из N целых чисел и число K.
//Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.
//Входные данные
//Первая строка содержит натуральное число N, во второй строке записаны N целых чисел Ai, а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).
//Выходные данные
//Выведите полученную последовательность.


namespace hw_04_cyclicShift
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int n = random.Next(1, 105);

            //int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(100);
            }

            int k = random.Next(105);

            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine($"Shift: {k}");


            if (k < 0)
            {
                k = Math.Abs(k);
                k %= arr.Length;

            }
            else 
            {
                k %= arr.Length;
                k = arr.Length - k;
            }

            for (int i = k; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            for (int i = 0; i < k; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}