using System;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1; //num variable is equal to interger 1
            int userInput =0; //UserInput store user's guess
            
            while(userInput <1 || userInput > 10) // if user input #>10 conditions is created
            {
                Console.WriteLine("Guess a number (1-10):  "); //prompt user to input an interger between 1-10
                userInput = Convert.ToInt32(Console.ReadLine()); // recieve user input and and store in "userInput" variable

                if (userInput < 1 || userInput >10) //challenge
                {
                    Console.WriteLine("Number must be between 1-10. Guess again: "); //instruct user to input a number between 1-10 while prompting user to guess again
            
                }

            }

            while(userInput > 0 && userInput <= 10) //while the condition is true
            {
                if (userInput == num) //if input equal num condition
                {
                    Console.WriteLine("Your guess was correct!"); //output correct guess
                    break; // end the condition
                }
                
                else //if user input an interger that does not meet the condition
                {
                    Console.WriteLine("You guessed wrong, guess again: "); //output incorrect answer while prompting user to input again
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
