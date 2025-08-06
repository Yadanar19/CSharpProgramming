using System;

namespace BirthdayTest
{
    class Program
    {
        static void Main()
        {
            //Define the birthdate
            const int YR = 2005, MTH = 03, DAY = 26, HRS = 12, MIN = 00, SEC = 00;
            DateTime birthday = new DateTime(YR, MTH, DAY, HRS, MIN, SEC);

            //Output full details of the birthdate
            ShowDateTime(birthday);

            //Output the birthdate in long date format
            Console.WriteLine("\nYour Birthdate in Long Date Format: " + birthday.ToLongDateString());

            Console.ReadLine();
        }

        static void ShowDateTime(DateTime dt)
        {
            // Displaying individual components of the DateTime object
            Console.Write("Year: " + dt.Year);
            Console.Write(" Month: " + dt.Month);
            Console.WriteLine(" Day: " + dt.Day);
            Console.Write("DayOfWeek: " + dt.DayOfWeek);
            Console.WriteLine(" DayOfYear: " + dt.DayOfYear);
            Console.Write("Hours: " + dt.Hour);
            Console.Write(" Minutes: " + dt.Minute);
            Console.WriteLine(" Seconds: " + dt.Second);
        }
    }
}
