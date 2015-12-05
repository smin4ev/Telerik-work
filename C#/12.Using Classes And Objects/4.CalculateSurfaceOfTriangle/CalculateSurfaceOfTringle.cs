using System;
using System.Collections.Generic;


class CalculateSurfaceOfTringle
{
    //Write methods that calculate the surface of a triangle by given:
    //Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math

    private static void surfaceBySideAndAltitude()
    {
        Console.Write("Enter side:");
        double side = double.Parse(Console.ReadLine());
        Console.Write("Enter altitude:");
        double altitude = double.Parse(Console.ReadLine());
        double surface =((side * altitude) / 2);
        Console.WriteLine(" The surface is {0}", surface);
        
    }
    private static void surfaceByThreeSides()
    {
        Console.Write("Enter first side:");
        double firstSide = double.Parse(Console.ReadLine());
        Console.Write("Enter second side:");
        double secondSide = double.Parse(Console.ReadLine());
        Console.Write("Enter third side:");
        double thirdSide = double.Parse(Console.ReadLine());
        double halfP = (firstSide + secondSide + thirdSide) / 2;
        double surface = Math.Sqrt(halfP * (halfP - firstSide) * (halfP - secondSide) * (halfP - thirdSide));
        Console.WriteLine(" The surface is {0}", surface);
    }
    private static void surfaceByTwoSidesAndAngle()
    {
        Console.Write("Enter first side:");
        double firstSide = double.Parse(Console.ReadLine());
        Console.Write("Enter second side:");
        double secondSide = double.Parse(Console.ReadLine());
        Console.Write("Enter a angle:");
        double angle = double.Parse(Console.ReadLine());
        double surface = (firstSide * secondSide * Math.Sin(Math.PI * angle / 180)) / 2;
        Console.WriteLine(" The surface is {0}", surface);
    }
         

    static void Main()
    {
        Console.WriteLine("According parameters that you have, choose way for decision of the task");
        Console.WriteLine("If you have one side and altitude - choise 1");
        Console.WriteLine("If you have three sides - choise 2");
        Console.WriteLine("If you have 2 sides and angle between them - choise 3");
        int choise = int.Parse(Console.ReadLine());

        switch (choise)
        {
            case 1:
                surfaceBySideAndAltitude();
                break;
            case 2:
                surfaceByThreeSides();
                break;
            case 3:
                surfaceByTwoSidesAndAngle();
                break;
            default:
                Console.WriteLine("Incorect choise!!");
                break;
        }

    }
}

