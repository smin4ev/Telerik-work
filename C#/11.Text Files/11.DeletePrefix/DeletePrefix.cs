using System;
using System.IO;
using System.Text.RegularExpressions;


class ContainTest
{
    //Write a program that deletes from a text file all words that start with the
    //prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.


    static void Main()
    {
        string fileContent = File.ReadAllText(@"..\..\text.txt");
        File.WriteAllText(@"..\..\text1.txt", Regex.Replace(fileContent, @"\b(test\w*)\b", String.Empty));
        Console.WriteLine("Replace Complete!");
    }
}
