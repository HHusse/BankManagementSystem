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
    }
}
