using System;


class SequenceOfGivenSumInArray
{
    static void Main()
    {
        //Write a program that finds in given array of integers 
        //a sequence of given sum S (if present). 
        //Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}


        int[] array = { 4, 3, 1, 4, 2, 5, 2, 1 , 10, 0 , 7, 4 };
        int sum = 11;
        // int sum = int.Parse(Console.ReadLine());

        int temporatySum;
        int currentLenght = 1;
        int counterOfSequences = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            temporatySum = array[i];
            if (temporatySum == sum)
            {
                Console.WriteLine(temporatySum);
                break;
            }
            for (int j = i + 1; j < array.Length; j++)
            {
                temporatySum = temporatySum + array[j];
                currentLenght++;

                if (temporatySum < sum)
                {
                    continue;
                }
                else if (temporatySum > sum)
                {
                    currentLenght = 1;
                    break;
                }
                else
                {
                    counterOfSequences++;
                    Console.Write("{0} sequence - ", counterOfSequences  );
                    for (int q = i; q < i + currentLenght - 1; q++)
                    {
                        Console.Write("{0},", array[q]);
                    }
                    Console.WriteLine(array[i + currentLenght - 1]);
                    currentLenght = 1;
                    break;
                }

            }

        }
    }
}

