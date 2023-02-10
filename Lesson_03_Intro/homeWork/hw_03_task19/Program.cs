//Семинар #3
//Задача #19

using System.Text;

namespace hw_03_task19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int? valueInt = null;

            do
            {
                valueInt = GetConsoleInput("Please enter 5-digits value");
                if (valueInt < 10000 || valueInt > 99999) 
                {
                    Console.WriteLine("You have entered out of range value. Please try again.");
                }
            } while (valueInt < 10000 || valueInt > 99999);

            string valueStr = $"{valueInt}";
            StringBuilder valueSB = new StringBuilder(valueStr);

            for (int i = 0; i < valueSB.Length/2; i++)
            {
                (valueSB[i], valueSB[valueSB.Length - i - 1]) = (valueSB[valueSB.Length - i - 1], valueSB[i]);
            }

            Console.WriteLine(valueInt + (valueStr == valueSB.ToString() ? " is" : " is not") + " palindrome");
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