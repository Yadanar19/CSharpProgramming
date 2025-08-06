using System;

namespace NumOutTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 987654.321d; //define double variable of 987654.321d
            Console.WriteLine("With two decimal points: " + num.ToString("F2")); //display variable up to 2 decimal points
            Console.WriteLine("As an integer: " + num.ToString("F0")); //display variable as an interger (whole #)
            Console.WriteLine("As a currency value: " + num.ToString("C")); //display variable in currency value
        }
    }
}