using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _3.DurankulakNumbers
{
    class DurankulakNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            BigInteger sum = 0;
            int numberOfDigit = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input.Length == 1)
                {
                   
                    sum = sum + input[i] - 65;
                }
                else if (input[i] >= 97 && input[i] <= 102)
                {

                    sum = (sum + ((input[i] - 96) * 26) + (input[i + 1] - 65));
                    numberOfDigit++;
                    i++;
                }
                else if (input[i] >= 65 && input[i] <= 90)
                {
                   
                    sum = sum + numberOfDigit*168 * (input[i] - 65);
                    numberOfDigit++;
                  
                }

            }
            Console.WriteLine(sum);

        }
    }
}
