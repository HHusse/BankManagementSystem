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
    public partial class ClientNouMenu : Form
    {
        string numeClient;
        long cnpClient;
        public ClientNouMenu(string nume,long cnp)
        {
            InitializeComponent();
            this.numeClient = nume;
            this.cnpClient = cnp;
        }

        private void ClientMenu_Load(object sender, EventArgs e)
        {
            label1.Text = $"Bun venit la banca noastra, {numeClient}";
            
        }

        private void CreareContButton_Click(object sender, EventArgs e)
        {
            AdaugareContBancar a = new AdaugareContBancar(cnpClient);
            this.Hide();
            if (a.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
