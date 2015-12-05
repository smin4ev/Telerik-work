using System;

class NumbersInInterval
{
    //Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
    //If an invalid number or non-number text is entered, the method should throw an exception. 
    //Using this method write a program that enters 10 numbers:
    //a1, a2, … a10, such that 1 < a1 < … < a10 < 100

    private static void ReadNumber(int start, int end)
    {
        for (int i = 1; i <= 10; i++)
        {
            int number = 0;
            try
            {
                Console.Write("Number {0}:", i);
                 number = int.Parse(Console.ReadLine());
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid integer number!");
                throw new FormatException("This string is not possible to be parsed in INT32");
            }
            catch (OverflowException )
            {
                throw new OverflowException("Number is to big for int32!");
            }
            if (number < start | number > end)
            {
                throw new ArgumentOutOfRangeException("Number is  bigger than previous number or bigger than top borde!");
            }
            start = number;
        }
        
    }

    static void Main()
    {
        Console.WriteLine("Enter 10 number in ascending order, but not smaller than 1 and not greated than 100");
        ReadNumber(1, 100);
    }
}


