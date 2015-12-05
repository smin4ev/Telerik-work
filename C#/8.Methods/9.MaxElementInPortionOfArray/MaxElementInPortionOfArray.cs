using System;

class MaxElementInAPotionOfArray
{
    //Write a method that return the maximal element in a portion of array of 
    //integers starting at given index. Using it write another method 
    //that sorts an array in ascending / descending order

    static int MaxElement(int[] array, int index)
    {
        int biggestMember = int.MinValue;
        for (int i = index; i < array.Length; i++)
        {
            if (array[i] > biggestMember)
            {
                biggestMember = array[i];
            }
        }
        return biggestMember;
    }

    static int[] SortingArray(int[] array)
    {
        Array.Sort(array);
        return array;
    }

    static int[] PrintinArrayInAccendingOrder(int[] array)
    {
        SortingArray(array);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0}, ", array[i]);
        }
        return array;
    }

    static int[] PrintingArrayInDescendingOrder(int[] array)
    {
        SortingArray(array);
        for (int i = array.Length-1; i >= 0; i--)
        {
            Console.Write("{0}, ", array[i]);
        }
        return array;
    }

    static void Main(string[] args)
    {
        int[] arrayForTest = { 2, 3, 13, 2, 15, 5, 16, 6, 23, 4, 45, 65, 19, 31, 9, 0, 15, 13, 3 };
        Console.WriteLine("Enter a index of array from which will start our search for the bigest member:");
        int indexInArray = int.Parse(Console.ReadLine());
        Console.WriteLine("Biggest member in array after member with index {0} ({1}) is {2}", indexInArray, arrayForTest[indexInArray], MaxElement(arrayForTest, indexInArray));

        Console.WriteLine("Array in ascending order:");
        PrintinArrayInAccendingOrder(arrayForTest);
        Console.WriteLine();

        Console.WriteLine("Array in descending order:");
        PrintingArrayInDescendingOrder(arrayForTest);


    }
}


