using System;

namespace Increment_Decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            //loop through and print number from 0 to when it equal to 10
            for(int a = 0; a <= 10; a++) //increment a from 0 to 10
            { 
                Console.WriteLine(a); //output the variabl of "a" by going through each loop until the loop is equal to 10
            }
            //challenge: loop through & print number from 15 to until the loop equal to 0
            for (int b = 15; b >= 0; --b) //decrement b from 15 to 0
            {
                Console.WriteLine(b); //ouput the variable of "b" loops
            }
        }
    }
}