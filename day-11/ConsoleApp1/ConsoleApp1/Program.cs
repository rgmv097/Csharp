using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string CountryName;
            Console.Write("Select Count of Country: ");
            int CountryCount=Convert.ToInt32(Console.ReadLine());
            while (CountryCount!=0)
            {
                Console.Write("Enter of Country Name: ");
                CountryName = Console.ReadLine();
                Country country = new Country(CountryName);
                CountryCount--;
                AddCity(country);
                Console.Write("Pop Of Min:");
                int min = Convert.ToInt32(Console.ReadLine());
                Console.Write("Pop Of Max:");
                int max = Convert.ToInt32(Console.ReadLine());
                country.FindAllByPopulation(min, max);
                country.TotalPopOfCountry();
            }
            
        }
        public static void AddCity(Country country)
        {
            Console.Write("City Of Count: ");
            int CountOfCity = Convert.ToInt32(Console.ReadLine());
            while (CountOfCity != 0)
            {
                Console.Write("CityName: ");
                string CityName = Console.ReadLine();
                Console.Write(CityName + " of POP: ");
                int PopOfCity = Convert.ToInt32(Console.ReadLine());
                City city = new City(CityName, PopOfCity);
                country.Add(city);

                CountOfCity--;
            }
        }

    }
}
