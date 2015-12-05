using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _9.DeleteOddLines
{
    // Write a program that deletes from given text file all odd lines. The result should be in the same file.

    class DeleteOddLines
    {
        static void Main()
        {
            string file = @"..\..\text.txt";
            StreamReader fileContent = new StreamReader(file);
            
            List<string> newContent = new List<string>();


            using (fileContent)
            {
                int numberOfLine = 1;
                string line = fileContent.ReadLine();
                while (line != null)
                {
                    if (numberOfLine % 2 == 0)
                    {
                        newContent.Add(line);
                    }
                    numberOfLine++;
                    line = fileContent.ReadLine();
                }
            }
            StreamWriter exitContent = new StreamWriter(file);
            using (exitContent)
            {
                for (int i = 0; i < newContent.Count; i++)
                {
                    exitContent.WriteLine(newContent[i]);
                }
            }
        }
    }
}
