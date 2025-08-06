using System;

namespace Class_Object
{
    class Shapes //create class named Shapes with below properties
    {
        public double length;
        public double width;
        public double radius;

        public double CalArea(double l, double w)
        {
         length = l;
         width = w;
         double Area = width * l;
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

            Shapes Rectangle = new Shapes(); // Creat instance/object of class Shapes, named Rectangle
            Shapes Square = new Shapes(); //Create instance/object of class Shapes, named Square

            Console.WriteLine("Area of Rectangle is: " + Rectangle.CalArea(RecLength,RecWidth)); //use object rectangle to call method CalArea of class Shapes

            Console.WriteLine("Area of Square is: " + Square.CalArea(SqWidth,SqWidth)); //use object Square to call method CalArea of class Shapes

        }
    }
}