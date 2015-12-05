using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyDwarf
{
    public class Program
    {
        private static long ProccessPattern(int[] vally)
        {
            string[] rawNumbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] pattern = new int[rawNumbers.Length];

            for (int i = 0; i < pattern.Length; i++)
            {
                pattern[i] = int.Parse(rawNumbers[i]);
            }

            bool[] visited = new bool[vally.Length];
            long coinSum = 0;
            coinSum += vally[0];
            visited[0] = true;
            int currentPositon = 0;

            while (true)
            {
                for (int i = 0; i < pattern.Length; i++)
                {
                    int nextMove = currentPositon + pattern[i];

                    if (nextMove >= 0
                        && nextMove < vally.Length
                        && !visited[nextMove])
                    {
                        coinSum += vally[nextMove];
                        visited[nextMove] = true;
                        currentPositon = nextMove;
                    }
                    else
                    {
                        return coinSum;
                    }
                }
            }

           
        }

        public static void Main()
        {

            string[] rawNumbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            int[] vallyNumers = new int[rawNumbers.Length];

            for (int i = 0; i < vallyNumers.Length; i++)
            {
                vallyNumers[i] = int.Parse(rawNumbers[i]);
            }

            int numberOfPatterns = int.Parse(Console.ReadLine());
            long bestSum = long.MinValue;

            for (int i = 0; i < numberOfPatterns; i++)
            {
                long sum = ProccessPattern(vallyNumers);

                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }

            Console.WriteLine(bestSum);
        }
    }
}
