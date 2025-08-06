using System;

namespace CityTest
{
    class City
    {
        // Private fields
        private string name;
        private int population;

        // Constructor to initialize name and population
        public City(string cityName, int cityPopulation)
        {
            name = cityName;
            population = cityPopulation;
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the City class
            City myCity = new City("Seattle", 797700);

            // Display the city name and population using the methods
            Console.WriteLine("City: " + myCity.GetCity());
            Console.WriteLine("Population: " + myCity.GetPopulation());
        }
    }
}
