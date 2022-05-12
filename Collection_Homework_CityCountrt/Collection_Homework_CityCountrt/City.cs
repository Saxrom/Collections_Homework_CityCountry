using System;
namespace Collection_Homework_CityCountry
{
    class City
    {
        public string Name { get; set; }
        public int Population;


        public City(string name,int population)
        {
            Name = name;
            Population = population;
        }

        public override string ToString()
        {
            return $"City:{Name} , City:{Population}";
        }
    }
}
