using System;

namespace WarnLevelTest
{
    class Program
    {
        // Define constants to store traffic lights
        const int Red = 0, Yellow = 1, Green = 2;

        public static void Main()
        {
            //Call overload method with boolean parameter
            TestTrafficLight(Red, true);    //True: Display warning for red light
            TestTrafficLight(Yellow, false); //False: Do not display warning for yellow light
            TestTrafficLight(Green, true);  //True: Display warning for green light
            TestTrafficLight(99,false);     //False: Do not display warning for default light
        }

        // Define a method that takes one integer input argument
        public static void TestTrafficLight(int lightState) 
        {
            // If...else statement to check different traffic light states
            if (lightState == Red)
            {
                Console.WriteLine("Red: Stop, it's not safe to drive.");
            }
            else if (lightState == Yellow)
            {
                Console.WriteLine("Yellow: Drive with caution.");
            }
            else if (lightState == Green)
            {
                Console.WriteLine("Green: Go, it's safe to drive.");
            }
            else
            {
                Console.WriteLine("Unknown light state: Lighting is changing.");
            }
        }
        //Overload method to with boolean parameter to control warning display
        public static void TestTrafficLight(int lightState, bool displayWarning)
        {
            //condition using logical AND and OR
            if (displayWarning && lightState == Red)
            {
                Console.WriteLine("Red: Stop, it's not safe to drive.");
            }
            else if (displayWarning && lightState == Green)
            {
                Console.WriteLine("Green: Go, it's safe to drive.");
            }
            else if (!displayWarning && (lightState == Yellow || lightState == 99)) // False for Yellow and Unknown
            {
                Console.WriteLine("No warning: No need to display for Yellow or Unknown state.");
            }
            else
            {
                Console.WriteLine("No warning to display.");
            }
        }
    }
}