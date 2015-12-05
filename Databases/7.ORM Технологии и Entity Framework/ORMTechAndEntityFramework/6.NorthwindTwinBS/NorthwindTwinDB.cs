using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.CreateDbContext;

namespace _6.NorthwindTwinBS
{
    //6.Create a database called NorthwindTwin with the same structure as Northwind using the features from DbContext. 
    //Find for the API for schema generation in MSDN or in Google.
    //Взаимствана от форума!!!

    class NorthwindTwinDB
    {
        static void Main(string[] args)
        {
            IObjectContextAdapter dataBase = new NorthwindEntities();
            string northwindScript = dataBase.ObjectContext.CreateDatabaseScript();
            string createNorthwindCloneDB = "USE master; " +
                                            "CREATE DATABASE NorthwindTwin; " +
                                            "SELECT name, size, size*1.0/128 AS [Size in MBs] " +
                                            "FROM sys.master_files " +
                                            "WHERE name = N'NorthwindTwin'; ";


            SqlConnection dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
                                                    "Database=master; Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand createCloneDB = new SqlCommand(createNorthwindCloneDB, dbCon);
                createCloneDB.ExecuteNonQuery();
                string changeDB = "USE  NorthwindTwin; ";
                SqlCommand changeDataB = new SqlCommand(changeDB, dbCon);
                changeDataB.ExecuteNonQuery();
                SqlCommand cloneDB = new SqlCommand(northwindScript, dbCon);
                cloneDB.ExecuteNonQuery();
            }
        }

    }
}
