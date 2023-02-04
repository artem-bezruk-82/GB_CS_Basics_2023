//Семинар #2
//Задача #9
//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.


namespace cw_02_task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            byte value = (byte)random.Next(10, 99);
            byte maxDigit = (value % 10 > value / 10) ? (byte)(value % 10) : (byte)(value / 10);
            Console.WriteLine($"Value: {value}; MaxDigit: {maxDigit} ");
        }
    }
}