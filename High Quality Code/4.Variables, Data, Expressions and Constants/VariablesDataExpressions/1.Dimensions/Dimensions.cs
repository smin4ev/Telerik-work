using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Dimensions
{
    class Dimensions
    {
        static void Main(string[] args)
        {
            Size size = new Size(10, 16);

            Size rotateSize = Size.GetRotatedSize(size, 80);
            Console.WriteLine(size.Width);
            Console.WriteLine(size.Height);
            Console.WriteLine(rotateSize.Width);
            Console.WriteLine(rotateSize.Height);

        }
    }
}
