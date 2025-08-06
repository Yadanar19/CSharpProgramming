using System;

namespace CityTest
{
    class City
    {
        // Private fields
        private string name;
        private int population;
        private string country;

        // Constructor to initialize name and population (with optional country)
        public City(string cityName, int cityPopulation, string cityCountry = "Unknown")
        {
            name = cityName;
            population = cityPopulation;
            country = cityCountry; // Initialize country field with the provided or default value
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

        // Static method to display information
        public static void DisplayCityInfo()
        {
            Console.WriteLine("City Info Version 1.0");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Call the static method without creating a City object
            City.DisplayCityInfo(); // Static method call, no need for an instance of City class

            // Create an instance of the City class with country provided
            City myCity = new City("Seattle", 797700, "United States");

            // Display the city name, population, and country using the methods and property
            Console.WriteLine("City: " + myCity.GetCity());
            Console.WriteLine("Population: " + myCity.GetPopulation());
            Console.WriteLine("Country: " + myCity.Country);
        }
    }
}
