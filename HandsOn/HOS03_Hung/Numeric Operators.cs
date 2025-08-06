using System;

namespace NumericOperators 
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20; //assign an interger value to num1
            int num2 = 77; //assign an interger value to num2
            float num3 = 5.2f; //assign a decimal value to num3

            float sum = num1 + num2 + num3; //output a float value by adding all the 3 variables
            int subtract = num2 - num1; //output the subtraction of num2 value and num1
            int multiply = num1 * num2; //output the multiplication of num1 & num2
            float divide = num1 / num3; //output the division of num1 and num3
            int modulus = num2 % num1; //output the remainder of the divsion of num2 and num1

            Console.WriteLine("Sum of 3 number is: " + sum); //display command of strings and the total variale of 3 numbers
            Console.WriteLine("77 - 20 is: " + subtract); //display command of strings and the subtraction variale of subtract
            Console.WriteLine("20 * 77 is: " + multiply); //display command of strings and the variable of multiply
            Console.WriteLine("20 / 5.2 is: " + divide); //display command of strings and the variable of divide
            Console.WriteLine("77 % 20 is: " + modulus); //display command of strings and the variable modulus
        }
    }
}