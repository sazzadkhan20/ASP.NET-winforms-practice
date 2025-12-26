using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_Buttons();
        }

        private void load_Buttons()
        {
            // Dynamic Button --
            int xPos = 40, yPos = 26;
            int sz = 215;
            int increment = 28;

            for (int i = 0; i < 10; i++)
            {
                Button b = new Button();
                b.Location = new Point(xPos, yPos);
                b.Size = new Size(641, 215);
                b.Text = $"Tour Package {i + 1}";
                b.Name = $"button{i + 1}";
                b.Font = new Font("Minion Pro", 20);
                b.Padding = new Padding(0);

                // Assign a unique identifier or data to the button (optional)
                b.Tag = i + 1;

                // Attach the same event handler for all buttons
                b.Click += new EventHandler(DynamicButton_Click);

                // Add button to the panel
                panel1.Controls.Add(b);

                yPos += increment + sz;
            }
        }

        // Event handler for dynamic buttons
        private void DynamicButton_Click(object sender, EventArgs e)
        {
            // Cast sender to Button
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                // Get the button's unique identifier or other data
                string buttonName = clickedButton.Name;
                int buttonTag = (int)clickedButton.Tag;

                // Display a message or perform unique action
                MessageBox.Show($"You clicked {buttonName} with Tag: {buttonTag}", "Button Click");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
