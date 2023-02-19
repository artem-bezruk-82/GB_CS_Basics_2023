//Семинар #6
//Задание #43
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.


namespace hw_06_task43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StraightLine sl1 = new StraightLine();
            StraightLine sl2 = new StraightLine();
            sl1.SetLineEquastion();
            sl2.SetLineEquastion();
            Console.WriteLine($"First line defined by the equastion:\n{sl1}");
            Console.WriteLine($"First line defined by the equastion:\n{sl2}");

            Point? point = StraightLine.GetIntersectionPoint(sl1,sl2);

            if (point is not null)
            {
                Console.WriteLine($"Intersection point: {point}");
            }
            else 
            {
                Console.WriteLine("Lines are parallel to each other");
            }

        }
    }
}