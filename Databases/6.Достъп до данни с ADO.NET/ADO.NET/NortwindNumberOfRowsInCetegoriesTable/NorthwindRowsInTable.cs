using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace NortwindNumberOfRowsInCetegoriesTable
{
    //1.Write a program that retrieves from the Northwind sample database in MS SQL 
    //Server the number of  rows in the Categories table.


    class NorthwindRowsInTable
    {
        static void Main(string[] args)
        {
              SqlConnection dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
            "Database=Northwind; Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            { 
                SqlCommand numberOfRows = new SqlCommand("SELECT COUNT(*) FROM Categories", dbCon);
                int rowsNumber = (int)numberOfRows.ExecuteScalar();
                Console.WriteLine("Number of rows is Categories table is {0}", rowsNumber);
            }
        }
    }
}
