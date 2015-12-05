using System;

class LastDigitAsEnglishWord
{
    //Write a method that returns the last digit of given integer as an English word. 
    //Examples: 512  "two", 1024  "four", 12309  "nine".


    //CASE 1 - void method without any parameters
    static void LastDigitAsWord()
    {
        int number = int.Parse(Console.ReadLine());
        int lastDigit = number % 10;
        switch (lastDigit)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
            default:
                Console.WriteLine("Invalid number!");
                break;
        }

    }

    //CASE 2 - int method
    //static int LastDigitAsWord(int number)
    //{
    //    int lastDigit = number % 10;
    //    switch (lastDigit)
    //    {
    //        case 0:
    //            Console.WriteLine("Zero");
    //            break;
    //        case 1:
    //            Console.WriteLine("One");
    //            break;
    //        case 2:
    //            Console.WriteLine("Two");
    //            break;
    //        case 3:
    //            Console.WriteLine("Three");
    //            break;
    //        case 4:
    //            Console.WriteLine("Four");
    //            break;
    //        case 5:
    //            Console.WriteLine("Five");
    //            break;
    //        case 6:
    //            Console.WriteLine("Six");
    //            break;
    //        case 7:
    //            Console.WriteLine("Seven");
    //            break;
    //        case 8:
    //            Console.WriteLine("Eight");
    //            break;
    //        case 9:
    //            Console.WriteLine("Nine");
    //            break;
    //        default:
    //            Console.WriteLine("Invalid number!");
    //            break;
    //    }
    //    return lastDigit;
    //}

    static void Main()
    {
        Console.WriteLine("Enter a number:");
        LastDigitAsWord();  //If use case 2, here must be add reading of number n and parameters in the method
    }
}

     