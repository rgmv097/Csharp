using System;

namespace task4withmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş tam müsbət n ədədinin rəqəmlərinin cəmini tapan alqoritm (Məsələn: 214 ədədinin rəqəmləri cəmi 2+1+4 = 7)
            int divide =Convert.ToInt32(Console.ReadLine());
            sum(divide);

        }
        public static void sum(int divide)
        {
            int lastDigit;
            int sum = default(int);
            while (divide>0)
            {
                lastDigit = divide % 10;
                divide /= 10;
                sum+=lastDigit;


            }
            Console.WriteLine(sum);




        }
    }
}
