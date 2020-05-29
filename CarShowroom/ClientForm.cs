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
    public partial class ClientForm : Form
    {
        Client client;
        Showroom showroom;
        public ClientForm(Client client)
        {
            InitializeComponent();
            this.client = client;
            showroom = Showroom.GetShowroom();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            carBindingSource.DataSource = showroom.Cars;
            ordersBindingSource.DataSource = client.Cars;
            carBindingSource.ResetBindings(false);
            ordersBindingSource.ResetBindings(false);
        }
        private void buyButton_Click(object sender, EventArgs e)
        {

            var toAdd = carGridView.CurrentRow.DataBoundItem as Car;
            var mbReult = MessageBox.Show($"Are you sure you want to buy {toAdd.Brand} {toAdd.Specs}?", "Confirm", MessageBoxButtons.YesNo);
            if (mbReult == DialogResult.Yes)
            {
                client.Cars.Add(toAdd);
            }
            ordersBindingSource.ResetBindings(false);

        }
        private void Cars_FormClosing(object sender, FormClosingEventArgs e)
        {

            var res = MessageBox.Show("Save data before exit?", "", MessageBoxButtons.YesNoCancel);
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    showroom.Save();
                    Application.Exit();
                    break;
                case DialogResult.No:
                    Application.Exit();
                    break;
            }

        }

        private void noPriorityRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (priorityRadio.Checked)
            {
                carBindingSource.DataSource = showroom.Priority(client);

            }
            else
            {
                carBindingSource.DataSource = showroom.Cars;
            }
            carBindingSource.ResetBindings(false);
        }
    }
}
