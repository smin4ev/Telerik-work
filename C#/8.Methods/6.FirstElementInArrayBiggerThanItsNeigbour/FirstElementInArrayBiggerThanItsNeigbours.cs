using System;

class FirstElementInArrayBiggerThanItsNeigbours
{
    //Write a method that returns the index of the first element in array 
    //that is bigger than its neighbors, or -1, if there’s no such element.
    //Use the method from the previous exercise.

    static void ReturnIndexOfFirstBiggestElementInArray(int[] array)
    {
        bool checkFor = false;
        for (int i = 1; i < array.Length-1; i++) // from 1 to array.length-1 because first and last membar  have 2 neighbours
        {
            if (ElementsInArrayAndItsNeighbors.AreTheElementInArrayIsBiggerThanItsNaighbors(array, i) == true) //method from task 5
            {
                Console.WriteLine("Element at position {0} is the first element bigger that its naigbours and its value is {1}",i, array[i]);
                checkFor = true;
                break;
            }
        }
        if (checkFor == false)
        {
            Console.WriteLine(-1);
        }

    }

    static void Main()
    {
        int[] array = { 2, 1, 6, 7, 8, 12, 16, 17, 23, 24, 34, 12 };
        ReturnIndexOfFirstBiggestElementInArray(array);

     
    }
}

