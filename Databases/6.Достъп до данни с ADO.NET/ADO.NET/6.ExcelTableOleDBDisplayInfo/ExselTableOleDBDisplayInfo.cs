using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace _6.ExcelTableOleDBDisplayInfo
{
    //6.Create an Excel file with 2 columns: name and score:
    //Write a program that reads your MS Excel file through the OLE DB data 
    //provider and displays the name and score row by row.

    class ExselTableOleDBDisplayInfo
    {
        static void Main(string[] args)
        {
            OleDbConnection dbconn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"DataSourse=D:\Telerik kursove\Бази данни\Homeworks\6.Достъп до данни с ADO.NET\ADO.NET\6.ExcelTableOleDBDisplayInfo\Table.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""");
            OleDbCommand displayNameandScore = new OleDbCommand("SELECT * FROM [Sheet1$]", dbconn);
            dbconn.Open();
            OleDbDataReader reader = displayNameandScore.ExecuteReader();
            
                while (reader.Read())
                {
                    string name = (string)reader["Name"];
                    string score = (string)reader["Score"];
                    Console.WriteLine("{0} - {1}", name, score);
                }
                dbconn.Close();
            
        }
    }
}
