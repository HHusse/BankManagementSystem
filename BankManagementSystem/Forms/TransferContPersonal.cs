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
    public partial class TransferContPersonal : Form
    {
        long cnpClient;
        string nrContClient;
        public TransferContPersonal(long cnp, string nrCont)
        {
            InitializeComponent();
            this.cnpClient = cnp;
            this.nrContClient = nrCont;
        }

        private void TransferContPersonal_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = Classes.ConnectionDB.conectiune();
            MySqlCommand cmd = new MySqlCommand($"SELECT sold FROM `conturibancare` WHERE cnp={cnpClient} and `nrCont`='{nrContClient}'", conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            SoldLabel.Text = $"{rdr["sold"].ToString()} {nrContClient.Substring(0, 3)}";
            MonedaLabel.Text = nrContClient.Substring(0, 3);
            rdr.Close();
            cmd = new MySqlCommand($"SELECT * FROM `conturibancare` WHERE cnp={cnpClient} and `nrCont`!='{nrContClient}'", conn);
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows == false)
            {
                MessageBox.Show("Nu aveti alt cont bancar inafara de acesta!");
                this.Close();
            }
            while (rdr.Read())
            {
                ConturiBox.Items.Add(rdr["nrCont"].ToString());
            }
            conn.Close();
            rdr.Close();
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Classes.ConnectionDB.conectiune();
            if (SumaBox.Text != "" && ConturiBox.Text != "")
            {
                ContBancar.TransferConturi(float.Parse(SumaBox.Text), nrContClient, ConturiBox.Text, cnpClient, conn);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Nu ati completat toate detaliile cerute!");

        }
    }
}
