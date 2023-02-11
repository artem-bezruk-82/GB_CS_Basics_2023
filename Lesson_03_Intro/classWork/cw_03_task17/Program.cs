//Семинар #3
//Задание #17
//Напишите программу, которая принимает на вход координаты точки (X и Y),
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

namespace cw_03_task17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Point point = new Point() 
            {
                X = GetConsoleInput($"Please enter {nameof(point.X)}"),
                Y = GetConsoleInput($"Please enter {nameof(point.Y)}")
            };

            string quarter = point switch 
            {
                { X: > 0, Y: > 0 } => "1st",
                { X: > 0, Y: < 0 } => "2nd",
                { X: < 0, Y: < 0 } => "3rd",
                { X: < 0, Y: > 0 } => "4th",
                _=> throw new ArgumentOutOfRangeException(nameof(point), message: "The point is on the coordinate axis"),
            };

            Console.WriteLine($"Point {point} is located within {quarter} quarter");
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