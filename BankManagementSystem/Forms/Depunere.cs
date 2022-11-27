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
    public partial class Depunere : Form
    {
        string numeClient;
        long cnpClient;
        string contClient;
        public Depunere(string nume, long cnp, string cont)
        {
            InitializeComponent();
            this.numeClient = nume;
            this.cnpClient = cnp;
            this.contClient = cont;
        }

        private void DepunereButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Classes.ConnectionDB.conectiune();

            if (SumaBox.Text != "")
            {
                ContBancar.DepunereNumerar(float.Parse(SumaBox.Text), contClient, cnpClient, conn);
                conn.Close();
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Nu ati introdus suma dorita!");

        }

        private void Depunere_Load(object sender, EventArgs e)
        {
            label.Text = contClient.Substring(0, 3);
        }
    }
}
