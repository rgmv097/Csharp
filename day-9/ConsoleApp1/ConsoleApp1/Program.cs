using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string BrandBus;
            string ModelBus;
            do
            {
                Console.Write("Brand: ");
                BrandBus = Console.ReadLine();
                Console.Write("Model: ");
                ModelBus = Console.ReadLine();
            }
            while (BrandBus != null || ModelBus != null);
                    
            Console.Write("Color: ");
            string ColorBus = Console.ReadLine();
            Console.Write("TopSpeed: ");
            short TopSpeedBus = Convert.ToInt16(Console.ReadLine());
            Console.Write("Pessengers Count: ");
            byte PessengerCount = Convert.ToByte(Console.ReadLine());
            Bus bus = new Bus(BrandBus, ModelBus, ColorBus, TopSpeedBus, PessengerCount);
            bus.Info();

        }
    }
}
