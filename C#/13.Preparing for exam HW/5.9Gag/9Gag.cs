using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _5._9Gag
{
    class Program
    {
        static BigInteger PowerOfNine(int power)//Този метод се използва за 9 на степен, защото с Math.Pow при големи числа има загуби
                                                // и в BGcoder дава само 75 точки.
        {
            BigInteger result = 1;
            for (int i = 0; i < power; i++)
            {
                result = result * 9;
            }

            return result;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder numbers = new StringBuilder();
          
            for (int i = 0; i < input.Length; i++)
            {
                
                if (input[i] == '-')
                {
                    numbers.Append(0);
                    i++;
                }
                else if (input[i] == '*' && input[i+1] == '*')
                {
                    numbers.Append(1);
                    i++;
                }
                else if(input[i] == '*' && input[i+1] =='!')
                {
                    numbers.Append(6);
                    i = i + 3;
                }
                else if (input[i] == '&' && input[i + 1] == '-')
                {
                    numbers.Append(4);
                    i++;
                }
                else if (input[i] == '&' && input[i + 1] == '&')
                {
                    numbers.Append(3);
                    i++;
                }
                else if (input[i] == '&' && input[i + 1] == '*')
                {
                    numbers.Append(7);
                    i = i + 2;
                }
                else if (input[i] == '!' && input[i + 1] == '-')
                {
                    numbers.Append(5);
                    i++;
                }
                else if (input[i] == '!' && input[i + 1] == '!' && input[i + 2] == '*')
                {
                    numbers.Append(8);
                    i = i + 5;
                }
                else if (input[i] == '!' && input[i + 1] == '!' && input[i + 2] == '!')
                {
                    numbers.Append(2);
                    i = i + 2;
                }
                else 
                {
                    numbers.Append('A');
                }
            }
            int[] reverse = new int[numbers.Length];
            int j = 0;
            for (int i = numbers.Length-1; i >= 0; i-- )
            {
                reverse[j] =int.Parse(numbers[i].ToString());
                j++;
            }
            BigInteger sum = 0;
            BigInteger finalSum = 0;

            for (int i = 0; i < reverse.Length; i++)
            {
                sum =reverse[i] * PowerOfNine(i);
                finalSum = finalSum + sum;
            }
            Console.WriteLine(finalSum);
        }
    }
}
