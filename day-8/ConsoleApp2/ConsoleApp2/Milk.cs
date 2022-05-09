using System;

namespace ConsoleApp2
{
    internal class Milk : Product
    {
        public static float Volume;
        public static float FatRate;

        public Milk(string productName, int Price, int Count, float volume, float fatRate) : base(productName, Price, Count)
        {

            Volume = volume;
            FatRate = fatRate;
        }


        public override void GetProduct()
        {
            if(Count > 0)
            Console.WriteLine($"Mehsulun Adi: {ProductName}\nQiymeti: {Price}\nSayi: {Count}\nHecmi: {Volume}\nYagliligi: {FatRate}");
            else
            {
                Console.WriteLine("Mehsul bitib");
            }
        }

        public override void Sell()
        {
            if (Count > 0)
            {
                Count--;
                TotalIncome += Price;
                
                Console.Write($"Mehsul SATILDI\n- - - -\nMehsulun Adi: {ProductName}\nQiymeti: {Price}\nSayi: {Count}\nHecmi: {Volume}\nYagliligi: {FatRate}\nINCOME: {TotalIncome}\n");

            }
            else { Console.WriteLine("- - - -\nMehsul bitib satila bilmez"); }




        }
    }
}
