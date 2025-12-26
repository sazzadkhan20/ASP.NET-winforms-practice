using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ImageArray
{
    public partial class Form2 : Form
    {
        DataBaseConnectionClass dbc;
        public Form2()
        {
            InitializeComponent();
            dbc = new DataBaseConnectionClass();
            this.FormClosing += Form2_FormClosing;
        }
        // FormClosing event handler to terminate the whole application
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // This ensures the entire application is terminated
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            /*if (textBox1.Text == "someone@example.com")
            {
                textBox1.Text = ""; // Clear placeholder
                textBox1.ForeColor = System.Drawing.Color.Black; // Set active text color
            }*/
        }

        // Event handler for email text box (textBox1) - Leave
        private void textBox1_Leave(object sender, EventArgs e)
        {
           /* if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "someone@example.com"; // Restore placeholder
                textBox1.ForeColor = System.Drawing.SystemColors.GrayText; // Set placeholder color
            }*/
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
        private void Form2_Loader(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] files = openFileDialog.FileNames;
                if (files.Length != 2)
                {
                    MessageBox.Show("Please select exactly 2 images.");
                    return;
                }

                pictureBox1.Image = Image.FromFile(files[0]);
                pictureBox2.Image = Image.FromFile(files[1]);

                MessageBox.Show("Images uploaded successfully.");
            }
        }

        private bool AreFieldsValid()
        {
            if (pictureBox1.Image == null ||
                pictureBox2.Image == null)
            {
                MessageBox.Show("Please fill in all the required fields and select images.");
                return false;
            }
            return true;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AreFieldsValid())
            {
                try
                {
                    dbc.dbcon();

                    byte[] img1 = ImageToByteArray(pictureBox1.Image);
                    byte[] img2 = ImageToByteArray(pictureBox2.Image);

                    InsertPackageDetails("xxx@gmail.com", img1, img2);

                    MessageBox.Show("Successfully saved.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    dbc.con.Close();
                }
            }
        }

        private void InsertPackageDetails(string email, byte[] img1, byte[] img2)
        {
            // Combine the byte arrays into one
            byte[] allImages = CombineImages(img1, img2);

            string query = "INSERT INTO ImageTable (Email, Image) " +
                           "VALUES (@Email, @Image)";

            using (SqlCommand cmd = new SqlCommand(query, dbc.con))
            { 
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Image", allImages);

                cmd.ExecuteNonQuery();
            }
        }

        private byte[] CombineImages(params byte[][] images)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                foreach (var image in images)
                {
                    ms.Write(image, 0, image.Length);  // Write each image into the stream
                }
                return ms.ToArray();
            }
        }

        private bool AreImagesUploaded()
        {
            if (pictureBox1.Image == null || pictureBox2.Image == null)
            {
                MessageBox.Show("Please upload all images.");
                return false;
            }
            return true;
        }

        private byte[] ImageToByteArray(Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        /*private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }*/
    }
}
