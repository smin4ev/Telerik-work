using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10.ExtractFromFile
{
    //Write a program that extracts from given XML file all the text without the tags. Example:
    //<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest> Games</instrest>
    //<interest>C#</instrest><interest> Java</instrest></interests></student>



    class ExtractFromFile
    {
        static void Main()
        {
            string content = @"..\..\text.txt";

            StreamReader inputFile = new StreamReader(content);
            using (inputFile)
            {
                string line = inputFile.ReadLine();
                StringBuilder freeText = new StringBuilder();
                while (line != null)
                {
                    for (int i = 0; i < line.Length-1; i++)
                    {
                        if (line[i] == '>')
                        {
                            while (line[i+1] != '<')
                            {
                                freeText.Append(line[i+1]);
                                i++;
                            }
                            if (freeText.ToString() != "")
                            {
                                Console.WriteLine(freeText);
                                freeText.Clear();
                            }
                        }
                    }
                    line = inputFile.ReadLine();
                }
            }
        }
    }
}
