using CarShowroom.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShowroom
{
    public partial class Registration : Form
    {
        public Client client { get; set; }

        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (passwordBox.Text == confirmpassBox.Text)
                {
                    client = new Client()
                    {
                        password = passwordBox.Text,
                        login = loginBox.Text
                    };

                    try
                    {
                        client.email = new MailAddress(mailBox.Text);
                    }
                    catch (ArgumentException)
                    {
                      
                       
                    }
                    catch(FormatException)
                    {

                    }
                }
            }
            
        }

    }
}

