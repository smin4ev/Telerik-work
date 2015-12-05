using System;

class AllocateArrayOf20Integers
{
    static void Main()
    {
        //Write a program that allocates array of 20 integers and initializes each 
        //element by its index multiplied by 5. Print the obtained array on the console.

        int[] twentyElementsArray = new int[20];

        int n = 0;
        for (int i = 0; i < 20; i++)
        {
            twentyElementsArray[n] = n * 5;
            Console.WriteLine(twentyElementsArray[n]);
            n++;
        }

       
    }
}

