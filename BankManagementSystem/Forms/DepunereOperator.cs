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
using MySql.Data.MySqlClient;

namespace BankManagementSystem.Forms
{
    public partial class DepunereOperator : Form
    {
        public DepunereOperator()
        {
            InitializeComponent();
        }

        private void InapoiButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CautareButton_Click(object sender, EventArgs e)
        {
            CautareConturi c = new CautareConturi();
            if (c.ShowDialog() == DialogResult.OK)
            {
                ContBox.Text = CautareConturi.selectat;
            }

        }

        private void DepunereBox_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `conturibancare` WHERE `nrCont`='{ContBox.Text}'", ConnectionDB.conectiune());
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (SumaBox.Text != "" && rdr.HasRows == true)
            {
                rdr.Close();
                float suma = float.Parse(SumaBox.Text);
                Operator.DepunereNumerar(suma, ContBox.Text, Classes.ConnectionDB.conectiune());
                float sumaDepusa = suma - (suma * (float)0.01);
                MessageBox.Show($"Ati depus {sumaDepusa} {ContBox.Text.Substring(0, 3)} in contul {ContBox.Text} cu succes");
                this.DialogResult = DialogResult.OK;
            }
            else if (rdr.HasRows != true)
            {
                MessageBox.Show("Acest cont nu exista la banca noastra, va rugam sa verificati din nou!");
            }
            else
                MessageBox.Show("Nu ati introdus suma dorita!");
        }
    }
}
