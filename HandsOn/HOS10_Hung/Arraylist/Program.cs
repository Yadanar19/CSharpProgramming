    using System;
    using System.Collections;  // Ensure this is present for ArrayList

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrList = new ArrayList(); // create ArrayList using built-in library
            
            // Add values to ArrayList using Add() method
            myArrList.Add(10); // Integer
            myArrList.Add(11.5);  //float
            myArrList.Add("This is a string"); // String

            // Add a range of values to the ArrayList
            myArrList.AddRange(new ArrayList() { 20, 17.7, "This is another string" });

            // Print each value in the ArrayList using foreach() method
            foreach(var value in myArrList)
            {
                Console.WriteLine(value);
            }
        }
    }
}
