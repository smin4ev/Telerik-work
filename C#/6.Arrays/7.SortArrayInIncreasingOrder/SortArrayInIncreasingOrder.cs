using System;

class Program
{
    static void Main()
    {
        //Sorting an array means to arrange its elements in increasing order. 
        //Write a program to sort an array. Use the "selection sort" algorithm: 
        //Find the smallest element, move it at the first position, find the 
        //smallest from the rest, move it at the second position, etc.

        Console.WriteLine("Enter size of the array:");
        int N = int.Parse(Console.ReadLine());


        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("array [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int temporary;
        int valueOfCurrentElemetOfArray;

        for (int i = 0; i < N-1; i++)
        {
            valueOfCurrentElemetOfArray = i;
            for (int j = i+1; j < N; j++)
            {
                if (array[j] < array[valueOfCurrentElemetOfArray])
                {
                    valueOfCurrentElemetOfArray = j;
                }
            }
                temporary = array[i];
                array[i] = array[valueOfCurrentElemetOfArray];
                array[valueOfCurrentElemetOfArray] = temporary; 
        }
        for (int i = 0; i < N - 1; i++)
        {
            Console.Write("{0},", array[i]);
        }
        Console.WriteLine(array[N-1]); // In this way we lose coma after last digit 
    }
}

