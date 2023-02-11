//Семинар #4
//Задача #26
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

namespace cw_04_task26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter value");
            int value = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            while (value != 0) 
            {
                value /= 10;
                counter++;
            }
            Console.WriteLine($"You have entered {counter}-digits value");
        }
    }
}