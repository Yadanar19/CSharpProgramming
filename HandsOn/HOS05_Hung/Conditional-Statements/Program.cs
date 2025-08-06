using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            Console.WriteLine("Guess a number (1-10): ");
            int userInput = Convert.ToInt32(Console.ReadLine()); //receive user input and store in "userInput" variable

            if (userInput == num)
            {
                Console.WriteLine("Your guess was correct!");
            }
            //Challenge
            else if (userInput > 10) // if user input #>10 conditions is created
            {
                Console.WriteLine("Number must be between 1-10!!!"); //output instruction to input # between 1-10
            }
            else if (userInput != num)
            {
                Console.WriteLine("You guessed wrong. Goodluck next time!");
            }
        }
    }
}