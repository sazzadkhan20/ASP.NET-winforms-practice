using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_GUI
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /* private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "E-mail")
            {
                textBox2.Text = "";
                textBox2.ForeColor = System.Drawing.Color.Black; // Active text color
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "E-mail";
                textBox2.ForeColor = System.Drawing.SystemColors.GrayText; // Placeholder color
            }
        }*/

        /* private void textBox1_Enter(object sender, EventArgs e)
         {
             if (textBox1.Text == "Password")
             {
                 textBox1.Text = "";
                 textBox1.ForeColor = System.Drawing.Color.Black; // Active text color
                 textBox1.UseSystemPasswordChar = true; // Enable password masking
             }
         }

         private void textBox1_Leave(object sender, EventArgs e)
         {
             if (string.IsNullOrWhiteSpace(textBox1.Text))
             {
                 textBox1.UseSystemPasswordChar = false; // Disable password masking
                 textBox1.Text = "Password";
                 textBox1.ForeColor = System.Drawing.SystemColors.GrayText; // Placeholder color
             }
         }*/
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
                MessageBox.Show("Both Username and Password must be added", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            else
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
        }
    }
}
