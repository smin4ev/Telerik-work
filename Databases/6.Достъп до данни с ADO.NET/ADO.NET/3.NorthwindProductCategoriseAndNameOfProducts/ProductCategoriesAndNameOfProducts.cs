using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace _3.NorthwindProductCategoriseAndNameOfProducts
{
    //3.Write a program that retrieves from the Northwind database all product categories and the names of the 
    //products in each category. Can you do this with a single SQL query (with table join)?

    class ProductCategoriesAndNameOfProducts
    {
        static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
           "Database=Northwind; Integrated Security=true");

            dbCon.Open();
            using (dbCon)
            {
                SqlCommand productCategoriesAndNameOfProducts = new SqlCommand(
                    "SELECT c.CategoryName, p.ProductName FROM  Categories c INNER JOIN Products p ON p.CategoryID = c.CategoryID;", dbCon);
                SqlDataReader reader = productCategoriesAndNameOfProducts.ExecuteReader();
                using (reader)
                {
                    int i = 1;
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string productName = (string)reader["ProductName"];
                        Console.WriteLine("{0}.{1} - {2}",i,categoryName, productName);
                        i++;
                    }
                }
            }

        }
    }
}
