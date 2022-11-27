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
    public partial class Transfer : Form
    {
        string nrContClient;
        long cnpClient;
        public Transfer(long cnp,string nrCont)
        {
            InitializeComponent();
            this.cnpClient = cnp;
            this.nrContClient = nrCont;

        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = Classes.ConnectionDB.conectiune();
            MySqlCommand cmd = new MySqlCommand($"SELECT sold FROM `conturibancare` WHERE cnp={cnpClient} and `nrCont`='{nrContClient}'", conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            SoldLabel.Text = $"{rdr["sold"].ToString()} {nrContClient.Substring(0, 3)}";
            MonedaLabel.Text = nrContClient.Substring(0, 3);
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            if (CatreBox.Text != "" && SumaBox.Text != "")
            {
                if (CatreBox.Text.Substring(0, 3) == nrContClient.Substring(0, 3))
                {
                    MySqlConnection conn = Classes.ConnectionDB.conectiune();
                    ContBancar.TransferBancar(float.Parse(SumaBox.Text), nrContClient, CatreBox.Text, cnpClient, conn);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show($"Nu puteti transfera dintr-un cont {nrContClient.Substring(0, 3)} intr-un cont {CatreBox.Text.Substring(0, 3)}");
                }
            }
            else
                MessageBox.Show("Nu ati completat detalile cerute!");
        }
    }
}
