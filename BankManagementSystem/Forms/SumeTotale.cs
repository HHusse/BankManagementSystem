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
    public partial class SumeTotale : Form
    {
        public SumeTotale()
        {
            InitializeComponent();
        }

        private void SumeTotale_Load(object sender, EventArgs e)
        {
            TotalLabel.Text = $"{TotalLabel.Text} {Operator.SumeTotale()} RON ≈ {Operator.SumeTotale() * ConversionRate.Rate("RON", "EUR")} EUR ≈ " +
                $"{Operator.SumeTotale() * ConversionRate.Rate("RON", "USD")} USD";
            RONLabel.Text = $"{RONLabel.Text} {Operator.SumeRON()} RON";
            EURLabel.Text = $"{EURLabel.Text} {Operator.SumeEUR()} EUR";
            USDLabel.Text = $"{USDLabel.Text} {Operator.SumeUSD()} USD";

            chartRaport.Series[0].Points.AddXY("RON", Operator.SumeRON());
            chartRaport.Series[0].Points.AddXY("EUR", Operator.SumeEUR() * ConversionRate.Rate("EUR", "RON"));
            chartRaport.Series[0].Points.AddXY("USD", Operator.SumeUSD() * ConversionRate.Rate("USD", "RON"));
        }

        private void InapoiButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
