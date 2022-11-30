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
    public partial class OperatorMenu : Form
    {
        string numeOperator;

        public OperatorMenu(string nume)
        {
            InitializeComponent();
            this.numeOperator = nume;
        }

        private void OperatorMenu_Load(object sender, EventArgs e)
        {
            Label.Text = $"Bun venit {numeOperator}";
        }

        private void TranzactiiButton_Click(object sender, EventArgs e)
        {
            Tranzactii t = new Tranzactii();
            this.Hide();
            if (t.ShowDialog() == DialogResult.OK)
            {

            }
            this.Show();
        }

        private void SumeButton_Click(object sender, EventArgs e)
        {
            SumeTotale s = new SumeTotale();
            this.Hide();
            if (s.ShowDialog() == DialogResult.OK)
            {

            }
            this.Show();
        }

        private void ConutriExistenteButton_Click(object sender, EventArgs e)
        {
            ConturiExistente c = new ConturiExistente();
            this.Hide();
            if (c.ShowDialog() == DialogResult.OK)
            {

            }
            this.Show();
        }

        private void RaportButton_Click(object sender, EventArgs e)
        {
            RaportTranzactii r = new RaportTranzactii();
            this.Hide();
            if (r.ShowDialog() == DialogResult.OK)
            {

            }
            this.Show();

        }

        private void DepunereButton_Click(object sender, EventArgs e)
        {
            DepunereOperator d = new DepunereOperator();
            this.Hide();
            if (d.ShowDialog() == DialogResult.OK)
            {

            }
            this.Show();
        }

        private void InapoiButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Retragere_Click(object sender, EventArgs e)
        {
            RetragereOperator r = new RetragereOperator();
            this.Hide();
            if (r.ShowDialog() == DialogResult.OK)
            {

            }
            this.Show();
        }

        private void SoldButton_Click(object sender, EventArgs e)
        {
            InterogareSold i = new InterogareSold();
            this.Hide();
            if (i.ShowDialog() == DialogResult.OK)
            {

            }
            this.Show();
        }
    }
}
