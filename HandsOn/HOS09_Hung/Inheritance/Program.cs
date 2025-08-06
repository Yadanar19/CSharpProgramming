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
        }

        class Rectangle : Shapes // Rectangle class derived from shapes base class
        {
            public void CalArea(double l, double w)
            {
                length = l; 
                width = w;
                double RecArea = l * w;
                Console.WriteLine("Rectangle length is: " + length);
                Console.WriteLine("Rectangle width is: " + width);
                Console.WriteLine("Rectangle Area is: " + RecArea);
            }
        }

        class Square : Shapes //square class derived from Shapes base class
        {
            public void CalArea(double a)
            {
                length = a;
                double SqArea = a * a; // A square's area is side^2
                Console.WriteLine("Square side length is: " + a);
                Console.WriteLine("Square Area is: " + SqArea);
            }
        }

        class Circle : Shapes //Circle class derived from Shapes base class
        {
            public void CalArea(double r)
            {
                radius = r;
                double CirArea = 3.15 * r; // Corrected circle area formula
                Console.WriteLine("Circle radius is: " + radius);
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