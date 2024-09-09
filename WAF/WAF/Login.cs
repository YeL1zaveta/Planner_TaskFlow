﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAF
{
    public partial class Login : Form
    {
        string fileuser = "users.txt";

        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Signin sign = new Signin();

            sign.Show();

            this.Hide();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = textBoxGmail.Text;
            string password = textBoxPass.Text;
            bool loginSuccessful = false;

            using (StreamReader stream = new StreamReader(fileuser))
            {
                string line;

                while ((line = stream.ReadLine()) != null)
                {
                    string[] data = line.Split(';');
                    if (data[1] == username && data[2] == password)
                    {
                        MessageBox.Show("Log in succesfuly!");

                        Home h = new Home();

                        h.Show();

                        this.Hide();
                        break;
                    }
                }
                if (!loginSuccessful)
                {
                    MessageBox.Show("Error, incorrect username or password. Please try again!");
                }

            }

        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Signin sign = new Signin();

            sign.Show();

            this.Hide();
        }
    }
    
}
