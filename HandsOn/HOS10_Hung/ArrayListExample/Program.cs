using System;
using System.Collections;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string [] args)
        {
            //Creat an ArrayList using the buit-in library
            ArrayList myArrList = new ArrayList();

            //Add values to the ArrayList using the Add() method
            myArrList.Add(10); // Integer
            myArrList.Add(11.5);  //Double
            myArrList.Add("This is a string"); // String

            //Add values to the ArrayList using the AddRang() method
            myArrList.AddRange(new ArrayList() { 28, 17.7, "This is another string" });

            //Remove ArrayList elements using RemoveRange(), RemoveAt(), and Remove() methods
            myArrList.Remove(10); //Remove elements with a value of 10
            //now the ArrayList has 4 elements total

            myArrList.RemoveAt(0); //Remove element at index 0, which is now 11.5
            //now the ArrayList has a total of 5 elements

            myArrList.RemoveRange(1,2); //Remove elements from index 1 to before 2
            //Now the ArrayList has 2 elements total

            //Print each value in the ArrayList using foreach() method
            foreach (var value in myArrList)
            {
                Console.WriteLine(value);
            }
        }
    }
}