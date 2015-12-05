using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.CreateDbContext;

namespace _2.ResearchingIncludeMethod
{
    //Using Entity Framework write a SQL query to select all employees from the Telerik Academy database 
    //and later print their name, department and town. Try the both variants: with and without .
    //Include(…). Compare the number of executed SQL statements and the performance.

    class ResearchingIncludeMethod
    {

        static void Main(string[] args)
        {
            TelerikAcademyEntities db = new TelerikAcademyEntities();

            //Without .Include

            foreach (var employee in db.Employees)
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, Department:{2}, Town:{3}", employee.FirstName, employee.LastName, employee.Department.Name, employee.Address.Town.Name);
            }

            //With Include

            foreach (var employee in db.Employees.Include("Address"))
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, Department:{2}, Town:{3}", employee.FirstName, employee.LastName, employee.Department.Name, employee.Address.Town.Name);
            }

        }

        

        
    }
}
