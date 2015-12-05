using System;


class CopmareTwoCharsArrayLexicographicaly
{
    static void Main()
    {
       // Write a program that compares two char arrays lexicographically (letter by letter).
        int firstArraySize = int.Parse(Console.ReadLine());
        int secondArraySize = int.Parse(Console.ReadLine());

        char[] firstArray = new char[firstArraySize];
        char[] secondArray = new char[secondArraySize];

        for (int i = 0; i < firstArraySize; i++)
        {
            firstArray[i] = char.Parse(Console.ReadLine());
        }
        for (int i = 0; i < secondArraySize; i++)
        {
            secondArray[i] = char.Parse(Console.ReadLine());
        }
        for (int i = 0; i < Math.Min(firstArraySize, secondArraySize); i++)
        {
            if (i == Math.Min(firstArraySize, secondArraySize))
            {
                if (firstArraySize == secondArraySize)
                {
                    Console.WriteLine("Array are equal");
                }
                else if(firstArraySize < secondArraySize)
                {
                    Console.WriteLine("Lexicographi first is first array ");
                    Console.WriteLine("This array consist {0} chars", firstArraySize);
                }
                else
                {
                    Console.WriteLine("Lexicographi first is second array ");
                    Console.WriteLine("This array consist {0} chars", secondArraySize);
                }
            }
            if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("First array is lexicographi earlier");
                break;
            }
            else if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("Second array is lexicographi earlier");
                break;
            }
            else 
            {
                continue;
            } 
        }
    }
}

