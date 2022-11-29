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
    public partial class RaportTranzactii : Form
    {
        public RaportTranzactii()
        {
            InitializeComponent();
        }

        private void RaportTranzactii_Load(object sender, EventArgs e)
        {
            TranzactiiLabel.Text = $"Sau efectuat {Operator.NumarTranzactiiZile(DataPicker.Value.ToString("dd/MM/yyyy"))} tranzactii in ziua {DataPicker.Text}";
            GridView.DataSource = Operator.TranzactiiZile(DataPicker.Value.ToString("dd/MM/yyyy"));
        }

        private void DataPicker_ValueChanged(object sender, EventArgs e)
        {
            TranzactiiLabel.Text = $"Sau efectuat {Operator.NumarTranzactiiZile(DataPicker.Value.ToString("dd/MM/yyyy"))} tranzactii in ziua {DataPicker.Text}";
            GridView.DataSource = Operator.TranzactiiZile(DataPicker.Value.ToString("dd/MM/yyyy"));
        }

        private void InapoiButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
