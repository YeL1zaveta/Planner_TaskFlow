using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WAF
{
    public partial class Home : Form
    {
        string filenote = "notes.txt";

        public Home()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log out!");
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Calendar = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            string Titleofnote = textBox.Text;
            string Note = richTextBox.Text;

            if (string.IsNullOrEmpty(Note))
            {
                MessageBox.Show("Write something...");
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(filenote, true)) // true - otwieramy plik w trybie dopisywania
                {
                    writer.WriteLine($"{Calendar};{Titleofnote};{Note}");
                }
                MessageBox.Show("User data saved successfully!");

                richTextBox.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving data: " + ex.Message);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Calendar = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");

            using (StreamReader stream = new StreamReader(filenote))
            {
                string line;

                while ((line = stream.ReadLine()) != null)
                {
                    string[] data = line.Split(';');
                    if (data[0] == Calendar)
                    {
                        MessageBox.Show("Data found: " + data[0] + "\nNote: " + data[1]);

                        break;
                    }
                }
               

            }
        }
    }
    }

