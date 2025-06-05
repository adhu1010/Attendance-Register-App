using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Register_App
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AttendanceRegister());

            // Create an instance of DatabaseConnection to call the connect method  
            DatabaseConnection dbConnection = new DatabaseConnection();
            dbConnection.connect(); // Ensure the database connection is closed when the application exits  
        }
    }
}
