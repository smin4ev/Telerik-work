using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// РЕШЕНИЕТО НЕ Е МОЕ!!!!!!!!!!!!!!
namespace _21.CombinationOfKElementsFromN
{
    class CombinationOfKElementsFromN
    {
        static void Main(string[] args)
        {
            //Write a program that reads two numbers N and K and generates all the combinations of K 
            //distinct elements from the set [1..N]. Example:

            //N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}


            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int K = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // make array from 1 to N
            int[] myArr = new int[N];
            for (int i = 0; i < N; i++)
            {
                myArr[i] = i + 1;
            }

            // print array
            Console.Write("The array is: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(myArr[i] + " ");
            }
            Console.WriteLine();

            // all possible combinations
            int combinations = (int)(Math.Pow(2, N) - 1);

            // make combinations of K elements
            Console.WriteLine();
            Console.WriteLine("Generate all combinations of {0} distinct elements", K);
            for (int i = 1; i <= combinations; i++)
            {
                int counterOnes = 0;
                for (int j = 0; j < N; j++)
                {
                    byte bit = (byte)(i >> j & 1);
                    if (bit == 1)
                    {
                        counterOnes++;
                    }
                }

                if (counterOnes == K)
                {
                    for (int j = 0; j < N; j++)
                    {
                        byte bit = (byte)(i >> j & 1);
                        if (bit == 1)
                        {
                            Console.Write(myArr[j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
