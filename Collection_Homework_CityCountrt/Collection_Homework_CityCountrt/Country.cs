using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection_Homework_CityCountry
{
    class Country
    {
        public string Name { get; set; }
        public  int TotalPopulation;
        ArrayList Cities;

        public Country(string name)
        {
            Name=name;
            Cities = new ArrayList();
        }

        public ArrayList Get()
        {
            return Cities;
        }

        public void Add(City city)
        {
            Cities.Add(city);
        }

        public int totalPopulation()
        {
            int total = 0;
            foreach (City city in Cities)
            {
                total += city.Population;
            }
            return total;
        }

        public void FindAllByPopulation(int min,int max)
        {
            bool resalt = false;
            foreach (City city in Cities)
            {
                if (city.Population > min && city.Population < max)
                {
                    Console.WriteLine(city);
                    resalt = true;
                }
             
            }
            if (resalt == false) Console.WriteLine("No 'City' found in the space you entered");
            
        }
        

    }
}
