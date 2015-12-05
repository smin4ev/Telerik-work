using System;
using System.Collections.Generic;
using System.Text;

class DecimalToBinary
{
    //Write a program to convert decimal numbers to their binary representation

    static string ConvertDecimalToBinary(int decimalNumber)
    {
        string temporary = "";
        string binary = "";
       

        for (int i = decimalNumber; i > 0; i = i / 2)
        {
            int remainder = decimalNumber % 2;
            decimalNumber = decimalNumber / 2;
            temporary = temporary + remainder.ToString();
        }
        for (int i = temporary.Length - 1; i >= 0; i--)
        {
            binary = binary + temporary[i];
        }
        
        return binary;
    }

    static void Main()
    {
        Console.WriteLine("Enter decimal number:");
        int decimalNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(ConvertDecimalToBinary(decimalNumber));
    }
}

