using System;

namespace Class_Object
{
    class Shapes //create class named Shapes with below properties
    {
        public double length;
        public double width; 

        private double CalArea(double l, double w)
        {
            length = l;
            width = w;
            double Area = w * l;
            return Area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double RecWidth = 7;
            double RecLength = 8;
            double SqWidth = 2;

            Shapes Rectangle = new Shapes(); //create instance/object of class shapes, named rectangle
            Shapes Square = new Shapes(); //create instance/object of class shapes, named square
            Shapes Circle = new Shapes();

            // Calculate and display area of rectangle
            Console.WriteLine("Area of Rectangle is: " + Rectangle.CalArea(RecLength, RecWidth)); 

            // Calculate and display area of square
            Console.WriteLine("Area of Square is: " + Square.CalArea(SqWidth, SqWidth)); 
        }
    }
}