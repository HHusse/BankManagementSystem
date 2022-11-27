using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            Forms.LoginClient login = new Forms.LoginClient();
            this.Hide();
            if (login.ShowDialog() == DialogResult.OK)
            {
            }
            else
                this.Close();
        }

        private void operatorButton_Click(object sender, EventArgs e)
        {

        }
    }
}
