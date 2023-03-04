//Семинар #9
//Задача #69
//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

namespace cw_09_task69
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = GetConsoleInput($"Please enter {nameof(value)}"); 
            int power = GetConsoleInput($"Please enter {nameof(power)}");

            try
            {
                Console.WriteLine($"{value}^{power} = {GetPowerRec(value, power)}");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        static int GetPowerRec(int value, int power) 
        {
            if (power < 0) 
            {
                throw new ArgumentOutOfRangeException(nameof(power),
                    message: $"{nameof(power)} can not be < 0");
            }
            if (power == 0) { return 1; }
            return GetPowerRec(value, power - 1) * value;
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

                    Console.WriteLine($"{exc.Message} Please enter {typeof(int)} type value");
                }
            }
            return (int)value;
        }
    }
}