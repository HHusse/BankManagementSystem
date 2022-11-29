using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BankManagementSystem.Forms
{
    public partial class SelectareContBancar : Form
    {
        string numeClient;
        long cnpClient;
        string nrContClient;
        public SelectareContBancar(string nume, long cnp)
        {
            InitializeComponent();
            this.numeClient = nume;
            this.cnpClient = cnp;

        }

        void refreshContTabel()
        {
            Conturi.Items.Clear();
            MySqlConnection conn = Classes.ConnectionDB.conectiune();

            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `conturibancare` WHERE cnp={cnpClient}", conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.HasRows==false)
            {
                this.Close();
            }

            while (rdr.Read())
                Conturi.Items.Add(rdr["nrCont"].ToString());



            conn.Close();
            rdr.Close();
        }

        private void SelectareContBancar_Load(object sender, EventArgs e)
        {
            refreshContTabel();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            ClientMenu c = new ClientMenu(cnpClient, numeClient, nrContClient);
            this.Hide();
            if(c.ShowDialog()==DialogResult.OK)
            {
                refreshContTabel();
                this.Show();
            }
            
        }

        private void Conturi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.nrContClient = Conturi.SelectedItem.ToString();
            }
            catch(Exception)
            {

            }
        }

        private void InapoiButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Conturi_DoubleClick(object sender, EventArgs e)
        {
            ClientMenu c = new ClientMenu(cnpClient, numeClient, nrContClient);
            this.Hide();
            if (c.ShowDialog() == DialogResult.OK)
            {
                refreshContTabel();
                this.Show();
            }
        }
    }
}
