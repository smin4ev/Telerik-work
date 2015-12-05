using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StructurePoint3D
{
    //3 task
    static class DistanceIn3D
    {
        public static double DistanseBetweenTwoPointsIn3DSpace(Point3D firstPoint, Point3D secondPoint)
        {
            double result = Math.Sqrt(Math.Pow(secondPoint.X - firstPoint.X, 2) + Math.Pow(secondPoint.Y - firstPoint.Y, 2) + Math.Pow(secondPoint.Z - firstPoint.Z, 2));
            return result;
        }

    }
}
