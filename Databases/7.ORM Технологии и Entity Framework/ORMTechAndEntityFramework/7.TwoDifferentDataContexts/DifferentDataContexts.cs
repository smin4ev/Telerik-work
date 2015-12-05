using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.CreateDbContext;

namespace _7.TwoDifferentDataContexts
{
    //7.Try to open two different data contexts and perform concurrent changes on the same records. 
    //What will happen at SaveChanges()? How to deal with it?


    class DifferentDataContexts
    {
        static void Main(string[] args)
        {
            var northwindEntityDBFirst = new NorthwindEntities();
            using (northwindEntityDBFirst)
            {
                var northwindEntityDBSecond = new NorthwindEntities();
                using (northwindEntityDBSecond)
                {
                    Employee employeeFirst = northwindEntityDBFirst.Employees.Find(1);
                    employeeFirst.FirstName = "ANATOLI";

                    Employee employeeSecond = northwindEntityDBSecond.Employees.Find(1);
                    employeeSecond.FirstName = "ANATOLI";

                    northwindEntityDBFirst.SaveChanges();
                    northwindEntityDBSecond.SaveChanges();
                }
            }
            Console.WriteLine("Operation completed. See NorthwindDB!");
        }
    }
}
