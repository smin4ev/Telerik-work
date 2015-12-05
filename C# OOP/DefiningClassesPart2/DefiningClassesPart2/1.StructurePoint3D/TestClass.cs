using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StructurePoint3D
{
    class TestClass
    {
        static void Main()
        {
            Point3D firstPoint = new Point3D(2,3,4);
            Point3D secondPoint = new Point3D(5,2,6);
            //firstPoint.X = 4; - ??????? С кои парапетри прави изчислението??
            //firstPoint.Y = 2;
            //firstPoint.Z = 5;
            //secondPoint.X = 1;
            //secondPoint.Y = 2;
            //secondPoint.Z = 7;

            double answer = DistanceIn3D.DistanseBetweenTwoPointsIn3DSpace(firstPoint, secondPoint);
            Console.WriteLine(answer);
        }
    }
}
