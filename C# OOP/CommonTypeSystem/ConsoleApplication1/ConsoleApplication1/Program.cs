using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

           int[] proba = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 0, 12, 13, 3, 2, 1 };
            for (int i = 0; i < proba.Length; i++)
            {
                int ala = int.MinValue;

                if (proba[i] > ala)
                {
                    ala = proba[i];
                }
                ala = ala + 1000;
            }
        }
    }
}
