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
    public partial class Order : Form
    {
        Showroom showroom;
        public Car Car { get; set; }

        public Order()
        {
            InitializeComponent();
            showroom = Showroom.GetShowroom();
            showroom.Load();
            carBindingSource.DataSource = showroom.Cars;
            carBindingSource.ResetBindings(false);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have already bought a car", "CONGRATULATIONS!");
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
