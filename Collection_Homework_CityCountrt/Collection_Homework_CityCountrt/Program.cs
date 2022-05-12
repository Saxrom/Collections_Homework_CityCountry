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
            string name = Console.ReadLine();
            Country countryAzerbaycan = new Country(name);
            Country countryRussia = new Country("Russia");
            Info(countryAzerbaycan);
            Info(countryRussia);


        }

        public static void Info(Country  country)
        {
            Console.WriteLine("City-lerin sayini daxil edin:");
            int count = Convert.ToInt32(Console.ReadLine());
            int population = 0;
            string cityname;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Zehmet olmasa sheherin adini daxil edin:");
                cityname = Console.ReadLine();

                Console.WriteLine("Zehmet olmasa sheherin ehali sayini daxil edin:");
                population = Convert.ToInt32(Console.ReadLine());

                City city = new City(cityname, population);
                country.Add(city);
            }

            foreach (var item in country.Get())
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("***");

            Console.WriteLine("Ehalinin minimum sayini daxil edin");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ehalinin maximum sayini daxil edin");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Axtardiqiniz mellumat tapildi:");
            country.FindAllByPopulation(min, max);
        }
    }
}
