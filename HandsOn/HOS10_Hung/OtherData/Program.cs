using System;

namespace GenericType
{
    class Program
    {
        class StoreAnything <T> //declare class StoreAnything using generic type
        {
            public T var1 { set; get; }
        }


        static void Main(string[] args)
        {
            StoreAnything<string> MyVar1 = new StoreAnything<string> { var1 = "CS"}; //create a new object of StoreAnything class, passing string type
            StoreAnything<int> MyVar2 = new StoreAnything<int> { var1 = 131 }; //create another new object of StoreAnything class, passing int type

            Console.WriteLine(MyVar1.var1 + " " + MyVar2.var1); //print new values of var1
        }
    }
}