//Семинар #4
//Задача #29
//https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=114&id_problem=699
//Шеренга
//Петя впервые пришел на урок физкультуры в новой школе.
//Перед началом урока ученики выстраиваются по росту, в порядке невозрастания.
//Напишите программу, которая определит на какое место в шеренге Пете нужно встать, чтобы не нарушить традицию,
//если заранее известен рост каждого ученика и эти данные уже расположены по невозрастанию (то есть каждое следующее число не больше предыдущего).
//Если в классе есть несколько учеников с таким же ростом, как у Пети, то программа должна расположить его после них.
//Входные данные
//Первая строка содержит натуральное число N (N ≤ 100) – количество учеников(не считая Петю).
//Во второй строке записаны N натуральных чисел Ai (Ai ≤ 200) – рост учеников в сантиметрах в порядке невозрастания.
//Третья строка содержит единственное натуральное число X (X ≤ 200) – рост Пети.
//Выходные данные
//Выведите единственное целое число – номер Пети в шеренге учеников.

namespace hw_04_task29
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string lineInputStr = "165 163 160 160 157 157 155 154";
            string heightInputStr = "162";
            int rank = -1;

            string[] lineStr = lineInputStr.Trim().Split(' ');
            int[] line = new int[lineStr.Length];
            for (int i = 0; i < line.Length; i++)
            {
                int.TryParse(lineStr[i],out line[i]);
            }
            Console.WriteLine(string.Join(',',line));

            int height = int.Parse(heightInputStr.Trim());

            if (height > line[0])
            {
                rank = 1;
            }
            else if (height < line[line.Length - 1])
            {
                rank = line.Length + 1;
            }
            else 
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] < height)
                    {
                        rank = i + 1;
                        break;
                    }
                }
            }

            Console.WriteLine(rank);
        }
    }
}