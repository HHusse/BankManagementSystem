using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem.Forms
{
    public partial class AdaugareContBancar : Form
    {
        long cnpClient;
        string nrcont;
        string monedaAleasa;
        public AdaugareContBancar(long cnp)
        {
            InitializeComponent();
            this.cnpClient = cnp;
        }

        private void RONButton_CheckedChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = Classes.ConnectionDB.citireConnectiune();
        Start:
            try
            {
                conn.Open();

            }
            catch (MySqlException)
            {
                MessageBox.Show("Au aparut probleme la conectarea la baza de date!");
                this.Close();
            }


            Random rnd = new Random();
            long x = rnd.Next(10000, 99999);
            nrcont = "RONBNC" + x;

            MySqlCommand command = new MySqlCommand("SELECT nrcont FROM conturibancare Where nrcont like '" + nrcont + "';", conn);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows == false)
            {
                textBox1.Text = nrcont;
                monedaAleasa = RONButton.Text;
            }
            else
            {
                reader.Close();
                conn.Close();
                goto Start;
            }

            conn.Close();
            reader.Close();


        }

        private void EURButton_CheckedChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = Classes.ConnectionDB.citireConnectiune();
        Start:
            try
            {
                conn.Open();

            }
            catch (MySqlException)
            {
                MessageBox.Show("Au aparut probleme la conectarea la baza de date!");
                this.Close();
            }


            Random rnd = new Random();
            long x = rnd.Next(10000, 99999);
            nrcont = "EURBNC" + x;

            MySqlCommand command = new MySqlCommand($"SELECT nrcont FROM conturibancare Where nrcont like '{nrcont}';", conn);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows == false)
            {
                textBox1.Text = nrcont;
                monedaAleasa = EURButton.Text;
            }
            else
            {
                reader.Close();
                conn.Close();
                goto Start;
            }

            conn.Close();
            reader.Close();
        }

        private void USDButton_CheckedChanged(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = Classes.ConnectionDB.citireConnectiune();
        Start:
            try
            {
                conn.Open();

            }
            catch (MySqlException)
            {
                MessageBox.Show("Au aparut probleme la conectarea la baza de date!");
                this.Close();
            }


            Random rnd = new Random();
            long x = rnd.Next(10000, 99999);
            nrcont = "USDBNC" + x;

            MySqlCommand command = new MySqlCommand("SELECT nrcont FROM conturibancare Where nrcont like '" + nrcont + "';", conn);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows == false)
            {
                textBox1.Text = nrcont;
                monedaAleasa = USDButton.Text;
            }
            else
            {
                reader.Close();
                conn.Close();
                goto Start;
            }

            conn.Close();
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
                this.Close();
            }


            MySqlCommand command = new MySqlCommand("SELECT * FROM clientii Where cnp=" + this.cnpClient + ";", conn);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string nume = reader["nume"].ToString();
            string prenume = reader["nume"].ToString();
            DateTime data = Convert.ToDateTime(reader["dataNasterii"].ToString());
            reader.Close();
            command = new MySqlCommand("SELECT * FROM loginclient Where cnp=" + this.cnpClient + ";", conn);
            reader = command.ExecuteReader();
            reader.Read();
            string user = reader["user"].ToString();
            int pin = Convert.ToInt32(reader["pin"].ToString());
            reader.Close();
            conn.Close();
            ContBancar c = new ContBancar(nume, prenume, this.cnpClient, data, user, pin, this.nrcont, DateTime.Now, this.monedaAleasa, 0);
            conn.Open();
            c.adaugareContBancar(conn);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
