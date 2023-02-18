//Семинар #6
//Задание #41
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

namespace hw_06_task41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 5;
            int positiveValues = 0;

            for (int i = 1; i <= m; i++)
            {
                if (GetConsoleInput($"Please enter {typeof(int).Name} value") > 0)
                {
                    positiveValues++;
                }
                Console.WriteLine($"You have entered {i} values out of {m} and {positiveValues} values were positive ones");
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