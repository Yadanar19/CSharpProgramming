using System;

namespace CityTest
{
    class City
    {
        // Private fields
        private string name;
        private int population;
        private string country = string.Empty; // Initialize with an empty string

        // Constructor to initialize name and population
        public City(string cityName, int cityPopulation)
        {
            name = cityName;
            population = cityPopulation;
        }

        // Overloaded constructor to initialize name, population, and country
        public City(string cityName, int cityPopulation, string cityCountry)
        {
            name = cityName;
            population = cityPopulation;
            country = cityCountry; // Initialize country field
        }

        // Public method to get the city name
        public string GetCity()
        {
            return name;
        }

        // Public method to get the population
        public int GetPopulation()
        {
            return population;
        }

        // Public read-only property for country
        public string Country
        {
            get { return country; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the City class with the overloaded constructor (city name, population, country)
            City myCity = new City("Seattle", 797700, "United States");

            // Display the city name, population, and country using the methods and property
            Console.WriteLine("City: " + myCity.GetCity());
            Console.WriteLine("Population: " + myCity.GetPopulation());
            Console.WriteLine("Country: " + myCity.Country); // Using the read-only property for country
        }
    }
}
