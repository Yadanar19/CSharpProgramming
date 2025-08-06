using System;

namespace ExpressionsTest 
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100; //assign an interger value to a
            int b = 20; //assign an interger value to b
            

            int sum = a + b; //output total sum of the variables
            int subtract = a - b; //output the subtraction of a-b
            int multiply = a * b; //output the multiplication of a * b
            int divide = a / b; //output the division of a / b
            int modulus = a % b; //output the remainder of a / b

            Console.WriteLine("{0} + {1} = {2}", a, b, a + b); //display the variable & sum of a + b
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b); //display the variable & subtraction of a - b answer
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b); //display the variable & multiplication of a * b answer
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b); //display the variable & division of a / b answer
            Console.WriteLine("{0} % {1} = {2}", a, b, a % b); //display the variable & modulus/remainder of a / b
        }
    }
}
