using BankManagementSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem.Forms
{
    public partial class LogInOperator : Form
    {
        public LogInOperator()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterOperator r = new RegisterOperator();
            this.Hide();
            if (r.ShowDialog() == DialogResult.OK)
            {

            }
            this.Show();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConnectionDB.conectiune();



            MySqlCommand command = new MySqlCommand($"SELECT * FROM operatorii Where user='{UserBox.Text}' and password={PasswordBox.Text };", conn);
            MySqlDataReader reader = command.ExecuteReader();



            if (reader.HasRows == false)
            {
                MessageBox.Show("Contul a fost introdus gresit sau nu aveti cont de operator la banca noastra!");
            }
            else
            {
                reader.Close();
                command = new MySqlCommand($"SELECT valid FROM operatorii Where user='{UserBox.Text}' and password={PasswordBox.Text };", conn);
                reader = command.ExecuteReader();
                reader.Read();

                if (reader["valid"].ToString().Equals("True") == true)
                {

                    this.Hide();
                    
                    this.Show();
                    conn.Close();
                    reader.Close();

                }
                else
                    MessageBox.Show("Contul dumneavoastra nu a fost validat momentan!");

            }
        }
    }
}

