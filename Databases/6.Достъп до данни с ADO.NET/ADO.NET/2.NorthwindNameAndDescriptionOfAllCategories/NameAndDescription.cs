using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace _2.NorthwindNameAndDescriptionOfAllCategories
{
    //2.Write a program that retrieves the name and description of all categories in the Northwind DB.

    class NameAndDescription
    {
        static void Main(string[] args)
        {
             SqlConnection dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
            "Database=Northwind; Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand cmdAllCategorise = new SqlCommand("SELECT CategoryName, Description FROM Categories ORDER BY CategoryID", dbCon);
                SqlDataReader reader = cmdAllCategorise.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string description = (string)reader["Description"];
                        Console.WriteLine("{0} - {1}", categoryName, description);

                    }
                }
            }
        }
    }
}
