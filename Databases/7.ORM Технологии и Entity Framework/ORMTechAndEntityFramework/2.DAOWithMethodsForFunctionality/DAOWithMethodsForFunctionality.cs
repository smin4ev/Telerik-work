

namespace _2.DAOWithMethodsForFunctionality
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using _1.CreateDbContext;

    public static class DAOWithMethodsForFunctionality
    {
        static void Main()
        {
            InsertCustomer("ABV", "Telerik", "Svetlin Nakov");
            //ModifyCustomer("ABV", "FIRMATA", "Svetlin Nakov");
            //DeleteCustomer("ABV", "FIRMATA", "Setlin NakoV");
         

        }

        //2.Create a DAO class with static methods which provide functionality for inserting, modifying and 
        //deleting customers. Write a testing class.
        //IF YOU WANT TO SEE CORECT RESULT YOU MUST START DIFFERENT METHODS AT DIFFERENT TIME!!

        public static void InsertCustomer(string customerID, string companyName, string contactName)
        {
            var northwindDBcontent = new NorthwindEntities();
            using (northwindDBcontent)
            {
                Customer customer = new Customer()
                {
                    CustomerID = customerID,
                    CompanyName = companyName,
                    ContactName = contactName,
                    Phone = null
                };
                northwindDBcontent.Customers.Add(customer);
                northwindDBcontent.SaveChanges();
                
            }
        }

        public static void ModifyCustomer(string customerID, string companyName, string contactName)
        {
            var northwindDBcontent = new NorthwindEntities();
            using (northwindDBcontent)
            {
                var customerForModify = northwindDBcontent.Customers.FirstOrDefault(c => c.CustomerID == customerID);
                customerForModify.CompanyName = companyName;
                northwindDBcontent.SaveChanges();
            }
        }

        public static void DeleteCustomer(string customerID, string companyName, string contactName)
        {
            var northwindDBcontent = new NorthwindEntities();
            using (northwindDBcontent)
            {
                var customerForDeleting = northwindDBcontent.Customers.FirstOrDefault(c => c.CompanyName == companyName);
                northwindDBcontent.Customers.Remove(customerForDeleting);
                northwindDBcontent.SaveChanges();
            }
        }
    }
}
