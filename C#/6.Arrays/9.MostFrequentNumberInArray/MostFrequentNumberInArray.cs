using System;

class MostFrequentNumberInArray
{
    static void Main()
    {
       // Write a program that finds the most frequent number in an array. Example:
	   // {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

        int arraySize = int.Parse(Console.ReadLine());
        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("array[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int counter = 1;
        int bestCounter = 1;
        int mostFrequentNumber=0;

        for (int i = 0; i < arraySize-1; i++)
        {
            for (int j = 0; j < arraySize ; j++)
            {
                if (i == j)
                {
                    continue;
                }
                else if (array[j] == array[i])
                {
                    counter = counter + 1;
                    if (counter > bestCounter)
                    {
                        bestCounter = counter;
                        mostFrequentNumber = array[i];
                    }
                }
            }
            counter = 1;
        }
        Console.Write("Most frequent number is {0} - ",mostFrequentNumber);
        Console.WriteLine("{0} times", bestCounter);

    }
}

