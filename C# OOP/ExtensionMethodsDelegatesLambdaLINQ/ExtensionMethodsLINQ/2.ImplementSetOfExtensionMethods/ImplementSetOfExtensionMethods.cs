using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ImplementSetOfExtensionMethods
{
    //Implement a set of extension methods for IEnumerable<T> that implement 
    //the following group functions: sum, product, min, max, average

    public static class ImplementSetOfExtensionMethods
    {
        public static T Sum<T>(this IEnumerable<T> input) 
        {
            dynamic sum = 0;
            foreach (var item in input)
            {
                sum = sum + item;
            }
            return sum;
        }
        public static T Product<T>(this IEnumerable<T> input) 
        {
            dynamic product = 1;
            foreach (var item in input)
            {
                product = product * item;
            }
            return product;
        }
        public static T Min<T>(this IEnumerable <T> input)
        {
            dynamic min = int.MaxValue;
            foreach (var item in input)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
        public static T Max<T>(this IEnumerable<T> input)
        {
            dynamic max = int.MinValue;
            foreach (var item in input)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
        public static T Avarage<T>(this IEnumerable<T> input)
        {
            dynamic avarage = 0;
            dynamic sum = 0;
            dynamic count = 0;
            foreach (var item in input)
            {
                sum = sum + item;
                count++;
            }
            avarage = sum / count;
            return avarage;
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 3, 13, 12, 16 };
            Console.WriteLine(array.Min());
            Console.WriteLine(array.Max());
            Console.WriteLine(array.Sum());
            Console.WriteLine(array.Product());
            Console.WriteLine(array.Avarage());
           

        }
    }
}
