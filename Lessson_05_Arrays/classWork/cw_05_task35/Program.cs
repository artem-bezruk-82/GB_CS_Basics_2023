//Семинар #5
//Здадача #35
//Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 


namespace cw_05_task35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[123];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100, 100);
            }

            int startRange = 10;
            int endRange = 99;
            int counter = 0;

            foreach (int item in arr)
            {
                if (item >= startRange && item <= endRange)
                {
                    counter++;
                }
            }

            Console.WriteLine($"There are {counter} values witbin {startRange}...{endRange} range");
        }
    }
}