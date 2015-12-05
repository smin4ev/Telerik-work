using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.CreateDbContext;

namespace _3.OrderInYearInCountry
{
    //3.Write a method that finds all customers who have orders made in 1997 and shipped to Canada.

    class OrderInYearInCountry
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wait a moment...");
            OrderInYearInCountryName(1997, "Canada");
        }
        public static void OrderInYearInCountryName(int yearOfOrder, string shippedCountry)
        {
            var northwindDBcontent = new NorthwindEntities();
            using (northwindDBcontent)
            {
                var orders = from order in northwindDBcontent.Orders
                             where order.OrderDate.Value.Year == yearOfOrder && order.ShipCountry == shippedCountry
                             select order;


                foreach (var diffOrder in orders)
                {
                    Console.WriteLine("Name of customer is {0}, with ID {1}, shipping country - {2}, on {3}.",
                        diffOrder.Customer.ContactName, diffOrder.Customer.CustomerID, diffOrder.ShipCountry, diffOrder.ShippedDate);
                }
            }
        }
    }
}
