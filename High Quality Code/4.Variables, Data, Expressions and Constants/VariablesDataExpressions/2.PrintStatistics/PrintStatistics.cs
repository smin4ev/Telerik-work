using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PrintStatistics
{
    public class PrintStatistics
    {
        public static void Main(string[] args)
        {
            double[] numbers = new double[] { 16,15,24,3,4,5,10 };
            PrintStatisticsForArray(numbers);
             
        }

        public static void PrintStatisticsForArray(double[] arrayOfNumbers)
        {
            int countOfNumbers = arrayOfNumbers.Length;
            double maxNumber = (double)int.MinValue;
            for (int i = 0; i < countOfNumbers; i++)
            {
                if (arrayOfNumbers[i] >(double)maxNumber) 
                {
                   maxNumber = arrayOfNumbers[i];
                }
            }
            PrintValue(maxNumber);

            double minNumber = (double)int.MaxValue;
            for (int i = 0; i < countOfNumbers; i++)
            {
                if (arrayOfNumbers[i] < minNumber)
                {
                    minNumber = arrayOfNumbers[i];
                }
            }
            PrintValue(minNumber);

            double sumOfNumber = 0;
            for (int i = 0; i < countOfNumbers; i++)
            {
                sumOfNumber = sumOfNumber + arrayOfNumbers[i];
            }

            PrintAvarage(sumOfNumber,countOfNumbers);
        }


        public static void PrintValue(double value)
        {
            Console.WriteLine(value);
        }

        public static void PrintAvarage(double sum, double count)
        {
            double avarage = sum / count;
            Console.WriteLine(avarage);
        }

    }
}
