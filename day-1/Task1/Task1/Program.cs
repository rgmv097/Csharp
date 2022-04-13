using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=Convert.ToInt32(Console.ReadLine());
            if(a%2==0)
            {
                Console.WriteLine("Cutdur");
            }
            else
            {
                Console.WriteLine("Tekdir");

            }
        }
    }
}
