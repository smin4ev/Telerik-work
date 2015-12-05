using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3.NumerationOfLinesInNewFile
{
    class NumerationOfLines
    {
        //Write a program that reads a text file and inserts line numbers in front of each of its lines. 
        //The result should be written to another text file.


        static void Main()
        {
            string enterFile = @"..\..\text.txt";
            string exitFile = @"..\..\text1.txt";

            StreamReader fileContentEnter = new StreamReader(enterFile);
            StreamWriter fileContentExit = new StreamWriter(exitFile);

            using (fileContentEnter)
            {
                string line = fileContentEnter.ReadLine();
                int numberOfLine = 1;
                using (fileContentExit)
                {
                    while (line != null)
                    {

                        fileContentExit.WriteLine("Line {0}:{1}", numberOfLine, line);
                        numberOfLine++;
                        line = fileContentEnter.ReadLine();

                    }
                }
            }
        }
    }
}
