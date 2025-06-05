using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
namespace Attendance_Register_App
{
    public class DatabaseConnection
    {
        public void connect()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=AdventureWorks2022;Integrated Security=True;"; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error connecting to the database: " + ex.Message);
                    return;
                }
            }
            Console.WriteLine("Database connection established.");
        }
    }
    
}
