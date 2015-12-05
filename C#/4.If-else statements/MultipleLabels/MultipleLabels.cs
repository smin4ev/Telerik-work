//using System;

//class MultipleLabels
//{
//    static void Main()
//    {
//        Console.Write("Please enter some animal: ");
//        string animal = Console.ReadLine();

//        switch (animal)
//        {
//            case "dog":
//            case "cat":
//            case "cow":
//                Console.WriteLine("MAMMAL");
//                break;
//            case "crocodile":
//            case "tortoise":
//            case "snake":
//                Console.WriteLine("REPTILE");
//                break;
//            case "hawk":
//            case "sparrow":
//            case "dove":
//                Console.WriteLine("BIRD");
//                break;
//            default:
//                Console.WriteLine("I don't know this animal!");
//                break;
//        }
//    }
//}
using System;

class AllCards
{
    static void Main()
    {
        for (int i = 2; i < 15; i++)
        {

            for (int j = 1; j < 5; j++)
            {
                if (i < 11)
                {
                    Console.Write("{0} of ", i);
                }
                else
                {
                    switch (i)
                    {
                        case 11: Console.Write("King of ");
                            break;
                        case 12: Console.Write("Queen of ");
                            break;
                        case 13: Console.Write("Knave of ");
                            break;
                        case 14: Console.Write("Ace of ");
                            break;
                        default: Console.WriteLine("Error");
                            break;
                    }
                }
                switch (j)
                {
                    case 1: Console.Write("Spades");
                        break;
                    case 2: Console.Write("Hearts");
                        break;
                    case 3: Console.Write("Diamonds");
                        break;
                    case 4: Console.Write("Clubs");
                        break;
                    default: Console.WriteLine("Error");
                        break;
                }
                Console.WriteLine();
            }

        }
    }
}
