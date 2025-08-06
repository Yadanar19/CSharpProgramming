using System;
namespace StringLoopTest{
    class Program{
        public static void Main() {
            string[] letters = new string[] {"I","am","a","female." }; //initialize an array of strings 
            for (int i = 0; i < letters.Length; i++) { //use for loop to iterate all elements of array
                Console.WriteLine("Element [" + i + "] = " + letters[i]); //display current elments and the index of console
            }
            Console.ReadLine(); //promt user to input before closing the program
        }
    }
}