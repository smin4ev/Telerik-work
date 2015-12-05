using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ReverseString
{
    //Write a program that reads a string, reverses it and prints the result at the console.
    //Example: "sample"  "elpmas".

    static string reverseString(string example)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = example.Length - 1; i >= 0; i--)
        {
            sb.Append(example[i]);
        }
        return sb.ToString();
    }

    static void Main()
    {
        string trial = "sample";
        Console.WriteLine(reverseString(trial));

    }
}

