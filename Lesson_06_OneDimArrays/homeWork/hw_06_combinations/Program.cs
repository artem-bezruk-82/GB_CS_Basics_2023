//Семинар #6
//Дополнительная задача
//Перестановки (https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=9&id_topic=123&id_problem=765)
//Дана строка, состоящая из N попарно различных символов. Требуется вывести все перестановки символов данной строки.

//Входные данные
//Cтроку, состоящая из N символов (1 ≤ N ≤ 8), символы - буквы английского алфавита и цифры.

//Выходные данные
//Выведите в каждой строке по одной перестановке.
//Перестановки можно выводить в любом порядке.
//Повторений и строк, не являющихся перестановками исходной, быть не должно.


using System.Text;

namespace hw_06_combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "ABCD";
            string output = string.Empty;
            StringBuilder sb = new StringBuilder(input);

            for (int i = 0; i < sb.Length; i++)
            {
                for (int j = 0; j < sb.Length - 1; j++)
                {
                    (sb[j], sb[j + 1]) = (sb[j + 1], sb[j]);
                    output += $"{sb}\n";
                }
            }

            Console.WriteLine(output);
        }
    }
}