using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.DevisibleBy7And3
{
    //Write a program that prints from given array of integers all numbers 
    //that are divisible by 7 and 3. Use the built-in extension methods 
    //and lambda expressions. Rewrite the same with LINQ.

    class DevisibleBy7And3
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 0, 7, 21, 42, 14, 33, 41, 63, 109, 31, 252 };
            //-With lambda expression
            Console.WriteLine("With lambda expression:");
            var numbersWithLambda = array.Where(x => x % 21 == 0);
            foreach (var number in numbersWithLambda)
            {
                Console.WriteLine(number);
            }
            //-With LINQ 
            Console.WriteLine();
            Console.WriteLine("With LINQ:");
            var numbersWintLINQ =
                from number in array
                where number % 21 == 0
                select number;
            foreach (var number in numbersWintLINQ)
            {
                Console.WriteLine(number);
            }

        }
    }
}
