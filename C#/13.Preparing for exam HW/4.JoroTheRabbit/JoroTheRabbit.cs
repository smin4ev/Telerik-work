using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.JoroTheRabbit
{
    class JoroTheRabbit
    {
        static void Main(string[] args)
        {
            string input = "1, -2, -3, 4, -5, 6, -7, -8";
            string[] terrain = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[terrain.Length];
            int counter = 1;
            int bestCounter = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(terrain[i]);
            }
            for (int start = 0; start < numbers.Length; start++)
            {
                for (int step = 1; step < numbers.Length ; step++)
                {
                    int index = start;
                    int next = index + step;
                    if(next >= numbers.Length)
                    {
                        next = next - numbers.Length;
                    }
                    while (numbers[index]<numbers[next])
                    {
                        counter++;
                        index = next;
                        next = next + step;
                        if (next >= numbers.Length)
                        {
                            next = next - numbers.Length;
                        }
                        if (bestCounter < counter)
                        {
                            bestCounter = counter;
                        }
                        
                    }
                    counter = 1;
                }
            }
            Console.WriteLine(bestCounter);
        }
        
    }
}
