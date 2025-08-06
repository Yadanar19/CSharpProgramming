using System;

namespace RefValTest {
    class Program {
        static void Main() {
            //Declare & initialize 2 float variables for gas & price
            float TotalGas           = 5.0f; // gas amount in gallons
            float GasPrice       = 2.56f; //gas price per gallon

            //Explicitly pass variables by reference
            FuelingGas(ref TotalGas, ref GasPrice);

            //Output values after fueling gas
            Console.WriteLine("** Values After Fueling Gas **");
            Console.WriteLine("Total Gas: " + TotalGas + " gallons");
            Console.WriteLine("Price per gallon: " + GasPrice + " per gallons");
            Console.ReadLine();
        }
        //Receive arguments explicitly by reference.
        static void FuelingGas(ref float addgas, ref float price) {
            const float RATE = 3.0f;
            addgas    *= RATE; //increase gas amount
            price  *= RATE; //increase price per gallon
        }
    }
}
