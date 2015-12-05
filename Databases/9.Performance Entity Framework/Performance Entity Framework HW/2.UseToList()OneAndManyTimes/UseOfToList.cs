using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.CreateDbContext;

namespace _2.UseToList__OneAndManyTimes
{
    //2.Using Entity Framework write a query that selects all employees from the Telerik Academy database, 
    //then invokes ToList(), then selects their addresses, then invokes ToList(), then selects their towns, 
    //then invokes ToList() and finally checks whether the town is "Sofia". Rewrite the same in more 
    //optimized way and compare the performance.


    public class UseOfToList
    {
        static void Main(string[] args)
        {
            TelerikAcademyEntities db = new TelerikAcademyEntities();

            var selectedItems_slow = db.Employees.ToList()
                .Select(e => e.Address).ToList()
                .Select(a => a.Town).ToList()
                .Where(t => t.Name == "Sofia").ToList();

            foreach (var item in selectedItems_slow)
            {
                Console.WriteLine(item.Name);
            }

            var selectedItems_fast = db.Employees
                .Select(e => e.Address)
                .Select(e => e.Town)
                .Where(t => t.Name == "Sofia").ToList();

            foreach (var item in selectedItems_fast)
            {
                Console.WriteLine(item.Addresses);
            }
        }
    }
}
