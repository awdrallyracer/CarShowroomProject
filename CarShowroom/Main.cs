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
    //Форма адміністратора
    public partial class Main : Form
    {
        Showroom showroom;
        

        public Main()
        {
            InitializeComponent();
            showroom = Showroom.GetShowroom();
            try
            {
                carBindingSource.DataSource = showroom.Cars;
                clientBindingSource.DataSource = showroom.Clients;                
                carBindingSource.ResetBindings(false);
                clientBindingSource.ResetBindings(false);
            }
            catch (Exception)
            {

            }
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Завантажити дані
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showroom.Load();
            carBindingSource.ResetBindings(false);
        }
        //Зберегти дані
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showroom.Save();
        }
        //Додати автомобіль
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cf = new CarForm();
            if (cf.ShowDialog() == DialogResult.OK)
            {
                showroom.AddCar(cf.Car);
                carBindingSource.ResetBindings(false);
                showroom.IsDirty = true;
            }
        }
        //Відредагувати автомобіль
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toEdit = carlistGridView.SelectedRows[0].DataBoundItem as Car;
            var cf = new CarForm(toEdit);
            if (cf.ShowDialog() == DialogResult.OK)
            {
                carBindingSource.ResetBindings(false);
                showroom.IsDirty = true;
            }
        }
        //Видалити автомобіль
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toDel = carlistGridView.SelectedRows[0].DataBoundItem as Car;
            var res = MessageBox.Show($"Delete {toDel.Brand} ?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                showroom.Cars.Remove(toDel);
                carBindingSource.ResetBindings(false);
                showroom.IsDirty = true;
            }
        }
        //Зареєструвати клієента
        private void newClientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var clf = new Registration();
            if (clf.ShowDialog() == DialogResult.OK)
            {
                showroom.AddClient(clf.client);
                clientBindingSource.ResetBindings(false);
                showroom.IsDirty = true;
            }
        }
        //Видалити клієнта
        private void deleteClientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var toDel = clientsGridView.CurrentRow.DataBoundItem as Client;
            var res = MessageBox.Show($"Delete {toDel.Brand} ?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                showroom.Clients.Remove(toDel);
                clientBindingSource.ResetBindings(false);
                showroom.IsDirty = true;
            }
        }
        private void clientsGridView_SelectionChanged(object sender, EventArgs e)
        {
            var c = clientsGridView.CurrentRow.DataBoundItem as Client;
            carBindingSource1.DataSource = c.Cars;
            carBindingSource1.ResetBindings(false);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CarShowroom Application", "About");
        }
    }
}
