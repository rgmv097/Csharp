using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Ededlerden ibaret array verilib, bu ededlerin en
            //boyuyunu tapmali.  Mes: [10,8,49,17,5] Ekrana en boyuk eded yazilmalidir: 49
            Console.WriteLine("Massivin Uzunlugun Daxil edin:");
            int ArrSize = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[ArrSize];
            int MaxOfArr = 0;
            for (int i = 0; i < ArrSize; i++)
            {
                Console.WriteLine("Massivin " + (i) + " ci  elementini daxil edin");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var i in arr)
            {
                if (i > MaxOfArr)
                {
                    MaxOfArr = i;
                }
            }
            Console.WriteLine("Max NUMBER in ARR " + MaxOfArr);
        }
    }
}
