using System;
using System.Collections.Generic;
using System.Text;

class HexadecimalToDecimal
{
    // Write a program to convert hexadecimal numbers to their decimal representation

    static int ConvertHexadecimalToDecimal(string hexadecimal)
    {
        string temporary = "";
        int decimalNumber = 0;

        for (int i = 0; i < hexadecimal.Length; i++)
        {
            temporary = hexadecimal[i] + temporary;
        }
        for (int i = 0; i < temporary.Length; i++)
        {
            if (temporary[i] == 'A')
            {
                decimalNumber = decimalNumber + (int)(10 * Math.Pow(16, i));
            }
            else if (temporary[i] == 'B')
            {
                decimalNumber = decimalNumber + (int)(11 * Math.Pow(16, i));
            }
            else if (temporary[i] == 'C')
            {
                decimalNumber = decimalNumber + (int)(12 * Math.Pow(16, i));
            }
            else if (temporary[i] == 'D')
            {
                decimalNumber = decimalNumber + (int)(13 * Math.Pow(16, i));
            }
            else if (temporary[i] == 'E')
            {
                decimalNumber = decimalNumber + (int)(14 * Math.Pow(16, i));
            }
            else if (temporary[i] == 'F')
            {
                decimalNumber = decimalNumber + (int)(15 * Math.Pow(16, i));
            }
            else
            {
                decimalNumber = decimalNumber + (int)((Convert.ToInt32(new string(temporary[i], 1))) * Math.Pow(16, i));

            }
        }
          return decimalNumber;
    }

    static void Main()
    {
        Console.WriteLine("Enter hexadecimal number:");
        string hexadecimal = Console.ReadLine();
        Console.WriteLine(ConvertHexadecimalToDecimal(hexadecimal));   
    }
}