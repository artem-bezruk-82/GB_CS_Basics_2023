//Семинар #9
//Задача #68
//Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29

namespace hw_09_task68
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int m = 3;

            Console.WriteLine(GetAckermanFunctionRec(n,m));
        }

        static int GetAckermanFunctionRec(int n, int m) 
        {
            if (n == 0)
            {
                return m + 1;
            }
            else if ((n != 0) && (m == 0))
            {
                return GetAckermanFunctionRec(n - 1, 1);
            }
            else
            {
                return GetAckermanFunctionRec(n - 1, GetAckermanFunctionRec(n, m - 1));
            }
        }
    }
}