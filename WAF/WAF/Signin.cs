using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WAF;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WAF
{
    public partial class Signin : Form
    {
        string fileuser = "users.txt";

        public Signin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            login.Show();

            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = NewtextBoxName.Text;
            string gmail = NewtextBoxGmail.Text;
            string password = NewtextBoxPass.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(gmail) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("");
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(fileuser, true)) // true - otwieramy plik w trybie dopisywania
                {
                    writer.WriteLine($"{name};{gmail};{password}");
                }
                MessageBox.Show("User data saved successfully!");

                NewtextBoxName.Clear();
                NewtextBoxGmail.Clear();
                NewtextBoxPass.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving data: " + ex.Message);
            }
            this.Hide();
            Home h = new Home();
            h.Show();
        }

    }
}

