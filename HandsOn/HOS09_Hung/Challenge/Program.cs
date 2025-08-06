using System;

namespace Inheritance
{
    class Program
    {
        class Shapes //create class name Shapes with below properties
        {
            public double length;
            public double width;
            public double radius;

            // Function to print properties of the shape
            public void PrintProperties()
            {
                Console.WriteLine("Length is: " + length);
                Console.WriteLine("Width is: " + width);
                Console.WriteLine("Radius is: " + radius);
            }
        }

        class Rectangle : Shapes // Rectangle class derived from shapes base class
        {
            public void CalArea(double l, double w)
            {
                length = l; 
                width = w;
                double RecArea = l * w;
                PrintProperties(); // Call the PrintProperties function to display properties
                Console.WriteLine("Rectangle Area is: " + RecArea);
            }
        }

        class Square : Shapes //square class derived from Shapes base class
        {
            public void CalArea(double a)
            {
                length = a;
                PrintProperties(); // Call the PrintProperties function to display properties
                double SqArea = a * a; // A square's area is side^2
                Console.WriteLine("Square Area is: " + SqArea);
            }
        }

        class Circle : Shapes //Circle class derived from Shapes base class
        {
            public void CalArea(double r)
            {
                radius = r;
                PrintProperties(); // Call the PrintProperties function to display properties
                double CirArea = 3.15 * r; // Using the approximation for circle area as you originally had
                Console.WriteLine("Circle Area is: " + CirArea);
            }
        }

        static void Main(string[] args)
        {
            Rectangle MyRec = new Rectangle(); //object MyRec of class rectangle
            Circle MyCir = new Circle(); //object MyCir of class Circle
            Square MySq = new Square(); //object MySq of class Square

            Console.WriteLine("Base Length is " + MyRec.length);
            Console.WriteLine("Base width is " + MyRec.width);
            Console.WriteLine("Base radius is " + MyCir.radius);
            Console.WriteLine("\n"); //jump to next line

            MyRec.CalArea(3, 4); // Calculate and display the area of Rectangle
            Console.WriteLine("\n"); //jump to next line

            MySq.CalArea(10); // Calculate and display the area of Square
            Console.WriteLine("\n"); //jump to next line

            MyCir.CalArea(8); // Calculate and display the area of Circle
        }
    }
}
