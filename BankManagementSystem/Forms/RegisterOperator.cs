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
using BankManagementSystem.Classes;

namespace BankManagementSystem.Forms
{
    public partial class RegisterOperator : Form
    {
        public RegisterOperator()
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

            MySqlConnection conn = Classes.ConnectionDB.conectiune();

            bool exista = true;

            if (CNPBox.Text != "" && NumeBox.Text != "" && PrenumeBox.Text != "")
            {
                MySqlCommand command = new MySqlCommand($"SELECT * FROM operatorii where cnp={CNPBox.Text};", conn);
                MySqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows == false)
                {
                    exista = false;
                }


                if (CNPBox.Text.Length == 13 && calcZiuaNasterii() != DateTime.Now && exista == false)
                {
                    RegisterButton.Enabled = true;
                    reader.Close();
                }
                else if (exista == true)
                {
                    MessageBox.Show("Aveti deja un cont de operator la banca noastra!");
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Ati introdus gresit CNP-ul!");
                    RegisterButton.Enabled = false;
                    reader.Close();
                }
            }

            else
            {
                MessageBox.Show("Nu ati completat toate informatiile!");
            }
            conn.Close();
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

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (UserBox.Text != "" && PasswordBox.Text != "")
            {
                MySqlConnection conn = ConnectionDB.conectiune();
                DateTime dataN = calcZiuaNasterii();
                Operator op;
                op = new Operator(NumeBox.Text, PrenumeBox.Text, Convert.ToInt64(CNPBox.Text), dataN, UserBox.Text, PasswordBox.Text);


                
                MySqlCommand command = new MySqlCommand($"SELECT * FROM operatorii where user='{UserBox.Text}';", conn);
                MySqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows == false)
                {
                    reader.Close();
                    op.adaugare(conn);
                    this.Close();
                }

                else
                    MessageBox.Show("Numele de utilizator " + UserBox.Text + " exista deja, va va rugam introduceti alt nume de utilizator");
            }

            else
                MessageBox.Show("Nu ati completat user si pin-ul!");

        }
    }
}
