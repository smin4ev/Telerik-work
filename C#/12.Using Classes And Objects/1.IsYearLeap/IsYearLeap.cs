using System;
using System.Collections.Generic;

class IsYearLeap
{
    //Write a program that reads a year from the console and checks whether it is a leap. Use DateTime

    static void Main()
    {
        Console.WriteLine("Enter a year:");
        int year = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(year);
        Console.WriteLine(isLeap);
    }
}

