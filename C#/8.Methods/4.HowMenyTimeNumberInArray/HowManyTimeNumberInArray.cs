using System;

class HowManyTimeNumberInArray
{
    //Write a method that counts how many times given number appears in given array.
    //Write a test program to check if the method is working correctly

 
    static int NumberInArrayRepeat(int[] array, int number)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }

    static void Main()
    {
        int[] arrayForCheck = { 3, 4, 5, 6, 12, 2, 3, 4, 4, 4, 5, 6, 5, 4, 12 };
        Console.WriteLine("Enter a number:");
        int numberForCheck = int.Parse(Console.ReadLine());
        Console.WriteLine("Number {0} appears {1} times in array!",numberForCheck, NumberInArrayRepeat(arrayForCheck, numberForCheck)); 
       
    }
}

