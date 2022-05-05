using System;

namespace ConsoleApp1.BaseEntity
{
    internal abstract class Vehicle
    {
        public string Brand;
        public string Model;
        public string Color;
        public short MaxSpeed;

        public Vehicle()
        {
            Console.WriteLine("Car Created");
        }
        public Vehicle(string brand, string model) : this()
        {
            if (!string.IsNullOrEmpty(brand) || !string.IsNullOrWhiteSpace(model))
            {
                Brand = brand;
                Model = model;
            }

        }
        public Vehicle(string brand, string model, string color, short maxspeed) : this(brand, model)
        {
           
               Color = color;
               MaxSpeed = maxspeed;

        }
        public abstract void Info();


    }
}
