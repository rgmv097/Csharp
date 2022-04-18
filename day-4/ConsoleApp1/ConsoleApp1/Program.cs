using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Ededlerden ibaret array verilib, bu ededlerin en
            //boyuyunu tapmali.  Mes: [10,8,49,17,5] Ekrana en boyuk eded yazilmalidir: 49
            int[] arr = { 10, 8, 49, 17, 5 };
            int MaxValue=0;
            foreach (int i in arr)
            {
                if (i>MaxValue)
                {                 
                    MaxValue =i;
                }
            }
            Console.WriteLine(MaxValue);
        }
    }
}
