using System;

class MaxSumOfKElementsInArray
{
    static void Main()
    {
        //Write a program that reads two integer numbers N and K and an array of N elements from the console. 
        //Find in the array those K elements that have maximal sum

        Console.WriteLine("Enter size of the array:");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of K elements:");
        int K = int.Parse(Console.ReadLine());
        if (K >= N)
        {
            Console.WriteLine("Wrong input data! K must be < N!");
        }
        int[] Array = new int[N];
        for (int i = 0; i < N - 1; i++)
        {
            Console.Write("First array[{0}]=", i);
            Array[i] = int.Parse(Console.ReadLine());
        }
        int temp;
        int value;

        for (int i = 0; i < N; i++)
        {
            value = i;
            for (int j = i + 1; j < N; j++)
            {
                if (Array[j] < Array[value])
                {
                    value = j;
                }
            }
            temp = Array[i];
            Array[i] = Array[value];
            Array[value] = temp;
        }
        for (int i = N - K; i < N - 1; i++)
        {
            Console.Write("{0},", Array[i]);
        }
        Console.WriteLine(Array[N - 1]);

        //int[] arr = {10,1255569,-851435,1457629,858237,221970,-652780,1379095,-732864,-606100,1566514};
        //int maxSum = -2000000;
        //for (int i = 1; i < arr.Length; i++)
        //{
        //    int curSum = 0;
        //    for (int j = i; j < arr.Length; j++)
        //    {
        //        curSum = curSum + arr[j];
        //        if (curSum > maxSum) 
        //        {
        //            maxSum = curSum;
        //        }
        //    }
        //}
        //Console.WriteLine(maxSum);
    }
}

