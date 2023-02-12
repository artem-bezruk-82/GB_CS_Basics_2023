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
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
                array[i] = new Random().Next(1, 11); // [1, 10]
            Console.WriteLine($"[{string.Join(", ", array)}]");
            int k = Convert.ToInt32(Console.ReadLine());
            k = k % n;
            if (k > 0)
            {
                for (int i = 0; i < k; i++)
                    result[i] = array[n - k + i];
                for (int i = 0; i < n - k; i++)
                    result[k + i] = array[i];
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
            else
            {
                k = (-1) * k;
                for (int i = 0; i < k; i++)
                    result[n - k + i] = array[i];
                for (int i = 0; i < n - k; i++)
                    result[i] = array[k + i];
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }


        }
    }
}