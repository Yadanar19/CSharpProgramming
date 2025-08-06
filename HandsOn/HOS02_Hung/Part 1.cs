using System;
using Microsoft.VisualBasic;

namespace HOS02A
{

    class Program {
        static void Main(string[] args)
        {
            int[] numbers = new int[5]; // creating a new array of type interger named 'numbers'
            // Assign value to the array elements
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

        
            //Challenge array
            string[] Sentence = new string[4]; // creating a new array of type string named 'Sentence'
            // Assign value to the array elements
            Sentence [0] = "This"; 
            Sentence [1] = "is";
            Sentence [2] = "a";
            Sentence [3] = "string";

            //loop to print out the whole numbers array
            for (int i= 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            } 

            Console.WriteLine(); // add a newline after printing the numbers array

            // Challenge loop to print out the whole Sentence array
            for (int i= 0; i < Sentence.Length; i++)
            {
                Console.Write(Sentence[i] + " ");
            }

        }
    }
}
