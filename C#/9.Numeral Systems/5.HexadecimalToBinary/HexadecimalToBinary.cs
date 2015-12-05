using System;
using System.Collections.Generic;


class HexadecimalToBinary
{
    // Write a program to convert hexadecimal numbers to binary numbers (directly).
    static string ConvertHexidecimalToBInary(string hexadecimal)
    {
        string hexToBinary = "";
        for (int i = 0; i < hexadecimal.Length; i++)
        {

            string number = hexadecimal[i].ToString();
            switch (number)
            {
                case "A":
                    number = "10";
                    break;
                case "B":
                    number = "11";
                    break;
                case "C":
                    number = "12";
                    break;
                case "D":
                    number = "13";
                    break;
                case "E":
                    number = "14";
                    break;
                case "F":
                    number = "15";
                    break;
            }
            int numberFromHex = int.Parse(number);
            string temporary = "";
            for (int j = numberFromHex; j > 0; j = j / 2)
            {
                int remainder = numberFromHex % 2;
                numberFromHex = numberFromHex / 2;
                temporary = remainder.ToString() + temporary;
            }
            if (i != 0 & temporary.Length < 4)
            {
                while (temporary.Length < 4)
                {
                    temporary = "0" + temporary;
                }
            }
            hexToBinary = hexToBinary + temporary;
        }
        return hexToBinary;
    }
    
    

    static void Main()
    {
        Console.WriteLine("Enter hexidecimal number:");
        string hexadecimal = Console.ReadLine();
        Console.WriteLine(ConvertHexidecimalToBInary(hexadecimal));
    }
}
