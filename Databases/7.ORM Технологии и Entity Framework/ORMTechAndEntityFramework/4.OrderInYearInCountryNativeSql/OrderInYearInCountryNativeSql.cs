using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.CreateDbContext;

namespace _4.OrderInYearInCountryNativeSql
{
    //4.Implement previous by using native SQL query and executing it through the DbContext.

    class OrderInYearInCountryNativeSql
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Waint a moment...");
            OrderInYearInCountryNativeSQLQuery(1997, "Canada");
        }

        static void OrderInYearInCountryNativeSQLQuery(int orderDate, string country)
        {
            using (var northwindDBcontent = new NorthwindEntities())
            {
                string sqlQuery = @"SELECT c.ContactName from Customers" +
                                  " c INNER JOIN Orders o ON o.CustomerID = c.CustomerID " +
                                  "WHERE (YEAR(o.OrderDate) = {0} AND o.ShipCountry = {1});";
                object[] parameters = { orderDate, country };
                var sqlQueryResult = northwindDBcontent.Database.SqlQuery<string>(sqlQuery, parameters);

                foreach (var order in sqlQueryResult)
                {
                    Console.WriteLine(order);
                }
            }
        }
    }
}
