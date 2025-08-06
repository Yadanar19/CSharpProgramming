using System;

namespace SwapTest
{
    class Program
    {
        // Define the generic swap method
        static void swap<T>(ref T a, ref T b)
        {
            // Output initial values of the two variables
            Console.WriteLine($"Before swap - a: {a}, b: {b}");

            // Use a temporary variable to swap values
            T temp = a;
            a = b;
            b = temp;

            // Output the swapped values
            Console.WriteLine($"After swap - a: {a}, b: {b}");
        }

        static void Main(string[] args)
        {
            // Declare two string variables for temperature values
            string celsius = "5";  // 5°C
            string fahrenheit = "41";  // 41°F

            // Output the initial temperature values before the swap
            Console.WriteLine("Initial temperature values:");
            Console.WriteLine($"Celsius: {celsius}°C, Fahrenheit: {fahrenheit}°F");

            // Call the swap method for Celsius and Fahrenheit
            swap<string>(ref celsius, ref fahrenheit);
        }
    }
}
