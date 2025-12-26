using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }
        // FormClosing event handler to terminate the whole application
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // This ensures the entire application is terminated
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "someone@example.com")
            {
                textBox1.Text = ""; // Clear placeholder
                textBox1.ForeColor = System.Drawing.Color.Black; // Set active text color
            }
        }

        // Event handler for email text box (textBox1) - Leave
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "someone@example.com"; // Restore placeholder
                textBox1.ForeColor = System.Drawing.SystemColors.GrayText; // Set placeholder color
            }
        }

        // Event handler for password text box (textBox2) - Enter
        private void textBox2_Enter(object sender, EventArgs e)
        {
            /*if (textBox2.Text == "Some@pass#123")
            {
                textBox2.Text = ""; // Clear placeholder
                textBox2.ForeColor = System.Drawing.Color.Black; // Set active text color
                textBox2.UseSystemPasswordChar = true; // Enable password masking
            }*/
        }

        // Event handler for password text box (textBox2) - Leave
        private void textBox2_Leave(object sender, EventArgs e)
        {
           /* if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.UseSystemPasswordChar = false; // Disable password masking
                textBox2.Text = "Some@pass#123"; // Restore placeholder
                textBox2.ForeColor = System.Drawing.SystemColors.GrayText; // Set placeholder color
            }*/
        }
        private void Form1_Loader(object sender, EventArgs e)
        {
            // Resize the form dynamically on load
            this.ClientSize = new System.Drawing.Size(850, 650); // New size: 800x600
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
            f3.FormClosed += (s, args) => this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            f2.FormClosed += (s,args) => this.Close();
        }

        /*private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }*/
    }
}
