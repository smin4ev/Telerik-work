using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _4.NorthwindAddProductInProductsTable
{
   //4.Write a method that adds a new product in the products table in the Northwind database. Use a parameterized SQL command.

    class AddProductInProductsTable
    {
        static void Main(string[] args)
        {
            AddProduct("Boza", 30);
        }

        static void AddProduct(string productName, int unitsInOrder)
        { 
         SqlConnection dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
           "Database=Northwind; Integrated Security=true");

            dbCon.Open();
            using (dbCon)
            {
                SqlCommand addProduct = new SqlCommand("INSERT INTO Products (ProductName, UnitsOnOrder)" +
                    "VALUES(@ProductName, @UnitsInOrder) ", dbCon);
                addProduct.Parameters.AddWithValue("@ProductName", productName);
                addProduct.Parameters.AddWithValue("@UnitsInOrder", unitsInOrder);
                addProduct.ExecuteNonQuery();

            }
        }

    }
}
