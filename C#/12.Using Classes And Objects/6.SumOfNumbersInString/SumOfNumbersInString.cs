using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SumOfNumbersInString
{
    class SumOfNumbersInString
    {
        //You are given a sequence of positive integer values written into a string, 
        //separated by spaces. Write a function that reads these values from given 
        //string and calculates their sum. 
        //Example: string = "43 68 9 23 318"  result = 461



        static void Main()
        {
            
            string input = "43 68 9 23 318";
            int sumator = 0;

            StringBuilder temporary = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    temporary = temporary.Append(input[i]);
                }
                else
                {
                    int subSum = int.Parse(temporary.ToString());
                    sumator = sumator + subSum;
                    temporary.Clear();
                }
                if (i == input.Length - 1)
                {
                    int subSum = int.Parse(temporary.ToString());
                    sumator = sumator + subSum;
                    break;
                }
            }
            Console.WriteLine("Sum of numbers in string is {0}", sumator);
        }

    }
}

