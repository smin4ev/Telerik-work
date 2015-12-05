using System;

public class ElementsInArrayAndItsNeighbors
{
    //Write a method that checks if the element at given position in given array 
    //of integers is bigger than its two neighbors (when such exist).

    //DECISION with bool method  - use in task 6
    public static bool AreTheElementInArrayIsBiggerThanItsNaighbors(int[] array, int position)
    {
        if (position < 0 || (position > array.Length))
        {
            Console.WriteLine("This position is outside array ");
            return false;
        }
        else if ((position == 0) || (position == array.Length - 1))
        {
            Console.WriteLine("Element {0} have only one neigbour", array[position]);
            return false;
        }
        else if ((array[position] > array[position - 1]) && (array[position] > array[position + 1]))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //public static void AreTheElementInArrayIsBiggerThanItsNaighbors(int[] array, int position)
    //{
    //    if ((position > array.Length - 1) || position < 0)
    //    {
    //        Console.WriteLine("There is no such an index in the array! ");
            
    //    }
    //    else if (position == 0 || position == array.Length - 1)
    //    {
    //        Console.WriteLine("This element there is only one neighbour!");
    //    }
    //    else if ((array[position] > array[position + 1]) && (array[position] > array[position - 1]))
    //    {
    //        Console.WriteLine("Number {0} at position {1} is bigger than its two neighbors!", array[position], position);
    //    }
    //    else
    //    {
    //        Console.WriteLine("Number {0} at position {1} is not bigger than its two neighbors!", array[position], position);
    //    }
 
    //}

    static void Main()
    {
        int[] array = { 3, 4, 5, 12, 2, 13, 5, 6, 16, 17, 5, 18, 20, 21, 9, 12, 8, 15, 7, 4, 4, 12 };
        Console.WriteLine("Enter a position for check");
        int positionForCheck = int.Parse(Console.ReadLine());
        Console.WriteLine(AreTheElementInArrayIsBiggerThanItsNaighbors(array, positionForCheck)); 
    }
}

