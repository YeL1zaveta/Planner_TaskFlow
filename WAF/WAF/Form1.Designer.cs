namespace WAF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(412, 44);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.BlueViolet;
            this.button4.Location = new System.Drawing.Point(228, 457);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 98);
            this.button4.TabIndex = 10;
            this.button4.Text = "Settings";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumVioletRed;
            this.button3.Location = new System.Drawing.Point(228, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 98);
            this.button3.TabIndex = 9;
            this.button3.Text = "Notes";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.Location = new System.Drawing.Point(84, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 98);
            this.button2.TabIndex = 8;
            this.button2.Text = "Progres";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(84, 324);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 98);
            this.button1.TabIndex = 7;
            this.button1.Text = "Task";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::WAF.Properties.Resources.Zrzut_ekranu_2024_09_06_111811;
            this.pictureBox2.Location = new System.Drawing.Point(84, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 221);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WAF.Properties.Resources.Zrzut_ekranu_2024_09_06_124556;
            this.pictureBox1.Location = new System.Drawing.Point(-59, -24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(903, 679);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(395, 291);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(174, 264);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(598, 291);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(170, 264);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(709, 561);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 37);
            this.button5.TabIndex = 14;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(713, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 28);
            this.button6.TabIndex = 15;
            this.button6.Text = "Log out";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

