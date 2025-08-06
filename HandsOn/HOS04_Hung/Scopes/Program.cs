using System;

namespace Scope
{
    class Program
    {
        public static string? Str2; //static string delcared at class level while declaring nullable
        
        static void ReturnString(string Str1) // Method take string parameter & assign value to Str2
        {
            Str2 = "Programming in C#"; //Assign a message to Str2 

            Console.Write(Str1); //output string parameter 
        }


        static void Main(string[] args)
        {
            ReturnString("CS131 "); //call the method and pass a string argument
            Console.WriteLine(Str2); //ouput the message of Str2

        }
    }
}