using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ExpressionWithBrackets
{
    //Write a program to check if in a given expression the brackets are put correctly.
    //Example of correct expression: ((a+b)/5-d).
    //Example of incorrect expression: )(a+b)).

    static string expression(string example)
    {
        int count = 0;
        for (int i = 0; i < example.Length; i++)
        {
            if (example[i] == '(')
            {
                count++;
            }
            else if (example[i] == ')')
            {
                count--;
                if (count < 0)
                {
                    break;
                }
            }
            else
            {
                continue;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("Bracket are put correctly!");
        }
        else
        {
            Console.WriteLine("Brackets are not put correctly!");
        }
        return example;
    }
    static void Main()
    {
        string opit = "((a+b)/5-d).";
        Console.WriteLine(expression(opit));
    }
}

