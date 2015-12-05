using System;
using System.Collections.Generic;


class WhichDayIsToday
{
    //Write a program that prints to the console which day of the week is today. Use System.DateTime

    static void Main()
    {
        string whichDayIsToday = DateTime.Now.DayOfWeek.ToString();
        Console.WriteLine("Today is {0}!", whichDayIsToday);
    }
}

