using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ChangeTextBetweenTags
{
    //You are given a text. Write a program that changes the 
    //text in all regions surrounded by the tags <upcase> and </upcase> to uppercase.
    //The tags cannot be nested

    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        int openTag = text.IndexOf("<upcase>");
        int closeTag = text.IndexOf("</upcase>");
        StringBuilder first = new StringBuilder();
        for (int i = openTag + 8; i < closeTag; i++)
        {
            first.Append(text[i]);
        }
        string primery = first.ToString();
        string change = first.ToString().ToUpper();
        string smallFinal = text.Replace(primery, change);

        int openTagSecond = text.IndexOf("<upcase>", closeTag);
        int closeTagSecond = text.IndexOf("</upcase>", openTagSecond);
        StringBuilder second = new StringBuilder();
        for (int i = openTagSecond + 8; i < closeTagSecond; i++)
        {
            second.Append(text[i]);
        }
        string primerySecond = second.ToString();
        string secondChange = second.ToString().ToUpper();
        string mediumFinal = smallFinal.Replace(primerySecond, secondChange);

        string proba = mediumFinal.Replace("<upcase>", "");
        string bigfinal = proba.Replace("</upcase>", "");
        Console.WriteLine(bigfinal);
    }
}

