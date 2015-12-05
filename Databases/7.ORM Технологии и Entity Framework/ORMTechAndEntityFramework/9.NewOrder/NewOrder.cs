using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.CreateDbContext;

namespace _9.NewOrder
{
    //9.Create a method that places a new order in the Northwind database. The order should contain several order items.
    //Use transaction to ensure the data consistency.


    class NewOrder
    {
        static void Main(string[] args)
        {
             Order newOrder = new Order(); 
             newOrder.CustomerID = "VINET"; 
             newOrder.EmployeeID = 5; 
             newOrder.OrderDate = new DateTime(2012, 3, 31); 
             newOrder.RequiredDate = new DateTime(2012, 4, 22); 
             newOrder.ShippedDate = new DateTime(2012, 4, 12); 
             newOrder.ShipVia = 3; 
             newOrder.Freight = 20.05M; 
             newOrder.ShipName = "Altaro rego";


             NewOrderInNorthwind(newOrder);
 
 

        }

        public static int NewOrderInNorthwind(Order newOrder)
        {
            var northwindEntityDB = new NorthwindEntities();
            using (northwindEntityDB)
            {
                var customer = northwindEntityDB.Customers.First(c => c.CustomerID == newOrder.CustomerID);
                if (customer != null) 
                 { 
                     newOrder.ShipAddress = customer.Address; 
                     newOrder.ShipCity = customer.City; 
                     newOrder.ShipPostalCode = customer.PostalCode; 
                     newOrder.ShipCountry = customer.Country; 
                 }
                northwindEntityDB.Orders.Add(newOrder);
                northwindEntityDB.Orders.Add(newOrder);
                northwindEntityDB.Orders.Add(newOrder);
                return northwindEntityDB.SaveChanges();

            }
        }
    }
}
