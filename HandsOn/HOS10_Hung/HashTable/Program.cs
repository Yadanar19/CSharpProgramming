using System;
using System.Collections;

namespace HashTableExample // Changed the namespace name to avoid conflict
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a Hashtable using the built-in collection library
            Hashtable myHashTable = new Hashtable();

            // Add key-value pairs to the Hashtable using Add() method
            myHashTable.Add("Kim", 26);  // key = Kim; value = 26
            myHashTable.Add("John", 77); // key = John; value = 77
            myHashTable.Add("Max", 50);  // key = Max; value = 50

            // Get the value for each key and cast it to an int
            int hashTableVal1 = (int)myHashTable["Kim"];  // Get value for "Kim"
            int hashTableVal2 = (int)myHashTable["John"]; // Get value for "John"
            int hashTableVal3 = (int)myHashTable["Max"];  // Get value for "Max"

            // Print the values on the screen
            Console.WriteLine(hashTableVal1); // Output: 26
            Console.WriteLine(hashTableVal2); // Output: 77
            Console.WriteLine(hashTableVal3); // Output: 50
        }
    }
}
