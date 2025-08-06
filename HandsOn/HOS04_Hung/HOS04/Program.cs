using System;

namespace Methods
{
    class Program
    {
        //this is a method called "PrintSomething"
        //its function is to print a line of string "Hello Wrold!"
        public static int Adding(int num1, int num2)
        {
            //the passed is integers are added
            //and the result is stroed in the interger "sum"
            int sum = num1 + num2;
            return sum; // return the balue stored in "sum"
        }


         public static int Mod(int a, int b) //Challenge
        {
            //the passed is integers that remainder of 20/13
            //and the result is stroed in the interger "sum"
            int sum = a % b;
            return sum; // return the value stored in "sum"
        }

        //this is a method called "Main",
        //this method is called when the program is ran
        static void Main(string[] args)
        {
            //call method "Adding" and pass in 2 parameters: 10 and 20
            //and print the result of method "Adding"
            Console.WriteLine(Adding(10,20));
            //Challenge
            //call method "Mod" and pass in 2 parameters: 20 and 13
            //and print the result of method "Mod"
            Console.WriteLine(Mod(20,13));
        }
    }

}