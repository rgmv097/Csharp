using System;
using System.Collections;

namespace ConsoleApp1
{
    internal class Country
    {
        public string Name { get; set; }
        public static int TotalPopulation { get; set; }
        public ArrayList Cities;
        public Country(string name)
        {
            Name = name;
            Cities = new ArrayList();           
        }
        public void Add(City city)
        {
            Cities.Add(city);
        }
        static  Country()
        {
            TotalPopulation = 0;
        }
       
        public void FindAllByPopulation(int min,int max)
        {
            foreach (City city in Cities)
            {
                if (city.Population > min && city.Population < max)
                {
                    Console.WriteLine("Founded cities: "+city.CityName);
                }
            }
        }
        public void TotalPopOfCountry()
        {           
            foreach(City city in Cities)
            {
             TotalPopulation+=city.Population;
            }
            Console.WriteLine($"Total OF {Name} POP: {TotalPopulation}");         
        }
    }
}
