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
    public partial class Tranzactii : Form
    {
        public Tranzactii()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GridView.DataSource = Operator.afisareData(NrContBox.Text, ConnectionDB.conectiune());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            GridView.DataSource = Operator.afisareData( NrContBox.Text, ConnectionDB.conectiune());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView.DataSource = Operator.afisareData(NrContBox.Text, ConnectionDB.conectiune());
        }

        private void Tranzactii_Load(object sender, EventArgs e)
        {
            GridView.DataSource = Operator.afisareData(NrContBox.Text, ConnectionDB.conectiune());
        }

        private void CautareButton_Click(object sender, EventArgs e)
        {
            CautareConturi c = new CautareConturi();
            if(c.ShowDialog()==DialogResult.OK)
            {
                NrContBox.Text = CautareConturi.selectat;
            }
        }

        private void InapoiButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
