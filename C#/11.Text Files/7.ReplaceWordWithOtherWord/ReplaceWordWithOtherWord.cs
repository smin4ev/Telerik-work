using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _7.ReplaceWordWithOtherWord
{
    //Write a program that replaces all occurrences of the substring "start" with 
    //the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).

    class ReplaceWordWithOtherWord
    {
        static void Main()
        {
            string input = @"..\..\text.txt";
            string output = @"..\..\text1.txt";

            StreamReader enterFileContent = new StreamReader(input);
            StreamWriter outputFileContent = new StreamWriter(output);

            string readTextFromInputFile = File.ReadAllText(input);
            Console.WriteLine("Input filecontent is:");
            Console.WriteLine(readTextFromInputFile);
            Console.WriteLine();

            using (enterFileContent)
            {
                string line = enterFileContent.ReadLine();
                using (outputFileContent)
                {
                    while (line != null)
                    {
                        string newLine = line.Replace("start", "finish");
                        line = enterFileContent.ReadLine();
                        outputFileContent.WriteLine(newLine);
                    }
                }
            }

            StreamReader print = new StreamReader(output);
            string outputContent = print.ReadToEnd();
            Console.WriteLine("Output file content is:");
            Console.WriteLine(outputContent);
        }
    }
}

