using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWordsOnly
{

   // Modify the solution of the previous problem to replace only whole words (not substrings).

    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\text1.txt"))
            {
                string pattern = @"\b(start)\b"; // Regex expression
                Regex rgx = new Regex(pattern);

                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    string newLine = rgx.Replace(line, "finish");
                    writer.WriteLine(newLine);
                }
            }

        }
    }
}