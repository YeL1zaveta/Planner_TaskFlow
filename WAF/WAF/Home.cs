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

        private void AddNoteToListBox(string date, string title, string note)
        {
            listBox1.Items.Add($"{date}: {title}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string calendarDate = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            string titleOfNote = textBox.Text;
            string note = richTextBox.Text;

            if (!string.IsNullOrEmpty(note) && !string.IsNullOrEmpty(titleOfNote))
            {
                using (StreamWriter writer = new StreamWriter(filenote, true))
                {
                    writer.WriteLine($"{calendarDate};{titleOfNote};{note}");
                }

                AddNoteToListBox(calendarDate, titleOfNote, note);

                richTextBox.Clear();
                textBox.Clear();
            }
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string selectedDate = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            listBox1.Items.Clear();

            try
            {
                using (StreamReader stream = new StreamReader("notes.txt"))
                {
                    string line;
                    bool noteFound = false;
                    while ((line = stream.ReadLine()) != null)
                    {
                        string[] data = line.Split(';');

                        if (data[0] == selectedDate)
                        {
                            listBox1.Items.Add($"{data[1]}: {data[2]}"); 
                            noteFound = true;
                        }
                    }
                    if (!noteFound)
                    {
                        listBox1.Items.Add("No notes found for this date."); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }


    }
    }

