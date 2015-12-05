using System;
using System.Collections.Generic;
using System.Text;


class FromAnyToAnyNumeralSystem
{
    //Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).


    static void Main()
    {
        Console.WriteLine("Enter a numeral system for convert (2 <= input <= 16)");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a numeral system in which to convert( 2 <= output <= 16 ):");
        int output = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number for conversion:");
        string numberForConver = Console.ReadLine();
        int numberInDecimalSystem = 0;
        for (int i = numberForConver.Length - 1; i >= 0; i--)
        {
            numberInDecimalSystem = numberInDecimalSystem + int.Parse(numberForConver[i].ToString()) * (int)Math.Pow(input, numberForConver.Length - 1 - i);
        }
        string numberInOutput = "";
        for (int i = numberInDecimalSystem; i > 0; i = i/output)
        {
            string reminder = (numberInDecimalSystem % output).ToString();
            numberInDecimalSystem = numberInDecimalSystem / output;
            switch (reminder)
            {
                case "10":
                    reminder = "A";
                    break;
                case "11":
                    reminder = "B";
                    break;
                case "12":
                    reminder = "C";
                    break;
                case "13":
                    reminder = "D";
                    break;
                case "14":
                    reminder = "E";
                    break;
                case "15":
                    reminder = "F";
                    break;
            }
            numberInOutput = reminder + numberInOutput;

        }
        Console.WriteLine(numberInOutput);

       
    }
}

