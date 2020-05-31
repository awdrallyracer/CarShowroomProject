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
        //Завантаження збережених даних
        private void ClientForm_Load(object sender, EventArgs e)
        {
            carBindingSource.DataSource = showroom.Cars;
            ordersBindingSource.DataSource = client.Cars;
            carBindingSource.ResetBindings(false);
            ordersBindingSource.ResetBindings(false);
        }
        //Придбання
        private void buyButton_Click(object sender, EventArgs e)
        {

            var toAdd = carGridView.CurrentRow.DataBoundItem as Car;
            var mbReult = MessageBox.Show($"Are you sure you want to buy {toAdd.Brand} {toAdd.Specs}?", "Confirm", MessageBoxButtons.YesNo);
            if (mbReult == DialogResult.Yes)
            {
                client.Cars.Add(toAdd);
                showroom.IsDirty = true;
            }
            ordersBindingSource.ResetBindings(false);

        }
        private void Cars_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!showroom.IsDirty)
                return;
            var res = MessageBox.Show("Save data before exit?", "", MessageBoxButtons.YesNoCancel);
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    showroom.Save();
                    break;
                case DialogResult.No:
                    break;
            }

        }
        //Вибир приорітету 
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

        private void priorirtButton_Click(object sender, EventArgs e)
        {
            var cf = new ClientCarForm(client);
            if (cf.ShowDialog() == DialogResult.OK)
            {
                showroom.IsDirty = true;
            }
        }
        //Відміна замовлення клієнтом
        private void deleteOrderButton2_Click(object sender, EventArgs e)
        {
            var toDel = dataGridView1.CurrentRow.DataBoundItem as Car;
            var res = MessageBox.Show($"Delete {toDel.Brand} ?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                client.Cars.Remove(toDel);
                ordersBindingSource.ResetBindings(false);
                showroom.IsDirty = true;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
