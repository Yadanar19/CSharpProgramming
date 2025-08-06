using System;

namespace MyProgram
{
    class MyProgram
    {
        static void Main(string[] args)
        {
            string message1 = "Welcome to CS131"; //assign message1 variable to string 

            for (int i = 0; i < message1.Length; i++) //loop through string character in message1
            {
                if (i % 2 == 0) //check if the index is even
                {
                    Console.Write(message1[i]); //print character at even index
                }
            }
        }
    }
    
}