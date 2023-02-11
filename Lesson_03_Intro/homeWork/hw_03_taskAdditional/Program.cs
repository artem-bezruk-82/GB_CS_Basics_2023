//Семинар #3
//Дополнительная задача
//https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=113&id_problem=695

//В фермерском хозяйстве в Карелии выращивают чернику.
//Она растет на круглой грядке, причем кусты высажены только по окружности.
//Таким образом, у каждого куста есть ровно два соседних. Всего на грядке растет N кустов.
//Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них выросло различное число ягод – на i-ом кусте выросло ai ягод.
//В этом фермерском хозяйстве внедрена система автоматического сбора черники.
//Эта система состоит из управляющего модуля и нескольких собирающих модулей.
//Собирающий модуль за один заход, находясь непосредственно перед некоторым кустом, собирает ягоды с этого куста и с двух соседних с ним.
//Напишите программу для нахождения максимального числа ягод, которое может собрать за один заход собирающий модуль,
//находясь перед некоторым кустом заданной во входном файле грядки.

//Входные данные
//Первая строка содержит целое число N (3 ≤ N ≤ 1000) – количество кустов черники.
//Вторая строка содержит N целых положительных чисел a1, a2, ..., aN – число ягод черники, растущее на соответствующем кусте.
//Все ai не превосходят 1000.

namespace hw_03_taskAdditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randValue = new Random();
            int numOfBushes = randValue.Next(3, 1000);
            string berriesText = string.Empty;
            for (int i = 0; i < numOfBushes; i++)
            {
                int numOfBerries = randValue.Next(1000);
                berriesText += $" {numOfBerries}";
            }

            string[] berriesStr = berriesText.Trim().Split(' ');

            int[] berries = new int[berriesStr.Length];

            for (int i = 0; i < berries.Length; i++)
            {
                try
                {
                    berries[i] = int.Parse(berriesStr[i]);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    berries[i] = 0;
                }
            }

            int sumMax = 0;

            for (int i = 1; i < berries.Length - 1; i++)
            {
                int sum = berries[i] + berries[i - 1] + berries[i + 1];
                if (sumMax < sum)
                {
                    sumMax = sum;
                }
            }

            if (sumMax < (berries[0] + berries[1] + berries[berries.Length -1]))
            {
                sumMax = berries[0] + berries[1] + berries[berries.Length - 1];
            }

            if (sumMax < (berries[berries.Length - 1] + berries[berries.Length - 2] + berries[0]))
            {
                sumMax = berries[berries.Length - 1] + berries[berries.Length - 2] + berries[0];
            }

            Console.WriteLine(sumMax);
        }
    }
}