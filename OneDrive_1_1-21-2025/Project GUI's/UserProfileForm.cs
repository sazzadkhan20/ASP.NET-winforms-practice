using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_GUI_s
{
    public partial class UserProfileForm : Form
    {
        public UserProfileForm()
        {
            InitializeComponent();
            panel2.Hide();
            button11.Hide();
        }

        public void Button_Enabled()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignupForm();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button11.Show();
            Button_Enabled();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
