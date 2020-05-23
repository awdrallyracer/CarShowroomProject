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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var RF = new Registration(); //Registration form
            var c = RF.ShowDialog(); // showroom 
            if(c == DialogResult.OK)
            {
                sr.Clients.Add(RF.client); //adding a new client
            }
        }

        Showroom sr = new Showroom();

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                sr.Load();
            }
            catch
            {

            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            foreach(Client c in sr.Clients)
            {
                if(c.login == loginBox.Text)
                {
                    if(c.password == passwordBox.Text)
                    {
                        MessageBox.Show("You are registered");
                    }
                }
            }
        }
    }
}
