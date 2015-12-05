using System;

class MethodGetMax
{
    //Write a method GetMax() with two parameters that returns the bigger of two integers. 
    //Write a program that reads 3 integers from the console and prints the biggest of them 
    //using the method GetMax().

    static int GetMax(int firstNumber, int secondNumber)
    {
        int result = 0;
        if (firstNumber >= secondNumber)
        {
            result = firstNumber;
        }
        else  
        {
            result = secondNumber;
        }
       
        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int second = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int third = int.Parse(Console.ReadLine());

        int temp = GetMax(first, second);
        temp = GetMax(temp, third);
        Console.WriteLine("The biggest of the three numbers is {0}", temp);
    }
}
