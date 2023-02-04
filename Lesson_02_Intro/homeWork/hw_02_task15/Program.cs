//Семинар #2
//Задача #15
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

namespace hw_02_task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, our program receives user defined week day number and returns week day");

            while (EndProgram("\nWould you like to lookup week day?"))
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
                    string isWeekend = (weekDay == WeekDaysEnum.Sunday || weekDay == WeekDaysEnum.Saturday) ?
                        $"Weekend!!! :-)" : "Working day... :-(";
                    Console.Write($"{(int)weekDay} - {weekDay} {isWeekend}");
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