using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SearchValue
{
    class SearchValue
    {
        public static void Main(string[] args)
        {
            int expectedValue = 666;
            bool isFind = false;

            int[] array = new int[] { 100, 15, 14, 205, 13, 111, 666, 3424, 232, 66, 666 };
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        isFind = true;
                        break;
                    }
                }
            }

            if (isFind)
            {
                Console.WriteLine("Searched value is found!");
            }
            else 
            {
                Console.WriteLine("Searched value is not found!");
            }
        }
    }
}
