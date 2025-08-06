using System;
using System.Reflection.Metadata.Ecma335;

namespace MailStringTest
{
    class Program
    {
        static string CreateEmail(string firstname, string lastname) //create method to generate email
        {
            string email = (firstname[0] + lastname.Substring(0,3)).ToLower() + "@abc.com"; //concatenate 1st character of firstname & the first 3 character of lastname & add @abc.com at the end
            return email;
        }
        static void Main(string[] args)
        {
            string email1 = CreateEmail("Shane", "Wade"); //first email assign to a Shane Wade
            Console.WriteLine("1st email: " + email1); //display swad@abc.com

            string email2 = CreateEmail("Jantzen", "Bohannon"); //2nd email assign to Jantzen Bohannon
            Console.WriteLine("2nd email: " + email2); //display jboh@abc.com

            string email3 = CreateEmail("Tokyo", "Yuki"); //3rd email assign to Tokyo Yuki
            Console.WriteLine("3rd email: " + email3); //display tyuk@abc.com                    
        }
    }
}