using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Elave edeceyiniz mehsulun adi: ");
            string ProductName = Console.ReadLine();
            Console.Write("Mehsulun Qiymeti: ");
            int Price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mehsulun Sayi: ");
            int Count = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mehsulun Hecmi(Litr): ");
            float Volume = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mehsulun Yaglilig faizi: ");
            float FatRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("- - - - - - - - - - - - -");
            Milk milk = new Milk(ProductName,Price,Count,Volume,FatRate);
            bool result = false;
            do
            {
                Console.Write("1-Mehsulu sat\n2-Mehsullar Haqqinda\n2-Programi Bagla\n- - - - -\n");
                byte select=Convert.ToByte(Console.ReadLine());
                if (select == 1)
                {
                    milk.Sell();
                    Console.WriteLine("- - - - - ");
                }
                else if (select == 2) { milk.GetProduct(); }
                else if (select == 3) { result = true; }
                else
                {
                    Console.WriteLine("Duzgun reqemi sechin");
                }

            } while (result!=true);
           
            





        }
    }
}
