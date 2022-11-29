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
    public partial class CautareConturi : Form
    {
        public static string selectat;
        public CautareConturi()
        {
            InitializeComponent();
        }

        private void CNPBox_TextChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            string lastCNP = " ";
            MySqlCommand c = new MySqlCommand($"SELECT * FROM `conturibancare` WHERE `cnp` like '{CNPBox.Text}%'", ConnectionDB.conectiune());
            MySqlDataReader r = c.ExecuteReader();
            while (r.Read())
            {
                if (lastCNP != r[0].ToString())
                {
                    listBox.Items.Add(" ");
                    listBox.Items.Add("CNP - " + r[0].ToString());
                    listBox.Items.Add(" ");
                    lastCNP = r[0].ToString();
                }
                listBox.Items.Add(r[1].ToString());
            }
        }

        private void CautareConturi_Load(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            string lastCNP = " ";
            MySqlCommand c = new MySqlCommand($"SELECT * FROM `conturibancare` WHERE `cnp` like '{CNPBox.Text}%'", ConnectionDB.conectiune());
            MySqlDataReader r = c.ExecuteReader();
            while (r.Read())
            {
                if (lastCNP != r[0].ToString())
                {
                    listBox.Items.Add(" ");
                    listBox.Items.Add("CNP - " + r[0].ToString());
                    listBox.Items.Add(" ");
                    lastCNP = r[0].ToString();
                }
                listBox.Items.Add(r[1].ToString());
            }
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            if (listBox.SelectedItem.ToString() != " " && listBox.SelectedItem.ToString().Contains("CNP") != true)
            {
                selectat = listBox.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Selectati un cont bancar");
            }
        }
    }
}
