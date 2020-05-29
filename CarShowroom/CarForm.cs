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
    public partial class CarForm : Form
    {
        public Car Car { get; set; }

        public CarForm() //Adding new car
        {
            InitializeComponent();
        }

        // To update an existing product.
        public CarForm(Car car) : this()
        {
            Car = car;
            carNameComboBox.Text = car.Brand;
            statusComboBox.Text = car.Status;
            specsComboBox.Text = car.Specs;
            descriptionTextBox.Text = car.Description;
            yearTextBox.Text = car.Year;
            priceNumericUpDown.Value = car.Price;
            photoPictureBox.Image = car.Image;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Car == null)
            {
                Car = new Car();
            }
            Car.Brand = carNameComboBox.Text;
            Car.Status = statusComboBox.Text;
            Car.Specs = specsComboBox.Text;
            Car.Description = descriptionTextBox.Text;
            Car.Year = yearTextBox.Text;
            Car.Price = priceNumericUpDown.Value;
            Car.Image = photoPictureBox.Image;
        }

        private void CarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                return;
        }

        private void photoPictureBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                photoPictureBox.Image = new Bitmap(openFileDialog1.FileName);
            }
        }



    }
}
