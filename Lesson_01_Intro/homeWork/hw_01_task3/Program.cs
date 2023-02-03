//Семинар #1
//Задание #3
//Напишите программу, которая будет выдавать название дня недели по заданному номеру.

namespace hw_01_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, our program receives user defined week day number and returns week day");

            while (EndProgram("Would you like to lookup week day?"))
            {
                try
                {
                    WeekDaysEnum weekDay = GetConsoleInput("\nPlease enter number of week day") switch
                    {
                        1 => WeekDaysEnum.Monday,
                        2 => WeekDaysEnum.Tuesday,
                        3 => WeekDaysEnum.Wednesday,
                        4 => WeekDaysEnum.Thursday,
                        5 => WeekDaysEnum.Friday,
                        6 => WeekDaysEnum.Saturday,
                        7 => WeekDaysEnum.Sunday,
                        _ => throw new ArgumentOutOfRangeException(nameof(WeekDaysEnum),
                        $"Week day must be within {(int)WeekDaysEnum.Monday} ... {(int)WeekDaysEnum.Sunday} range")
                    };

                    Console.Write($"{(int)weekDay} - {weekDay}");
                }
                catch (Exception exc)
                {

                    Console.WriteLine(exc.Message);
                }
            }

            Console.WriteLine("\nThank you for using our program! Goodbye!");

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

        static bool EndProgram(string requestText)
        {
            Console.WriteLine($"\n{requestText}, Yes(y), No(n)");
            char key = Console.ReadKey().KeyChar;
            while (key != 'n' && key != 'y')
            {
                Console.WriteLine("\nThe only 'y' or 'n' are required");
                key = Console.ReadKey().KeyChar;
            }
            if (key == 'y')
            {
                return true;
            }
            return false;
        }
    }
}