using System;

class MaximalSequenseOfEqualElements
{
    static void Main()
    {

        //Write a program that finds the maximal sequence of equal elements in an array.
        //Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

        //int arraySize = int.Parse(Console.ReadLine());
        //int[] array = new int[arraySize];
        //int counter = 1;
        //int maxCounter = 1;
        //int element = 0;
        //for (int i = 0; i < arraySize; i++)
        //{
        //    Console.Write("array[0]=", i);
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        //for (int i = 0; i < arraySize-1; i++)
        //{
        //    if (array[i] == array[i+1])
        //    {
        //        counter++;
        //        element = array[i];

        //    }
        //    else 
        //    {
        //        if (counter > maxCounter)
        //        {
        //            maxCounter = counter;
        //            element = array[i];
        //        }
        //    }
        //}
        //for (int i = 0; i < maxCounter-1; i++)   //Write to maxCounter-1 and after the loop ane more "element" to lose the last coma
        // {
        //    Console.Write(element + ",");
        //}
        //Console.Write(element);

        //Write a program that finds the maximal sequence of equal elements in an array.
        //Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

        int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 2 };
        int maxCounter = 1;
        int counter = 1;
        int currentElement = 0;
        int elementInMaxSequence = 0;
        int i = 0;
        for (i = 0; i < array.Length-1; i++)
        {
            if (array[i] == array[i + 1])
            {
                counter++;
                currentElement = array[i];
            }
            else 
            {
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    elementInMaxSequence = array[i];
                    counter = 1;
                }
                else 
                {
                    counter = 1;
                }
            }
            
        }
        if (counter > maxCounter)
        {
            maxCounter = counter;
            elementInMaxSequence = array[i];
        }
        Console.WriteLine(maxCounter);
        Console.WriteLine(counter);
        Console.WriteLine(elementInMaxSequence);
    }
}

