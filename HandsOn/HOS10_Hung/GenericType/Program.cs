using System;

namespace GenericType
{
    class Program
    {
        class StoreInt //class StoreInt has 2 integers, with set and get functions set to each variable
        {
            public int num1 { set; get; }
            public int num2 { set; get; }
        }

        class StoreString //class StoreString has 2 strings, with set and get functions set to each variable
        {
            public string strg1 { set; get; }
            public string strg2 { set; get; }
        }
        
        static void Main(string [] args)
        {
            StoreInt MyInt = new StoreInt { num1 = 1, num2 = 3 }; // creat new object of StoreINt class
            StoreString MyStrg = new StoreString { strg1 = "CS" , strg2 = "131" }; //create new object of StoreString class

            Console. WriteLine(MyInt.num1 + "," + MyInt.num2); //print new values
            Console.WriteLine(MyStrg.strg1 + " " + MyStrg.strg2); //print new 
        }
    }
}