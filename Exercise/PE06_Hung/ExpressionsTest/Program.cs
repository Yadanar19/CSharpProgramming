using System;

namespace ExpressionsTest 
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt user to input
            Console.WriteLine("Enter the value for a:");
            int a = Convert.ToInt32(Console.ReadLine()); //Initialized user input for a and convert it to integer

            Console.WriteLine("Enter the value for b:");
            int b = Convert.ToInt32(Console.ReadLine()); //Initialized user input for b and convert it to integer

            //Output total sum of the variables
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b); //Display sum of a + b
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b); //Display subtraction of a - b
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b); //Display multiplication of a * b

            //Division by zero case
            if (b != 0)
            {
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b); //Display division of a / b
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed."); //Display error message if division by zero
            }

            Console.WriteLine("{0} % {1} = {2}", a, b, a % b); //Display modulus/remainder of a % b
        }
    }
}