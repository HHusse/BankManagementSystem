using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BankManagementSystem.Classes;

namespace BankManagementSystem.Forms
{
    public partial class LoginClient : Form
    {
        public LoginClient()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = ConnectionDB.conectiune();



            MySqlCommand command = new MySqlCommand($"SELECT * FROM LoginClient Where user='{UserBox.Text}' and pin={PINBox.Text };", conn);
            MySqlDataReader reader = command.ExecuteReader();



            if (reader.HasRows == false)
            {
                MessageBox.Show("Contul a fost introdus gresit sau nu aveti cont la banca noastra!");
            }
            else
            {
                reader.Read();
                MySqlCommand command2 = new MySqlCommand($"SELECT clientii.nume, clientii.cnp FROM clientii, loginclient WHERE clientii.cnp={reader["cnp"].ToString()};", conn);
                reader.Close();
                MySqlDataReader rdr = command2.ExecuteReader();
                rdr.Read();
                long cnpClient = Convert.ToInt64(rdr["cnp"].ToString());
                string numeClient = rdr["nume"].ToString();
                rdr.Close();

                this.Hide();
            
                command2 = new MySqlCommand($"SELECT * FROM `conturibancare` WHERE cnp={cnpClient}", conn);
                rdr = command2.ExecuteReader();
                if (rdr.HasRows == false)
                {

                    ClientNouMenu c = new ClientNouMenu(numeClient, cnpClient);
                    if (c.ShowDialog() == DialogResult.OK)
                    {
                        SelectareContBancar s = new SelectareContBancar(numeClient, cnpClient);
                        if (s.ShowDialog() == DialogResult.OK)
                        {

                        }
                    }
                    this.Show();
                }
                else
                {
                    SelectareContBancar s = new SelectareContBancar(numeClient, cnpClient);
                    if (s.ShowDialog() == DialogResult.None)
                    {
                        

                    }
                    
                    this.Show();
                }
            }


        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            if (register.ShowDialog() == DialogResult.OK)
            {

            }
            this.Show();

        }

        private void UserBox_TextChanged(object sender, EventArgs e)
        {
            if (UserBox.Text != null && PINBox.Text.Length == 4)
            {
                LogInButton.Enabled = true;
            }
            else
            {
                LogInButton.Enabled = false;
            }

        }

        private void PINBox_TextChanged(object sender, EventArgs e)
        {
            if (UserBox.Text != null && PINBox.Text.Length == 4)
            {
                LogInButton.Enabled = true;
            }
            else
            {
                LogInButton.Enabled = false;
            }
        }
    }
}
