//Семинар #2
//Задача #11
//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

namespace cw_02_task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int value = random.Next(100,999);
            Console.WriteLine($"Value: {value}; 2nd digit:{(value / 10) % 10}");
        }
    }
}