using ConsoleApp1.BaseEntity;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Brand: ");
            string BrandBus = Console.ReadLine();
            Console.Write("Model: ");
            string ModelBus = Console.ReadLine();
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
