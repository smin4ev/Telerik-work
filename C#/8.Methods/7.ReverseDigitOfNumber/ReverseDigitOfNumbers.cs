using System;

public class Program
{
    //Write a method that reverses the digits of given decimal number. Example: 256  652

    public static decimal ReverseDigitOfNumber(decimal number)
    {
        string output = "";
        string numberToString = number.ToString();
        for (int i = numberToString.Length-1; i >= 0; i--)
        {
            output = output + numberToString[i];
        }
        decimal outputAsNumber = decimal.Parse(output);
        return outputAsNumber;
        
    }

    static void Main()
    {
        Console.WriteLine("Enter a decimal number:");
        decimal number = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Reversed number is:");
        Console.WriteLine(ReverseDigitOfNumber(number));
    }
}

