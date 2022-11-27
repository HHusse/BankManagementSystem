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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private DateTime calcZiuaNasterii()
        {
            DateTime dataNasterii = DateTime.Now;
            try
            {
                if (CNPBox.Text.Substring(0, 1) == "5")
                {
                    int an = 2000 + Convert.ToInt32(CNPBox.Text.Substring(1, 2));
                    int luna = Convert.ToInt32(CNPBox.Text.Substring(3, 2));
                    int zi = Convert.ToInt32(CNPBox.Text.Substring(5, 2));
                    dataNasterii = new DateTime(an, luna, zi);
                }
                if (CNPBox.Text.Substring(0, 1) == "6")
                {
                    int an = 2000 + Convert.ToInt32(CNPBox.Text.Substring(1, 2));
                    int luna = Convert.ToInt32(CNPBox.Text.Substring(3, 2));
                    int zi = Convert.ToInt32(CNPBox.Text.Substring(5, 2));
                    dataNasterii = new DateTime(an, luna, zi);
                }
                if (CNPBox.Text.Substring(0, 1) == "1")
                {
                    int an = 1900 + Convert.ToInt32(CNPBox.Text.Substring(1, 2));
                    int luna = Convert.ToInt32(CNPBox.Text.Substring(3, 2));
                    int zi = Convert.ToInt32(CNPBox.Text.Substring(5, 2));
                    dataNasterii = new DateTime(an, luna, zi);
                }
                if (CNPBox.Text.Substring(0, 1) == "2")
                {
                    int an = 1900 + Convert.ToInt32(CNPBox.Text.Substring(1, 2));
                    int luna = Convert.ToInt32(CNPBox.Text.Substring(3, 2));
                    int zi = Convert.ToInt32(CNPBox.Text.Substring(5, 2));
                    dataNasterii = new DateTime(an, luna, zi);
                }
                if (CNPBox.Text.Substring(0, 1) == "3")
                {
                    int an = 1800 + Convert.ToInt32(CNPBox.Text.Substring(1, 2));
                    int luna = Convert.ToInt32(CNPBox.Text.Substring(3, 2));
                    int zi = Convert.ToInt32(CNPBox.Text.Substring(5, 2));
                    dataNasterii = new DateTime(an, luna, zi);
                }
                if (CNPBox.Text.Substring(0, 1) == "4")
                {
                    int an = 1800 + Convert.ToInt32(CNPBox.Text.Substring(1, 2));
                    int luna = Convert.ToInt32(CNPBox.Text.Substring(3, 2));
                    int zi = Convert.ToInt32(CNPBox.Text.Substring(5, 2));
                    dataNasterii = new DateTime(an, luna, zi);
                }
            }
            catch (Exception)
            {
                dataNasterii = DateTime.Now;
            }

            return dataNasterii;
        }

        private void ValidareButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = Classes.ConnectionDB.citireConnectiune();
            bool exista = true;

            try
            {
                conn.Open();

            }
            catch (MySqlException)
            {
                MessageBox.Show("Au aparut probleme la conectarea la baza de date!");
                this.Close();
            }

            if (CNPBox.Text != "" && NumeBox.Text != "" && PrenumeBox.Text != "")
            {
                MySqlCommand command = new MySqlCommand($"SELECT * FROM clientii where cnp={CNPBox.Text};", conn);
                MySqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows == false)
                {
                    exista = false;
                }


                if (CNPBox.Text.Length == 13 && calcZiuaNasterii() != DateTime.Now && exista == false)
                {
                    RegisterButton.Enabled = true;

                }
                else if (exista == true)
                {
                    MessageBox.Show("Aveti deja un cont la banca noastra!");
                }
                else
                {
                    MessageBox.Show("Ati introdus gresit CNP-ul!");
                    RegisterButton.Enabled = false;
                }
            }

            else
            {
                MessageBox.Show("Nu ati completat toate informatiile!");
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (UserBox.Text != "" && PINBox.Text != "")
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = Classes.ConnectionDB.citireConnectiune();
                DateTime dataN = calcZiuaNasterii();
                Client client;
                client = new Client(NumeBox.Text, PrenumeBox.Text, Convert.ToInt64(CNPBox.Text), dataN, UserBox.Text, Convert.ToInt32(PINBox.Text));


                conn.Open();
                MySqlCommand command = new MySqlCommand($"SELECT * FROM loginclient where user='{UserBox.Text}';", conn);
                MySqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows == false)
                {
                    reader.Close();
                    client.adaugare(conn);
                    this.Close();
                }

                else
                    MessageBox.Show("Numele de utilizator " + UserBox.Text + " exista deja, va va rugam introduceti alt nume de utilizator");
            }

            else
                MessageBox.Show("Nu ati completat user si pin-ul!");




        }

        private void NumeBox_TextChanged(object sender, EventArgs e)
        {
            RegisterButton.Enabled = false;
        }

        private void PrenumeBox_TextChanged(object sender, EventArgs e)
        {
            RegisterButton.Enabled = false;
        }

        private void CNPBox_TextChanged(object sender, EventArgs e)
        {
            RegisterButton.Enabled = false;
        }
    }
}
