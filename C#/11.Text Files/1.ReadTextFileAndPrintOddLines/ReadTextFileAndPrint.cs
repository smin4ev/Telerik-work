using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1.ReadTextFileAndPrintOddLines
{
    class ReadTextFileAndPrint
    {
       //Write a program that reads a text file and prints on the console its odd lines

        static void Main()
        {
            string fileName = @"..\..\text.txt";

            StreamReader stream = new StreamReader(fileName);
            
            using (stream)
            {
                int linesNumber = 1;
                string line = stream.ReadLine();
                while (line != null)
                {
                    if (linesNumber % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    linesNumber++;
                    line = stream.ReadLine();
                }
            }
        }
    }
}
