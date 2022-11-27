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
    public partial class Retragere : Form
    {
        long cnpClient;
        string nrContClient;
        public Retragere(long cnp,string nrCont)
        {
            InitializeComponent();
            this.cnpClient = cnp;
            this.nrContClient = nrCont;
        }

        private void RetragereButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Classes.ConnectionDB.conectiune();
            if (SumaBox.Text != "")
            {
                ContBancar.RetragereNumerar(float.Parse(SumaBox.Text), nrContClient, cnpClient, conn);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Nu ati introdus suma dorita!");
        }

        private void Retragere_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = Classes.ConnectionDB.conectiune();
            MySqlCommand cmd = new MySqlCommand($"SELECT sold FROM `conturibancare` WHERE cnp={cnpClient} and `nrCont`='{nrContClient}'", conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            SoldLabel.Text = $"{rdr["sold"].ToString()} {nrContClient.Substring(0, 3)}";
            MonedaLabel.Text = nrContClient.Substring(0, 3);
        }
    }
}
