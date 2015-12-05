using System;
using System.Collections.Generic;

class Program
{
   //Write a program to convert binary numbers to their decimal representation

    static void ConvertBinaryToDecimal(string binaryNumber)
    {
        string temporary = "";
        int decimalNumber = 0;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            temporary = binaryNumber[i].ToString() + temporary;
        }
        for (int i = 0; i < temporary.Length; i++)
        {
            if (temporary[i] == '1')
            {
                decimalNumber = decimalNumber + (int)Math.Pow(2, i);
            }
        }
        Console.WriteLine(decimalNumber);
    }

    static void Main()
    {
        Console.WriteLine("Enter a binary number:");
        string number = Console.ReadLine();
        ConvertBinaryToDecimal(number);
    }
}

