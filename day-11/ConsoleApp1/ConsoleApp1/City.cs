using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class City
    {
        public string CityName { get; set; }
        public int Population { get; set; }
        public City(string cityName,int population)
        {
            CityName = cityName;    
            Population = population;
        }          
    }
}
