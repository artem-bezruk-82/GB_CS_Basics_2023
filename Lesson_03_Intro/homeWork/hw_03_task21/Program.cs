//Семинар #3
//Задача #21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

namespace hw_03_task21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Point3D pointA = new Point3D();
            Console.WriteLine($"Create {nameof(pointA)}");
            pointA.SetPointConsole();

            Point3D pointB = new Point3D();
            Console.WriteLine($"Create {nameof(pointB)}");
            pointB.SetPointConsole();

            Console.WriteLine($"{nameof(pointA)}: {pointA}\n{nameof(pointB)}: {pointB}");

            Console.WriteLine($"Distance: {Math.Round(Point3D.GetDistance(pointA, pointB),2)}");
        }
    }
}