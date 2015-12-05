using System;


class ArrayWithLettersAndWord
{
    static void Main()
    {
        //Write a program that creates an array containing all letters from the alphabet (A-Z).
        //Read a word from the console and print the index of each of its letters in the array

        char[]arrayLetters = new char[26];

        for (int i = 0; i<arrayLetters.Length; i++)
        {
            Console.Write("array[{0}]=", i);
            Console.WriteLine(arrayLetters[i] = (char)(i + 65)); 
        }
        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine().ToUpper();
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < arrayLetters.Length; j++)
            {
                if (word[i] == arrayLetters[j])
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}

