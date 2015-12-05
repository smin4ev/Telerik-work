using System;
using System.Text;

class ReadString
{
    //Write a program that reads from the console a string of maximum 20 characters. 
    //If the length of the string is less than 20,
    //the rest of the characters should be filled with '*'. Print the result string into the console

    static void Main()
    {
        Console.Write("Please enter string with no more than 20 characters!");
        string text = Console.ReadLine();

        if (text.Length > 20)
        {
            Console.WriteLine("No more than 20 characters, please!");
        }
        else
        {
            StringBuilder twentyChars = new StringBuilder();
            twentyChars.Append(text);
            while (twentyChars.Length < 20)
            {
                twentyChars.Append('*');
            }
            Console.WriteLine("The changed text is:{0}", twentyChars.ToString());
        }
    }
}