using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4.ComparesLineOfTextFiles
{
    class ComparesLineOfTextFiles
    {
        //Write a program that compares two text files line by line and prints the number of lines 
        //that are the same and the number of lines that are different. Assume the files have equal number of lines.



        static void Main()
        {
            string firstFile = @"..\..\text.txt";
            string secondFile = @"..\..\text1.txt";

            StreamReader firstStream = new StreamReader(firstFile);
            StreamReader secondStream = new StreamReader(secondFile);

            List<int> sameLines = new List<int>();
            List<int> differentLines = new List<int>();
            using (firstStream)
            {
                using (secondStream)
                {

                    string firstStreamLine = firstStream.ReadLine();
                    string secondStreamline = secondStream.ReadLine();
                    int numberOfLine = 1;
                    while (firstStreamLine != null)
                    {
                        if (firstStreamLine == secondStreamline)
                        {
                            Console.WriteLine("{0} - same lines ", numberOfLine);
                            sameLines.Add(numberOfLine);
                        }
                        else 
                        {
                            Console.WriteLine("{0} - different lines ", numberOfLine);
                            differentLines.Add(numberOfLine);
                        }
                        numberOfLine++;
                        firstStreamLine = firstStream.ReadLine();
                        secondStreamline = secondStream.ReadLine();

                    }                       
                }
                Console.WriteLine("Equal lines are:{0}", string.Join("," , sameLines ));
                Console.WriteLine("Different lines are:{0}", string.Join(",", differentLines));
            }
        }
    }
}
