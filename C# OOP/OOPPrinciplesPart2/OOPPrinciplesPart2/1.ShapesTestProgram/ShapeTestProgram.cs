using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ShapesTestProgram
{
    //Define abstract class Shape with only one abstract method CalculateSurface() 
    //and fields width and height. Define two new classes Triangle and Rectangle 
    //that implement the virtual method and return the surface of the figure 
    //(height*width for rectangle and height*width/2 for triangle). Define class 
    //Circle and suitable constructor so that at initialization height must be kept 
    //equal to width and implement the CalculateSurface() method. Write a program that 
    //tests the behavior of  the CalculateSurface() method for different shapes 
    //(Circle, Rectangle, Triangle) stored in an array.


    class ShapeTestProgram
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Triangle(3,4),
                new Triangle(5,7),
                new Rectangle(4,5),
                new Rectangle(2, 5.5),
                new Circle(5),
                new Circle(6),
                new Triangle(12,12)
            };
            int i = 1;
            foreach (var shape in shapes)
            {
                Console.WriteLine("Figure number {0} is {1} and its surface is {2}", i, shape.GetType().Name, shape.CalculateSurface() );
                i++;
            }

        }
        
    }
}
