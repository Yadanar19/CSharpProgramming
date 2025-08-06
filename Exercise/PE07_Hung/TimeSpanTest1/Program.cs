using System;

namespace TimeSpanTest1 {
    class Program{
        public static void Main() {
            //store reading time
            const int DAY=4, HRS =3, MIN=54, SEC=45; //reading value for days,hrs, min, & sec

            TimeSpan ts = new TimeSpan(DAY, HRS, MIN, SEC);//create TimeSpan object using the value for days,hours,mintues, and seconds
            Console.WriteLine(ts.Days + " days " 
                            + ts.Hours + " hours "
                            + ts.Minutes + " minutes "
                            + ts.Seconds + " seconds ");

            Console. WriteLine("TimeSpan in Days:       " + ts.TotalDays //output total time in days
                                                                .ToString("N1"));//format to 1 decimal
            Console.WriteLine("TimeSpan in Hours:       " + ts.TotalHours//output total time in hours
                                                                .ToString("N1"));//format to 1 decimal
            Console.WriteLine("TimeSpan in Minutes;     " + ts.TotalMinutes//output total time in minutes
                                                                .ToString("N1"));//format to 1 decimal
            Console.WriteLine("TimeSpan in Seconds:     " + ts.TotalSeconds);//output total time in seconds
            Console.ReadLine();
        }
    }
}