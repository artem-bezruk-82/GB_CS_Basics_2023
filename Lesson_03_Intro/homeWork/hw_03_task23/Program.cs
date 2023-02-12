//Семинар #3
//Задача #23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


namespace hw_03_task23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = Math.Abs(GetConsoleInput($"Please enter {nameof(value)}"));
            for (int i = 1; i <= value; i++)
            {
                Console.Write($" {Math.Pow(i,3)}");
            }
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