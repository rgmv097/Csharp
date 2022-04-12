using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console penceresinde 2 eded daxil edin. Daxil olunan 2 ededden hansinin
            //boyuk oldugu ekrana yazilsin. Eger beraberdirse ekrana beraberdir yazilsin
            Console.WriteLine("1 ci ededi daxilt et:");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2 ci ededi daxilt et:");
            int b =Convert.ToInt32(Console.ReadLine());

            if (a>b)
            {
                Console.WriteLine("1 ci eded boyukdur - "+ a);
            }
            else if (b>a)
            {
                Console.WriteLine("2 ci eded boyukdur - " + b);
            }
            else
            {
                Console.WriteLine("ededler beraberdir");
            }
        }
    }
}
