using System;

namespace GenericType
{
    class Program
    {
        class StoreAnything <T, U, C>//clare class StoreAnything using generic type
        {
            public T var1 { set; get; }
            public U var2 { set; get; }
            public C var3 { set; get; }
        }

        static void Main(string [] args)
        {
             StoreAnything<string, int, string> MyVar1 = new StoreAnything<string, int, string> { var1 = "CS", var2 = 1131, var3= "!" };

            Console.WriteLine(MyVar1.var1 + " " + MyVar1.var2 + MyVar1.var3); //print new value of var1, var2, var3
        }
    }
}