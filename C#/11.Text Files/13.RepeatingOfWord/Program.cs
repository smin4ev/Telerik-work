using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
class Program
{
    //Write a program that reads a list of words from a file words.txt and finds how many times each of 
    //the words is contained in another file test.txt. The result should be written in the file result.txt 
    //and the words should be sorted by the number of their occurrences in descending order. 
    //Handle all possible exceptions in your methods.



    static void Main(string[] args)
    {
        try
        {
            string[] words = File.ReadAllLines(@"..\..\words.txt");
            string[] test = File.ReadAllLines(@"..\..\test.txt");
            string outPut = "";

            foreach (var word in words)
            {
                outPut += "\"" + word + "\" :";
                int count = 0;
                foreach (var item in test)
                {
                    if (item == word)
                    {
                        count++;
                    }
                }
                outPut += count + "\r\n";
            }
            File.WriteAllText(@"..\..\result.txt", outPut);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (SecurityException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}