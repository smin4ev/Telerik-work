using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenericListAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<string> test = new GenericList<string>();
            test.Add("info");
            test.Add("text");
            test.Add("proba");
            test.Add("dumi");
            test.InsertElement(2, "Informaciq");
            Console.WriteLine(test.ToString());
            Console.WriteLine(test.Min<string>());
            Console.WriteLine(test[2]);
        }
    }
}

