using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePageFrame
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Dhaka")
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
                textBox1.Text = "Dhaka"; // Restore placeholder
                textBox1.ForeColor = System.Drawing.SystemColors.GrayText; // Set placeholder color
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Cox's Bazar")
            {
                textBox2.Text = "";
                textBox2.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Cox's Bazar";
                textBox2.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "6 January,Monday")
            {
                textBox3.Text = ""; // Clear the default text when the textbox is focused
                textBox3.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Text = "6 January,Monday"; // Restore the default text if the user leaves it empty
                textBox3.ForeColor = System.Drawing.Color.Gray;
            }
        }


        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "10 January Friday")
            {
                textBox4.Text = ""; // Clear placeholder
                textBox4.ForeColor = System.Drawing.Color.Black; // Set active text color
            }
        }

        // Event handler for email text box (textBox1) - Leave
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                textBox4.Text = "10 January Friday"; // Restore placeholder
                textBox4.ForeColor = System.Drawing.SystemColors.GrayText; // Set placeholder color
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Economy")
            {
                textBox5.Text = ""; // Clear placeholder
                textBox5.ForeColor = System.Drawing.Color.Black; // Set active text color
            }
        }

        // Event handler for email text box (textBox1) - Leave
        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                textBox5.Text = "Economy"; // Restore placeholder
                textBox5.ForeColor = System.Drawing.SystemColors.GrayText; // Set placeholder color
            }
        }
        // Paint event handler for panel3
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Define the light black border color and width
            System.Drawing.Color borderColor = System.Drawing.Color.FromArgb(50, 50, 50); // Light black (dark gray)
            int borderWidth = 2;

            // Get the panel's graphics object
            using (var pen = new System.Drawing.Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.panel3.ClientSize.Width - 1, this.panel3.ClientSize.Height - 1);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            // Define the light black border color and width
            System.Drawing.Color borderColor = System.Drawing.Color.FromArgb(50, 50, 50); // Light black (dark gray)
            int borderWidth = 2;

            // Get the panel's graphics object
            using (var pen = new System.Drawing.Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.panel4.ClientSize.Width - 1, this.panel4.ClientSize.Height - 1);
            }
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            // Define the light black border color and width
            System.Drawing.Color borderColor = System.Drawing.Color.FromArgb(50, 50, 50); // Light black (dark gray)
            int borderWidth = 2;

            // Get the panel's graphics object
            using (var pen = new System.Drawing.Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.panel5.ClientSize.Width - 1, this.panel5.ClientSize.Height - 1);
            }
        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            // Define the light black border color and width
            System.Drawing.Color borderColor = System.Drawing.Color.FromArgb(50, 50, 50); // Light black (dark gray)
            int borderWidth = 2;

            // Get the panel's graphics object
            using (var pen = new System.Drawing.Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.panel6.ClientSize.Width - 1, this.panel6.ClientSize.Height - 1);
            }
        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            // Define the light black border color and width
            System.Drawing.Color borderColor = System.Drawing.Color.FromArgb(50, 50, 50); // Light black (dark gray)
            int borderWidth = 2;

            // Get the panel's graphics object
            using (var pen = new System.Drawing.Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.panel7.ClientSize.Width - 1, this.panel7.ClientSize.Height - 1);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
