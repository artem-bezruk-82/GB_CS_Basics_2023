//Семинар #3
//Задача #21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

namespace cw_03_task21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point2D pointA = new Point2D();
            Console.WriteLine($"Create {nameof(pointA)}");
            pointA.SetPointConsole();

            Point2D pointB = new Point2D();
            Console.WriteLine($"Create {nameof(pointB)}");
            pointB.SetPointConsole();

            Console.WriteLine($"{nameof(pointA)}: {pointA}\n{nameof(pointB)}: {pointB}");

            Console.WriteLine($"Distance: {Math.Round(Point2D.GetDistance(pointA, pointB), 2)}");
        }
    }
}