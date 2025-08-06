using System;

namespace GetPersonalInfo
{
    class Program
    {
        void GetPersonalInfo()
        {
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("What year were you born?: ");
            int birthyear = Convert.ToInt32(Console.ReadLine());
            int age = (Convert.ToInt32(DateTime.Now.Year) - birthyear);

            Console.WriteLine("Here's what we know from your inputs: ");
            Console.WriteLine("Your name: " + name);
            Console.WriteLine("Today is: " + DateTime.Now.ToShortDateString());
            Console.WriteLine("Your age: " + age);
        }
        static void Main(string[] args)
        {
            Program MyProgram = new Program();
            MyProgram.GetPersonalInfo();
        }
    }
}