using System;

namespace Class_Object
{
    class Shapes // Create class named Shapes with below properties
    {
        public double length;
        public double width;
        public double radius;

        // Method to calculate the area of a circle
        public double CalCircleArea(double r)
        {
            radius = r;
            double Area = 3.15 * radius * radius;  // Using Pi = 3.15
            return Math.Round(Area, 2); // Round to 2 decimal places
        }

        // Method to calculate the area of a rectangle
        public double CalRectangleArea(double l, double w)
        {
            length = l;
            width = w;
            double Area = length * width;  // Area of rectangle
            return Area;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Rectangle and square dimensions
            double RecWidth = 7;
            double RecLength = 8;
            double SqWidth = 2;

            // Create instances/objects of class Shapes
            Shapes Rectangle = new Shapes(); 
            Shapes Square = new Shapes();
            Shapes Circle = new Shapes(); // Create object for Circle

            // Calculate and display area of rectangle
            Console.WriteLine("Area of Rectangle is: " + Rectangle.CalRectangleArea(RecLength, RecWidth)); 

            // Calculate and display area of square
            Console.WriteLine("Area of Square is: " + Square.CalRectangleArea(SqWidth, SqWidth)); 

            // Calculate and display area of circle
            double circleRadius = 3; // Radius of circle
            Console.WriteLine("Area of Circle is: " + Circle.CalCircleArea(circleRadius)); // Call CalCircleArea() for the circle
        }
    }
}
