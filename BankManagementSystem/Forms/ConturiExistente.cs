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
    public partial class ConturiExistente : Form
    {
        public ConturiExistente()
        {
            InitializeComponent();
        }

        private void ConturiExistente_Load(object sender, EventArgs e)
        {
            TotalLabel.Text = $"{TotalLabel.Text} {Operator.ConturiTotale()} conturi";
            RONLabel.Text = $"{RONLabel.Text} {Operator.ConturiRON()} conturi";
            EURLabel.Text = $"{EURLabel.Text} {Operator.ConturiEUR()} conturi";
            USDLabel.Text = $"{USDLabel.Text} {Operator.ConturiUSD()} conturi";
            chartRaport.Series[0].Points.AddXY("RON", Operator.ConturiRON());
            chartRaport.Series[0].Points.AddXY("EUR", Operator.ConturiEUR());
            chartRaport.Series[0].Points.AddXY("USD", Operator.ConturiUSD());
        }

        private void InapoiButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
