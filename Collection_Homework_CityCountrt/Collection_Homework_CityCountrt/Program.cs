using System;
using System.Collections;
using System.Collections.Generic;
using Collection_Homework_CityCountry;

namespace Collection_Homework_CityCountrt
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the name of the country:");
            string name = Console.ReadLine();
            Country countryAzerbaijan = new Country(name);
            Country countryRussia = new Country(name);
            Info(countryAzerbaijan);
            Info(countryRussia);
            
            
            
        }

        public static void Info(Country  country)
        {
            Console.WriteLine("Enter the number of cities:");
            int count = Convert.ToInt32(Console.ReadLine());
            int population = 0;
            string cityname;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Please enter the name of the city:");
                cityname = Console.ReadLine();

                Console.WriteLine("Please enter the population of the city:");
                population = Convert.ToInt32(Console.ReadLine());

                City city = new City(cityname, population);
                country.Add(city);
            }

            foreach (var item in country.Get())
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("***");

            Console.WriteLine("Enter the minimum population:");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the maximum population:");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The information you were looking for was found:");
            country.FindAllByPopulation(min, max);
        }
    }
}
