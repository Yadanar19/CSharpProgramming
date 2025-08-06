using System;

namespace Date_Time
{
    class Program
    {
        static void GetMonthInfo()
        {
            int currentMonth = DateTime.Now.Month; // initialize currentMonth variable
            Console.WriteLine("Current month: " + currentMonth); // output currentMonth variable

            int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); // initialize daysInMonth variable
            Console.WriteLine("Number of days in this month: " + daysInMonth); // output the daysInMonth variable

            DateTime currentDate = DateTime.Now; // get current date
            Console.WriteLine("Today's date: " + currentDate.ToString("MM-dd-yyyy")); // output today's date in MM-dd-yyyy format

            // Check if 2020 is a leap year
            bool isLeapYear = DateTime.IsLeapYear(2020);
            Console.WriteLine("Is 2020 a leap year? " + isLeapYear); // output if 2020 is a leap year
        }

        static void Main(string[] args)
        {
            GetMonthInfo(); // call the static method to get month info
        }
    }
}
