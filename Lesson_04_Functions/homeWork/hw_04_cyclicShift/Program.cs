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
            int[] arr = { 1, 2, 3, 4, 5 };
            int shift = -2;

            //Random random = new Random();
            //int n = random.Next(1, 106);

            //int[] arr = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = random.Next(100);
            //}

            //int k = random.Next(1,106);

            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine($"{nameof(shift)}: {shift}");

            shift %= arr.Length;

            if (shift > 0)
            {
                for (int i = 0; i < shift; i++)
                {
                    (arr[i], arr[arr.Length - shift + i]) = (arr[arr.Length - shift + i], arr[i]);
                    Console.WriteLine(string.Join(" ", arr));

                }
            }

            if (shift < 0)
            {
                shift = -shift;
                for (int i = shift; i < arr.Length; i++)
                {
                    (arr[i], arr[i - shift]) = (arr[i - shift], arr[i]);
                    Console.WriteLine(string.Join(" ", arr));
                }
            }



        }
    }
}