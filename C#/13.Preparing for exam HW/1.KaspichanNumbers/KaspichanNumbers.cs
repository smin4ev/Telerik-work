using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _1.KaspichanNumbers
{
    class KaspichanNumbers
    {
        static void Main(string[] args)
        {
            ulong input = ulong.Parse(Console.ReadLine());
           
            ulong rest = 0;
            ulong bigLetter = 0;
            ulong smallLetter = 0;
            StringBuilder kaspi = new StringBuilder();
            StringBuilder final = new StringBuilder();
            if (input == 0)
            {
                Console.WriteLine("A");
            }
                while (input > 0)
                {
                    rest = input % 256;
                    bigLetter = rest % 26;
                    smallLetter = rest / 26;
                    kaspi.Append((char)(bigLetter + 65));
                    if (smallLetter != 0)
                    {
                        kaspi.Append((char)(smallLetter + 96));
                    }
                    input = input / 256;
                }
                for (int i = kaspi.Length - 1; i > -1; i--)
                {
                    final.Append(kaspi[i]);
                }
                Console.WriteLine(final);
            }
    }
}
