using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ExtensionSubstring
{

    //Implement an extension method Substring(int index, int length) for 
    //the class StringBuilder that returns new StringBuilder and has the 
    //same functionality as Substring in the class String.


    //Make static class
    static class ExtentionSubstring
    {
        //Make static method with "this" -mandatory for extension method
        public static StringBuilder SubString(this StringBuilder input, int index, int length)
        {
            StringBuilder subString = new StringBuilder();
            if (index + length > input.Length)
            {
                throw new IndexOutOfRangeException("Not possible index + lenght to be larger than lenght of string");
            }
            else if (index < 0 || length < 0)
            {
                throw new IndexOutOfRangeException("Not possible start index or lenght of substring to be <0");
            }
            else if (index > input.Length)
            {
                throw new IndexOutOfRangeException("Not possible start index of substring to be outside of string");
            }
            else if (length > input.Length)
            {
                throw new IndexOutOfRangeException("Not possible lenght of substring to be longer than string");
            }
            for (int i = index; i < index+length; i++)
			{
			    subString.Append(input[i]);
			}
            return subString;

        }
        static void Main(string[] args)
        {
            StringBuilder proba = new StringBuilder();
            proba.Append ("Ala bala portokala shalala");
            Console.WriteLine(proba.SubString(2,3));

        }
    }
}
