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
            string connectionString = "Data Source=localhost;Initial Catalog=AttendanceDB;Integrated Security=True;"; // Adjust the connection string as needed
            Console.WriteLine("Database connection established.");
        }
    }
    
}
