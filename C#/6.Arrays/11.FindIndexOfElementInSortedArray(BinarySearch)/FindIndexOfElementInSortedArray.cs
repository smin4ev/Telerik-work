
using System;

class BinarySearchAlgorithm
{
    static void Main()
    {
        //Write a program that finds the index of given element in a sorted array of integers 
        //by using the binary search algorithm (find it in Wikipedia).

        int[] array = { 0, 6, 7, 9, 13, 15, 18, 21, 26, 29, 56, 67, 78 };
        int searchedNumber = int.Parse(Console.ReadLine());
        int startSearch = 0;
        int endSearch = array.Length - 1;
        int middle;
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (searchedNumber == array[i])
            {
                counter++;
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("There is no such number in array!");
        }
        else
        {
            while (startSearch <= endSearch)
            {
                middle = (startSearch + endSearch) / 2;

                if (array[middle] == searchedNumber)
                {
                    Console.WriteLine("Index is: {0}.", middle);
                    break;
                }

                if (array[middle] < searchedNumber)
                {
                    startSearch = middle + 1;
                }

                if (array[middle] > searchedNumber)
                {
                    endSearch = middle - 1;
                }
            }
        }
    }
}
