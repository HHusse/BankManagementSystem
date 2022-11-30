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
    public partial class RetragereOperator : Form
    {
        public RetragereOperator()
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

        private void RetragereBox_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `conturibancare` WHERE `nrCont`='{ContBox.Text}'", ConnectionDB.conectiune());
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (SumaBox.Text != "" && rdr.HasRows == true)
            {
                rdr.Close();
                float suma = float.Parse(SumaBox.Text);
                bool realizat = Operator.RetragereNumerar(suma, ContBox.Text, ConnectionDB.conectiune());
                if (realizat == true)
                {
                    float sumaRetrasa = suma - (suma * (float)0.01);
                    MessageBox.Show($"Ati retras suma {sumaRetrasa} {ContBox.Text.Substring(0, 3)} in contul {ContBox.Text} cu succes");
                    this.DialogResult = DialogResult.OK;
                }
            }
            else if (rdr.HasRows != true)
            {
                MessageBox.Show("Acest cont nu exista la banca noastra, va rugam sa verificati din nou!");
            }
            else
                MessageBox.Show("Nu ati introdus suma dorita!");
        }

        private void VerificareButton_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `conturibancare` WHERE `nrCont`='{ContBox.Text}'", ConnectionDB.conectiune());
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows == false)
            {
                MessageBox.Show("Acest cont nu exista la banca noastra, va rugam sa verificati din nou!");
            }
            else
            {
                rdr.Close();
                float sold = Operator.interogareSold(ContBox.Text);
                MessageBox.Show($"Soldul contului {ContBox.Text} este de {sold} {ContBox.Text.Substring(0, 3)}");
            }
        }
    }
}

