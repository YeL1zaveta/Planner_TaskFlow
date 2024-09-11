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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
                textBox.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving data: " + ex.Message);
            }

        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string selectedDate = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");

            listView.Items.Clear();

            using (StreamReader stream = new StreamReader(filenote))
            {
                string line;
                bool noteFound = false; 

                while ((line = stream.ReadLine()) != null)
                {
                    string[] data = line.Split(';');

                    if (data[0] == selectedDate)
                    {
                        ListViewItem item = new ListViewItem(data[0]); 

                        if (data.Length > 1)
                        {
                            item.SubItems.Add(data[1]); 
                        }
                        else
                        {
                            item.SubItems.Add("No notes"); 
                        }

                        if (data.Length > 2)
                        {
                            item.SubItems.Add(data[2]); 
                        }
                        else
                        {
                            item.SubItems.Add(string.Empty);
                        }

                        listView.Items.Add(item); 
                        noteFound = true;
                        break; 
                    }
                }

                if (!noteFound)
                {
                    ListViewItem item = new ListViewItem(selectedDate); 
                    item.SubItems.Add("No notes found for this date."); 
                    listView.Items.Add(item); 
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

