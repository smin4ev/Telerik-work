using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2.ConcatTwoTextFiles
{
    //Write a program that concatenates two text files into another text file.

    class ConcatTwoTextFiles
    {
        static void Main(string[] args)
        {
            string firstFile = @"..\..\text.txt";
            string secondFile = @"..\..\text1.txt";
            string finalFile = @"..\..\text2.txt";

            StreamReader firstStream = new StreamReader(firstFile);
            StreamReader secondStream = new StreamReader(secondFile);

            string firstStreamContent = firstStream.ReadToEnd();
            string secondStreamContent = secondStream.ReadToEnd();

            

            StreamWriter final = new StreamWriter(finalFile);
            using (final)
            {
                final.WriteLine(firstStreamContent +"\r\n"+ secondStreamContent);
            }

            //Check what we have in new file
            StreamReader proba = new StreamReader(finalFile);
            string content = proba.ReadToEnd();
            Console.WriteLine(content);
        }
    }
}
