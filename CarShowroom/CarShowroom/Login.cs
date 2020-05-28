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
            sr = Showroom.GetShowroom();
            admin = new Admin();
        }

        Admin admin;

        private void registerButton_Click(object sender, EventArgs e)
        {
            var RF = new Registration(); //Registration form
            var c = RF.ShowDialog(); // showroom 
            if(c == DialogResult.OK)
            {
                sr.Clients.Add(RF.client); //adding a new client
            }
        }

        Showroom sr;

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
            if(admin.login == loginBox.Text)
            {
                if(admin.password == passwordBox.Text)
                {
                    //new Main().ShowDialog
                }
            }
            
            foreach(Client c in sr.Clients)
            {
                if(c.login == loginBox.Text)
                {
                    if(c.password == passwordBox.Text)
                    {
                        Hide();
                        new Main(c).Show();
                    }
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            sr.Save();
        }
    }
}
