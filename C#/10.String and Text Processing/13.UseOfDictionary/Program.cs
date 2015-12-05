using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please input text:");
            string inputstring = Console.ReadLine();
            string[] separate = inputstring.Split(' ');
            Dictionary<string, string> itemdescription = new Dictionary<string, string>();
            Console.WriteLine("Please enter description for the each word entered before");
            for (int i = 0; i < separate.Length; i++)
            {
                Console.Write("The description of {0} is", separate[i]);
                itemdescription.Add(separate[i], Console.ReadLine());
            }
            Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in itemdescription)
            {
                Console.WriteLine("KeyWord = {0}, Description = {1}",
                    kvp.Key, kvp.Value);
            }
        }
    }
}