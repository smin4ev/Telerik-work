using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class SubstringInText
{
    //Write a program that finds how many times a substring is contained 
    //in a given text (perform case insensitive search).
    //Example: The target substring is "in". The text is as follows:
    //index = str.ToLower().IndexOf("COURSE".ToLower()); // 18

    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        int index = -1;
        int count = 0;
        while (true)
        {
            index = text.ToLower().IndexOf("in", index + 1);
            if (index == -1)
            {
                break;
            }
            count++;
        }
        Console.WriteLine(count);
    }
}

