//Семинар #6
//Дополнительная задача
//Площадь треугольника(https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=6&id_topic=116&id_problem=719)
//По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.
//Входные данные
//6 целых чисел x1, y1, x2, y2, x3, y3 – координаты вершин треугольника.
//Все числа не превышают 106 по абсолютной величине.
//Выходные данные
//Выведите точное значение площади заданного треугольника.

namespace hw_o6_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();

            Point2D point1 = new Point2D(random.Next(107), random.Next(107));
            Point2D point2 = new Point2D(random.Next(107), random.Next(107));
            Point2D point3 = new Point2D(random.Next(107), random.Next(107));

            Console.WriteLine($"{nameof(point1)}: {point1}\n{nameof(point2)}: {point2}\n{nameof(point3)}: {point3}");

            double sideA = Point2D.GetDistance(point1, point2);
            double sideB = Point2D.GetDistance(point1, point3);
            double sideC = Point2D.GetDistance(point3, point2);

            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Console.WriteLine($"{nameof(triangle)}'s sides: {triangle}");
            Console.WriteLine($"Squere: {Math.Round(triangle.GetSquare(), 2)}");
        }
    }
}