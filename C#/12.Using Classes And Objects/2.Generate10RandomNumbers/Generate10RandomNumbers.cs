using System;
using System.Collections.Generic;


class Generate10RandomNumbers
{

   // Write a program that generates and prints to the console 10 random values in the range [100, 200].


    static void Main()
    {
        Random randomGenerator = new Random();
        for (int i = 0; i < 10; i++)
        {
            int randomNumber = randomGenerator.Next(100, 200);
            Console.WriteLine(randomNumber);
        }
        
    }
}

