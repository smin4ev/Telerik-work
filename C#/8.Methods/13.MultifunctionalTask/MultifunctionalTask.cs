using System;

public class MultifunctionalTask
{
            //Write a program that can solve these tasks:
            //    -Reverses the digits of a number
            //    -Calculates the average of a sequence of integers
            //    -Solves a linear equation a * x + b = 0
            //Create appropriate methods.
            //Provide a simple text-based menu for the user to choose which task to solve.
            //Validate the input data:
            //  -The decimal number should be non-negative
            //  -The sequence should not be empty
            //  -a should not be equal to 0

    static decimal ReverseDigitOfNumber(decimal number)
    {
        string output = "";
        string numberToString = number.ToString();
        for (int i = numberToString.Length - 1; i >= 0; i--)
        {
            output = output + numberToString[i];
        }

        decimal outputAsNumber = decimal.Parse(output);
        return outputAsNumber;
        
    }

    public static double AverageOfSequenceOfIntegers(int[]array)
    {
        int adder = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            adder = adder + array[i];
        }
        return (double) adder/array.Length;
            
    }

    static double SolveOfLinearEquation(double a, double b)
    {
       
        double solutionOfEquation = -b / a;
        return solutionOfEquation;
    }
    static void ChoiseOfTask()
    {
        Console.WriteLine("Choose a number from 1 to 3 for:");
        Console.WriteLine("1.Reverse digit of number ");
        Console.WriteLine("2.Avarage of sequense of integers");
        Console.WriteLine("3.Solve of linear equation");

        int choise = int.Parse(Console.ReadLine());
        if (choise != 1 & choise != 2 & choise != 3)
        {
            Console.WriteLine("Wrong input data!");
        }
        else if (choise == 1)
        {
            Console.WriteLine("Enter a non-negative decimal number:");
            decimal number = decimal.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Wrong input data! Number must be non-negative! ");
            }
            else 
            {
                Console.WriteLine("Reversed number of our entry number {0} is {1}", number, ReverseDigitOfNumber(number));
            }
        }
        else if (choise == 2)
        {
            Console.WriteLine("Enter numbers of integer sequence:");
            int arraySize = int.Parse(Console.ReadLine());
            if (arraySize <= 0)
            {
                Console.WriteLine("Wrong input data! It's not posible sequence to be negative");
            }
            else
            {
                int[] array = new int[arraySize];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("array[{0}]=", i);
                    array[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Avarage of this sequense is {0}", AverageOfSequenceOfIntegers(array));
            }
        }
        else 
        {
            Console.WriteLine("Enter parametars of linear equation(a*x+b=0): ");
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Wrong input data for a - it must be different from 0");
            }
            else
            {
                Console.WriteLine("Answer of linear equatin is {0}", SolveOfLinearEquation(a,b));
            }

        }

        
    }

    static void Main()
    {
        ChoiseOfTask();
    }
}

