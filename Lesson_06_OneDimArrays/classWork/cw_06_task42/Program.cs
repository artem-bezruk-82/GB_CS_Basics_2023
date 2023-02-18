//Семинар #6
//Задача #42
//Напишите программу, которая будет преобразовывать десятичное число в двоичное.

namespace cw_06_task42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valueDec = GetConsoleInput($"Please enter {typeof(int).Name} value");
            string binary = string.Empty;

            while (valueDec > 0) 
            {
                binary = $"{valueDec % 2}{binary}";
                valueDec /= 2;
            }

            Console.WriteLine(binary);
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

                    Console.WriteLine($"{exc.Message} Please enter integer value");
                }
            }
            return (int)value;
        }
    }
}