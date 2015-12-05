using System;

class MaximalSequenseOfIncreasingElements
{
    static void Main()
    {
        //Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("array[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int currentLenght = 1;
        int maxLenght = 1;
        int bestStart = 0;

        for (int i = 0; i < arraySize-1; i++)
        {
        
            if (array[i] < array[i + 1])
            {
                currentLenght++;
                if (currentLenght > maxLenght)
                {
                    maxLenght = currentLenght;
                    bestStart = i + 1 - maxLenght + 1;
                }
            }
            else 
            {
                currentLenght = 1;
            }
        }
        
        for (int i = bestStart; i < bestStart + maxLenght-1; i++)
        {
            Console.Write("{0},", array[i]);
            //Console.Write(array[i] + ','); - Къде бъркам тук?, защо ми дава някакви нереални стойности?, 
            //този ред не е ли аналогичен на горния
        }
        Console.Write(array[bestStart + maxLenght-1]);

    }
}

