//Семинар #9
//Задача #64
//Задайте значения M и N.
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


namespace hw_09_task64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = GetConsoleInput($"Please enter {nameof(start)} value ({typeof(int)})");
            int end = GetConsoleInput($"Please enter {nameof(end)} value ({typeof(int)})");
            Console.WriteLine(GetRangeValuesRec(start,end));
        }

        static string GetRangeValuesRec(int startRange, int endRange) 
        {
            if (endRange == startRange) 
            {
                return $"{startRange}";
            }
            if (startRange > endRange) 
            {
                (startRange,endRange) = (endRange,startRange);
            }
            return GetRangeValuesRec (startRange, endRange - 1) + $" {endRange}";
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

                    Console.WriteLine($"{exc.Message} Please enter {typeof(int)} value");
                }
            }
            return (int)value;
        }
    }
}