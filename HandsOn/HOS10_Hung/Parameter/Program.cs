using System;

namespace GenericType
{
    class Program
    {
        class StoreAnything <T, U> //declare class StoreAnything using generic type
        {
            public T var1 { set; get; }
            public U var2 { set; get; }
        }

        static void Main(string [] args)
        {
            StoreAnything<string, int> MyVar1 = new StoreAnything<string, int> { var1 = "CS", var2 = 131}; //create new object of StoreAnything class, passing string and int type

            Console.WriteLine(MyVar1.var1 + " " + MyVar1.var2); //print new values of var1 and var2
        }
    }
}