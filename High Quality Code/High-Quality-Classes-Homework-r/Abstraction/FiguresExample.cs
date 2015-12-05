namespace Abstraction
{
    using System;

    class FiguresExample
    {
        static void Main()
        {
            //Circle circle = new Circle(5);
            //Console.WriteLine("I am a circle. " +
            //    "My perimeter is {0:f2}. My surface is {1:f2}.",
            //    circle.CalculatePerimeter(), circle.CalcSurface());
            //Rectangle rect = new Rectangle(2, 3);
            //Console.WriteLine("I am a rectangle. " +
            //    "My perimeter is {0:f2}. My surface is {1:f2}.",
            //    rect.CalcPerimeter(), rect.CalcSurface());

            Circle myCircle = new Circle(3);
            Console.WriteLine("Perimeter of this circle is {0:f2}. Surface: {1:f2}", myCircle.CalculatePerimeter(), myCircle.CalculateSurface());

            Rectangle myRectangle = new Rectangle(5, 6);
            Console.WriteLine("Perimeter of this rectangle is {0:f2}. Surface - {1:f2}", myRectangle.CalculatePerimeter(), myRectangle.CalculateSurface());
        }
    }
}
