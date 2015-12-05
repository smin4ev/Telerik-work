using System;

class MinMaxAvrgSumProduct
{
    //Write methods to calculate minimum, maximum, average, sum and 
    //product of given set of integer numbers. Use variable number of arguments.

    static int Minimum(int[] array)
    {
        int Min = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < Min)
            {
                Min = array[i];
            }
        }
        return Min;
    }

    static int Maximum(int[] array)
    {
        int Max = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > Max)
            {
                Max = array[i];
            }
        }
        return Max;
    }
    static int SumOfElements(int[] array)
    {
        int Sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            Sum = Sum + array[i];
        }
        return Sum;
    }
    static int ProductOfElements(int[] array)
    {
        int product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product = product * array[i];
        }
        return product;
    }

    static void Main()
    {
        int[] array = { 12, 16, 5, 18, 24, 3, -1, -123, 12, 19876, -5634, 243};
        Console.Write("Minimal value is:");
        Console.WriteLine(Minimum(array));
        Console.Write("Maximal value is:");
        Console.WriteLine(Maximum(array));
        Console.Write("Avarage of numbers in array is:");
        Console.WriteLine(MultifunctionalTask.AverageOfSequenceOfIntegers(array)); //method from task 13
        Console.Write("Sum of elements is:");
        Console.WriteLine(SumOfElements(array));
        Console.Write("Product of elements is:");
        Console.WriteLine(ProductOfElements(array));
   
    }
}

