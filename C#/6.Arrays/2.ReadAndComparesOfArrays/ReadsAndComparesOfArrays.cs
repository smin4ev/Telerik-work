using System;

class ReadsAndComparesOfArrays
{
    static void Main()
    {
       // Write a program that reads two arrays from the console and compares them element by element.

        int firstArraySize = int.Parse(Console.ReadLine());
        int secondArraySize = int.Parse(Console.ReadLine());

        int[] firstArray = new int[firstArraySize];
        int[] secondArray = new int[secondArraySize];

        if (firstArraySize != secondArraySize)
        {
            Console.WriteLine("Two arrays are differnt");
        }
        else
        {
            bool isEqual = true;
            for (int i = 0; i < firstArraySize; i++)
            {
                Console.Write("First array [{0}] = ",i );
                firstArray[i] = int.Parse(Console.ReadLine());
                Console.Write("Second array [{0}] = ", i);
                secondArray[i] = int.Parse(Console.ReadLine());
                if (firstArray[i] != secondArray[i])
                {
                    isEqual = false;
                    break;
                }

            }
            Console.WriteLine("Are the two arrays are equal? - {0}", isEqual);
        }
    }
}

