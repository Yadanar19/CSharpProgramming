using System;

namespace BinaryOperatorsTest 
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100; //assign the value 100 to a
            int b = 20; //assign the value 20 to b

            //add a + b 
            a += b;
            Console.WriteLine("The value of a is now:{0}", a); //print and output the sum while assigning the answer value to a
            //subtract a -b
            a -= b;
            Console.WriteLine("The value of a is now:{0}", a); //print and output the sum while assigning the answer value to a
            //multiply a * b
            a *= b;
            Console.WriteLine("The value of a is now:{0}", a); //print and output the sum while assigning the answer value to a
            //divide a / b
            a /= b;
            Console.WriteLine("The value of a is now:{0}", a); //print and output the sum while assigning the answer value to a
            //remainder of a /b
            a %= b;
            Console.WriteLine("The value of a is now:{0}", a); //print and output the sum while assigning the answer value to a
        }
    }
}