using System;
using System.Collections.Generic;
using System.Text;

class BinaryToHexadecimal
{
    //Write a program to convert binary numbers to hexadecimal numbers (directly).

    static void Main()
    {
        Console.WriteLine("Enter binary number:");
        string binary = Console.ReadLine();
        string binaryToHex = "";

        while (binary.Length % 4 != 0)
        {
            binary = "0" + binary;
        }

        for (int i = 0; i < binary.Length; i = i + 4)
        {
            string sumatorOfBinaryDigits = "";
            string temporarSumatorOfHex = "";
            int sum = 0;
            for (int j = i; j <=i + 3; j++)
            {
                sumatorOfBinaryDigits = binary[j] +sumatorOfBinaryDigits;
            }
            for (int j = 0; j < sumatorOfBinaryDigits.Length; j++)
            {
                sum = sum +int.Parse(sumatorOfBinaryDigits[j].ToString()) * (int)Math.Pow(2, j);
            }
            switch (sum)
            {
                case 10:
                    temporarSumatorOfHex = "A";
                    break;
                case 11:
                    temporarSumatorOfHex = "B";
                    break;
                case 12:
                    temporarSumatorOfHex = "C";
                    break;
                case 13:
                    temporarSumatorOfHex = "D";
                    break;
                case 14:
                    temporarSumatorOfHex = "E";
                    break;
                case 15:
                    temporarSumatorOfHex = "F";
                    break;
                default:
                    temporarSumatorOfHex = sum.ToString();
                    break;
            }
            binaryToHex = binaryToHex + temporarSumatorOfHex;
        }
        Console.WriteLine(binaryToHex);
    }
}

