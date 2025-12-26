using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImageArray
{
    public partial class Form3 : Form
    {
        DataBaseConnectionClass dbc;
        public Form3()
        {
            InitializeComponent();
            dbc = new DataBaseConnectionClass();
            this.FormClosing += Form3_FormClosing;
        }
        // FormClosing event handler to terminate the whole application
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // This ensures the entire application is terminated
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
           /* if (textBox1.Text == "someone@example.com")
            {
                textBox1.Text = ""; // Clear placeholder
                textBox1.ForeColor = System.Drawing.Color.Black; // Set active text color
            }*/
        }

        // Event handler for email text box (textBox1) - Leave
        private void textBox1_Leave(object sender, EventArgs e)
        {
            /*if (string.IsNullOrWhiteSpace(textBox1.Text))
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
        private void Form3_Loader(object sender, EventArgs e)
        {
            // Resize the form dynamically on load
            this.ClientSize = new System.Drawing.Size(950, 600); // New size: 800x600
            DataBaseConnectionClass dbc = new DataBaseConnectionClass();
            dbc.dbcon();
            SqlCommand sq1 = new SqlCommand("select Id,Email from ImageTable", dbc.con);
            DataTable dt = new DataTable();

            SqlDataReader sdr = sq1.ExecuteReader();
            dt.Load(sdr);

            dataGridView1.DataSource = dt;
            dbc.con.Close();

            try
            {
                List<Image> images = RetrieveImages(10003);
                if (images.Count >= 2)  // Ensure the list contains at least two images
                {
                    // Set PictureBox size mode to ensure images fit perfectly
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

                    pictureBox1.Image = images[0];  // Load the first image into pictureBox1
                    pictureBox2.Image = images[1];  // Load the second image into pictureBox2
                }
                else
                {
                    MessageBox.Show("There are not enough images to display. Please ensure at least two images are available.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public List<Image> RetrieveImages(int Id)
        {
            List<Image> images = new List<Image>();

            string query = "SELECT Image FROM ImageTable WHERE Id = @Id";

            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zohur\Downloads\OneDrive_1_1-14-2025\ImageProcessing.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        byte[] allImages = (byte[])reader["Image"];
                        images = SplitImages(allImages);  // Split the byte array back into individual images
                    }
                }
            }

            return images;
        }



        private List<Image> SplitImages(byte[] allImages)
        {
            List<Image> images = new List<Image>();
            int startIndex = 0;

            for (int i = 0; i < allImages.Length - 1; i++)
            {
                // Check for JPEG start marker (FFD8) and end marker (FFD9)
                if (allImages[i] == 0xFF && allImages[i + 1] == 0xD8) // JPEG start
                {
                    startIndex = i;
                }
                else if (allImages[i] == 0xFF && allImages[i + 1] == 0xD9) // JPEG end
                {
                    int length = (i + 2) - startIndex;
                    byte[] imageData = new byte[length];
                    Array.Copy(allImages, startIndex, imageData, 0, length);

                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        images.Add(Image.FromStream(ms));
                    }
                }
            }

            return images;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        /*private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }*/
    }
}
