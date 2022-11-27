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
    public partial class ClientMenu : Form
    {
        string numeClient;
        long cnpClient;
        string nrContClient;

        public ClientMenu(long cnp, string nume, string nrCont)
        {
            InitializeComponent();
            this.numeClient = nume;
            this.cnpClient = cnp;
            this.nrContClient = nrCont;
        }

        private void ClientMenu_Load(object sender, EventArgs e)
        {
            label1.Text = $"Bun venit la banca noastrea, {numeClient}";
        }

        private void AdaugareContButton_Click(object sender, EventArgs e)
        {
            AdaugareContBancar a = new AdaugareContBancar(cnpClient);
            this.Hide();
            if (a.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void SoldButton_Click(object sender, EventArgs e)
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
            this.Hide();
            ContBancar.InterogareSold(cnpClient, nrContClient, conn);
            this.Show();
            conn.Close();
        }

        private void InapoiSelectareButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void DepunereButton_Click(object sender, EventArgs e)
        {
            Depunere d = new Depunere(numeClient, cnpClient, nrContClient);
            this.Hide();
            if (d.ShowDialog() == DialogResult.OK)
            {

            }
            this.Show();
        }

        private void RetragereButton_Click(object sender, EventArgs e)
        {
            Retragere r = new Retragere(cnpClient, nrContClient);
            this.Hide();
            if (r.ShowDialog() == DialogResult.OK)
            {

            }
            this.Show();
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            Transfer t = new Transfer(cnpClient, nrContClient);
            this.Hide();
            if (t.ShowDialog() == DialogResult.OK)
            {

            }
            this.Show();
        }

        private void LichidareButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Classes.ConnectionDB.conectiune();


            MySqlCommand cmdv = new MySqlCommand($"SELECT * FROM `conturibancare` WHERE  `cnp`={cnpClient} and `nrCont`='{nrContClient}';", conn);
            MySqlDataReader reader = cmdv.ExecuteReader();
            reader.Read();

            if (float.Parse(reader["sold"].ToString()) != 0)
            {
                MessageBox.Show("Trebuie sa retrageti toata suma existenta in acest cont inainte de a putea sa lichidati contul \n\n" +
                    $"Sold curent {reader["sold"].ToString()} {nrContClient.Substring(0,3)}");
            }
            else
            {
                reader.Close();
                ContBancar.LichidareCont(nrContClient, cnpClient, conn);
                this.DialogResult = DialogResult.OK;
            }

            conn.Close();
            
        }

        private void TransferContPersonalButton_Click(object sender, EventArgs e)
        {
            TransferContPersonal t = new TransferContPersonal(cnpClient, nrContClient);
            this.Hide();
            if(t.ShowDialog()==DialogResult.OK)
            {

            }
            this.Show();
        }
    }
}
