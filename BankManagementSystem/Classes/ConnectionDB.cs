using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BankManagementSystem.Classes
{
    class ConnectionDB
    {
        public static String citireConnectiune()
        {
            return File.ReadAllText(@"C:\Users\Hossein\Desktop\BankManagementSystem\BankManagementSystem\conexiune.txt");
        }

        public static MySqlConnection conectiune()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = Classes.ConnectionDB.citireConnectiune();
            try
            {
                conn.Open();
                
            }
            catch (MySqlException)
            {
                MessageBox.Show("Au aparut probleme la conectarea la baza de date!");
                System.Windows.Forms.Application.Exit();
            }
            return conn;
        }

        
    }
}
