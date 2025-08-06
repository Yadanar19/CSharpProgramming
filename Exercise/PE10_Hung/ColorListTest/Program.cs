using System;
using System.Collections;  //Import the correct namespace for List<T>

namespace ColorListTest
{
    class Program
    {
        //Define the Print utility method
        private static void Print(string s)
        {
            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            //Define the Colors list
            List<string> Colors = new List<string>();

            //Add colors to the list
            Colors.Add("White");
            Colors.Add("Red");
            Colors.Add("Orange");
            Colors.Add("Yellow");
            Colors.Add("Green");
            Colors.Add("Blue");
            Colors.Add("Indigo");
            Colors.Add("Violet");
            Colors.Add("Black");

            //Print the original list before sorting
            Console.WriteLine("Original Colors list (before sorting):");
            Colors.ForEach(Print);

            //Find the index of "Violet" before sorting
            int violetIndexBeforeSort = Colors.IndexOf("Violet");
            Console.WriteLine($"\nIndex of Violet before sorting: {violetIndexBeforeSort}");

            //Sort the list alphabetically
            Colors.Sort();

            //Print the sorted list
            Console.WriteLine("\nSorted Colors list:");
            Colors.ForEach(Print);

            //Find the index of "Violet" after sorting
            int violetIndexAfterSort = Colors.IndexOf("Violet");
            Console.WriteLine($"\nIndex of Violet after sorting: {violetIndexAfterSort}");

            //Remove "Violet" using its index
            Colors.RemoveAt(violetIndexAfterSort);

            //Insert "Purple" in the second-to-last position
            Colors.Insert(Colors.Count - 2, "Purple");

            //Print the modified list
            Console.WriteLine("\nModified Colors list (after removing Violet and inserting Purple):");
            Colors.ForEach(Print);

            //Check if "Magenta" is in the list
            if (Colors.Contains("Magenta"))
            {
                Console.WriteLine("\nMagenta is in the list");
            }
            else
            {
                Console.WriteLine("\nMagenta is not in the list");
            }

            //Add "Magenta" to the list
            Colors.Add("Magenta");

            //Check again if "Magenta" is in the list
            if (Colors.Contains("Magenta"))
            {
                Console.WriteLine("\nMagenta is in the list");
            }

            //Print the final list after adding Magenta
            Console.WriteLine("\nFinal Colors list (after adding Magenta):");
            Colors.ForEach(Print);

            //Add a space between the list and the next Console.WriteLine statement
            Console.WriteLine(); //Empty line for spacing

            //Explanation about Insert() and Add() methods with "Q1A:" and "Q2A:" added
            Console.WriteLine("Q1A: The Insert() method is used to insert an item at a specific index in the list, rather than adding it at the end. In this case, I used Insert() to place Purple in the second-to-last position, which wouldn't be achieved with Add() alone.");
            //Add a space between the list and the next Console.WriteLine statement
            Console.WriteLine(); //Empty line for spacing
            Console.WriteLine("Q2A: Add() appends the new item to the list. The Add() method places Magenta at the end of the list.");
        }
    }
}
