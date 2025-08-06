using System;

namespace CompareStringTest
{
    class Program
    {
        static bool CompareStringTest(string str1, string str2)
        {
            if (str1.ToUpper() == str2.ToUpper())
            {
                return true; //the string match
            }
            else 
            {
                return false; //the string does not match
            }
        }
        static void Main(string[] args)
        {
            string str1 = "World"; //initiate 1st string
            string str2 = "world"; //initiate 2nd string
            bool res1 = CompareStringTest(str1, str2); //compare 1st & 2nd string

            if (res1)
            {
                Console.WriteLine($"The strings \"{str1}\" and \"{str2}\" match (case-insensitive)."); //if the condition is met display match
            }
            else
            {
                Console.WriteLine($"The strings \"{str1}\" and \"{str2}\" do not match."); //if the condition is not met display do not match
            }

            string str3 = "World"; //initiate 3rd string
            string str4 = "Ending"; //initiate 4th string
            bool res2 = CompareStringTest(str3, str4); //compare 3rd & 4th string

            if(res2)
            {
                Console.WriteLine($"The strings \"{str3}\" and \"{str4}\" match (case-insensitive)."); //if the condition is met display match
            }
            else 
            {
                Console.WriteLine($"The strings \"{str3}\" and \"{str4}\" do not match."); //if the condition is not met display do not match
            }
        }
    }
}