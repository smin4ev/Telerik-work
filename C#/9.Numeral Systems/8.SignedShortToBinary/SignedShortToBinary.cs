using System;
using System.Collections.Generic;
using System.Text;

class SignedShortToBinary
{
    //Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

    static void Main()
    {
        Console.WriteLine("Enter a signed short number:");
        short number = short.Parse(Console.ReadLine());
        short forTheFormating = number;
        string binaryNumber = "";
        if (number >= 0)
        {
            for (int i = number; i > 0; i = i / 2)
            {
                short reminder = (short)(number % 2);
                number = (short)(number / 2);
                binaryNumber = reminder.ToString() + binaryNumber;
            }
            while (binaryNumber.Length < 16)
            {
                binaryNumber = "0" + binaryNumber;
            }
        }
        if (number < 0)
        {
            number = (short)(Math.Abs(number) - 1);
            for (int i = number; i > 0; i=i/2)
            {
                short reminder = (short)(number % 2);
                number = (short)(number / 2);
                if (reminder == 0)
                {
                    reminder = 1;
                }
                else
                {
                    reminder = 0;
                }
                binaryNumber = reminder.ToString() + binaryNumber;
            }
            while (binaryNumber.Length < 16)
            {
                binaryNumber = "1" + binaryNumber;
            }
        }
        Console.WriteLine("Binary representation of {0} is {1}!",forTheFormating,binaryNumber );
    }
}

