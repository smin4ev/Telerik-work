using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6.SortListOfStrings
{
    class SortListOfStrings
    {
        //Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
        //Ivan			George
        //Peter			Ivan
        //Maria			Maria
        //George	    Peter


        static void Main()
        {      
            string file = @"..\..\text.txt";

            StreamReader stream = new StreamReader(file);
            List<string> contentOfFile = new List<string>();
            using (stream)
            {
                string line = stream.ReadLine();
                while (line != null)
                {
                    contentOfFile.Add(line);
                    line = stream.ReadLine();
                }
            }
            foreach (string name in contentOfFile)
            {
                Console.WriteLine(name);
            }
            contentOfFile.Sort();

            string sortFile = @"..\..\text1.txt";
            StreamWriter sort = new StreamWriter(sortFile);
            using (sort)
            {
                foreach(string name in contentOfFile)
                sort.WriteLine(name);
            }
        }
    }
}
