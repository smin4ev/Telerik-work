using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.OneTaskISNotEnough

    //Дава 10 точки:)))))

{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ulong a = ulong.Parse(numbers[0]);
            ulong b = ulong.Parse(numbers[1]);
            
            int counterForEquals = 0;
            int counterOfLuckyNumbers = 0;
            for (ulong i = a; i <= b; i++)
            {
                string currentNumber = i.ToString();
                for (int j = 0; j < currentNumber.Length; j++)
                {
                    if (currentNumber[j] == currentNumber[currentNumber.Length - 1 - j] && ((currentNumber[j] == '5') || currentNumber[j] == '3'))
                    {
                        counterForEquals++;  
                    }
                }
                if (counterForEquals == currentNumber.Length)
                {
                    counterOfLuckyNumbers++;
                }
                counterForEquals = 0;            
            }


            string[] elements = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            double persent = double.Parse(Console.ReadLine());
            int[] elementInNumbers = new int[elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                elementInNumbers[i] = int.Parse(elements[i]);
            }
            Array.Sort(elementInNumbers);
            double proba = elementInNumbers.Length * (persent / 100.0);
           
            int final = 0;
            for (int i = 0; i < elementInNumbers.Length; i++)
            {
                if ((int)proba <= i)
                {
                    final = elementInNumbers[i];
                    break;
                }
            }

            Console.WriteLine(counterOfLuckyNumbers);
            Console.WriteLine(final);
        }
    }
}
