//Семинар #9
//Задача #66
//Задайте значения M и N.
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

namespace hw_09_task66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = GetConsoleInput($"Please enter {nameof(start)} value ({typeof(int)})");
            int end = GetConsoleInput($"Please enter {nameof(end)} value ({typeof(int)})");
            Console.WriteLine(GetSumInRangeRec(start, end));
        }

        static int GetSumInRangeRec(int startRange, int endRange) 
        {
            if (startRange == endRange) 
            {
                return endRange; 
            }
            if (startRange > endRange) 
            {
                (startRange, endRange) = (endRange, startRange);
            }
            return GetSumInRangeRec(startRange + 1, endRange) + startRange;
        }

        static int GetConsoleInput(string requestText)
        {
            int? value = null;

            while (value is null)
            {
                Console.WriteLine(requestText);
                try
                {
                    value = int.Parse(Console.ReadLine() ?? "");
                }
                catch (Exception exc)
                {

                    Console.WriteLine($"{exc.Message} Please enter {typeof(int)} type value");
                }
            }
            return (int)value;
        }
    }
}