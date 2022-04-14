using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Natural ededin evveline 3 kecirib yeni eded duzelden bir method yazin          Example: 529 => 3529
            int divide=Convert.ToInt32(Console.ReadLine()); 
            AddNumber(divide);
        }
        public static void AddNumber(int divide)
        {
            int count = 0;
            int number = divide;
            
            while (divide>0)
            {

                divide /= 10;
                count++;

            }
            int x10Numbers = 1;
            for (int i = 1; i <= count; i++)
            {
                x10Numbers = x10Numbers * 10;
            }
            int NewNumber = 3 * x10Numbers +number ;
            Console.WriteLine(NewNumber);
            



        }
    }
}
