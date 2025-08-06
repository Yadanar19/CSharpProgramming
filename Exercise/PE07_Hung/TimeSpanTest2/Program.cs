using System;

namespace Date_Time
{
    class Program
    {
        // Method to create the TimeSpan for weekly programming time
        static void WeeklyProgramming()
        {
            // Define programming time (example: 6 days, 7 hours, 30 minutes, 32 seconds)
            TimeSpan programmingTime = new TimeSpan(6, 7, 30, 32); // 6 days, 7 hours, 30 minutes, 32 seconds

            // Output weekly programming time
            Console.WriteLine("Weekly Programming Time: " + programmingTime.Days + " days " 
                               + programmingTime.Hours + " hours " 
                               + programmingTime.Minutes + " minutes ");
        }

        // Method to create the TimeSpan for weekly testing time
        static void WeeklyTesting()
        {
            // Define testing time (example: 5 days, 5 hours, 45 minutes, 52 seconds)
            TimeSpan testingTime = new TimeSpan(5, 5, 45, 52); // 6 days, 7 hours, 45 minutes, 52 seconds

            // Output weekly testing time
            Console.WriteLine("Weekly Testing Time: " + testingTime.Days + " days " 
                               + testingTime.Hours + " hours " 
                               + testingTime.Minutes + " minutes ");
        }

        // Method to calculate and display the total development time and comparison
        static void TotalDevelopmentTime()
        {
            // Define programming time and testing time
            TimeSpan programmingTime = new TimeSpan(6, 7, 30, 32); // 6 days, 7 hours, 30 minutes, 32 seconds
            TimeSpan testingTime = new TimeSpan(5, 5, 45, 52); // 5 days, 5 hours, 45 minutes, 52 seconds

            // Add the two TimeSpan objects to get the total development time
            TimeSpan totalDevelopmentTime = programmingTime + testingTime;

            // Output total development time
            Console.WriteLine("\nTotal Development Time: " + totalDevelopmentTime.Days + " days " 
                               + totalDevelopmentTime.Hours + " hours " 
                               + totalDevelopmentTime.Minutes + " minutes ");

            // Compare the programming time and testing time
            if (programmingTime > testingTime)
            {
                Console.WriteLine("\nProgramming took more time this week.");
            }
            else if (programmingTime < testingTime)
            {
                Console.WriteLine("\nTesting took more time this week.");
            }
            else
            {
                Console.WriteLine("\nProgramming and Testing took the same amount of time this week.");
            }
        }

        static void Main(string[] args)
        {
            WeeklyProgramming(); // Output weekly programming time
            WeeklyTesting(); // Output weekly testing time
            TotalDevelopmentTime(); // Output total development time and comparison
        }
    }
}
