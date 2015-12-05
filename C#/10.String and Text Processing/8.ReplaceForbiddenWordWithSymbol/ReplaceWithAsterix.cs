using System;

class ReplaceWithAsterix
{
    //We are given a string containing a list of forbidden words and a text containing some of these words. 
    //Write a program that replaces the forbidden words with asterisks


    static void Main()
    {
        string str = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        string[] forbidenWords = { "Microsoft", "CLR", " PHP " };
        int length = forbidenWords.Length;

        for (int i = 0; i < length; i++)
        {
            str = str.Replace(forbidenWords[i], new string('*', forbidenWords[i].Length));
        }
        Console.WriteLine(str);
    }
}