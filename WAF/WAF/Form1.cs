using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.LightCoral;
            button1.FlatAppearance.BorderSize = 0; 

            button2.FlatStyle = FlatStyle.Flat;
            button2.BackColor = Color.Orange;
            button2.FlatAppearance.BorderSize = 0;

            button3.FlatStyle = FlatStyle.Flat;
            button3.BackColor = Color.MediumPurple;
            button3.FlatAppearance.BorderSize = 0;

            button4.FlatStyle = FlatStyle.Flat;
            button4.BackColor = Color.HotPink;
            button4.FlatAppearance.BorderSize = 0;

            button5.FlatStyle = FlatStyle.Flat;
            button5.BackColor = Color.HotPink;
            button5.FlatAppearance.BorderSize = 0;

            button6.FlatStyle = FlatStyle.Flat;
            button6.BackColor = Color.Aquamarine;
            button6.FlatAppearance.BorderSize = 0;

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

          //  label1.Font = new Font("Planer", 16, FontStyle.Bold); 
           // label1.ForeColor = Color.Coral;
            //label1.Text = "Planer";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
