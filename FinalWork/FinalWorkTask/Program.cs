//Итоговая проверочная работа
//Написать программу, которая из имеющегося массива строк формирует массив из строк , длина которых <= 3 символа

namespace FinalWorkTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] initArray =
            {
                "hello",
                "2",
                "word",
                ":-)",
                "1234",
                "1576",
                "-2",
                "computer science"
            };
            string[] finalArray = new string[0];

            for (int i = 0; i < initArray.Length; i++)
            {
                if (initArray[i].Length <= 3)
                {
                    ArrayPushBack(ref finalArray, initArray[i]);
                }
            }

            Console.WriteLine($"Initial array: [{string.Join(',', initArray)}]");
            Console.WriteLine($"Final array: [{string.Join(',', finalArray)}]");
        }

        static void ArrayPushBack(ref string[] array, string element) 
        {
            string[] temp = new string[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                temp[i] = array[i];
            }
            temp[temp.Length - 1] = element;
            array = temp;
        } 
    }
}