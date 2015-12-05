using System;


class SquareRootOrInvalidNumber
{

    //Write a program that reads an integer number and calculates and prints its square root. 
    //If the number is invalid or negative, print "Invalid number". 
    //In all cases finally print "Good bye". Use try-catch-finally

    static void Main()
    {
        Console.WriteLine("Enter a integer number:");
        try
        {
            uint number = uint.Parse(Console.ReadLine());

            Console.WriteLine(Math.Sqrt(number));
        }
        
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }


    }
}

