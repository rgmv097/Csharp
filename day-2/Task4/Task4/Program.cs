using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Verilmiş tam müsbət n ədədinin rəqəmlərinin cəmini tapan alqoritm (Məsələn: 214 ədədinin rəqəmləri cəmi 2+1+4 = 7)
            int number=Convert.ToInt32(Console.ReadLine());
            int sum = default(int);
            int digit;
            while (number>0)
            {
                digit = number % 10;
                number /= 10;
                sum+=digit;

            }
            Console.WriteLine(sum);
        }
    }
}
