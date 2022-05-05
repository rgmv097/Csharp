using ConsoleApp1.BaseEntity;

using System;

namespace ConsoleApp1
{
    internal class Bus : Vehicle
    {
        public byte PessengerCount;
        public Bus(string brand, string model, string color, short maxspeed, byte pessengerCount) : base(brand, model, color, maxspeed)
        {
            PessengerCount = pessengerCount;
        }
        public override void Info()
        {
            if (Brand != null && Model != null)
            {

                Console.WriteLine($"- - - - - - -\nBrand: {Brand}\nModel: {Model}\nColor: {Color}\nMaxSpeed: {MaxSpeed}\nPessenger Count: {PessengerCount}");
            }
            else Console.WriteLine("Obyekt yaradilmadi");
        }

    }
}
