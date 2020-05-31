using CarShowroom.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShowroom
{
    public partial class ClientCarForm : Form
    {
        //Форма автопідбору авто за параметрами
        public Client client { get; set; }
        
        public ClientCarForm(Client client)
        {
            InitializeComponent();
            this.client = client;
            brandComboBox.Text = client.Brand;
            statusComboBox.Text  = client.Status ;
            specsComboBox.Text = client.Specs; 
            budgetTextBox.Text = client.Budget.ToString();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            client.Brand = brandComboBox.Text;
            client.Status = statusComboBox.Text;
            client.Specs = specsComboBox.Text;
            client.Budget = int.Parse(budgetTextBox.Text);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClientCarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                return;
        }
    }
}
