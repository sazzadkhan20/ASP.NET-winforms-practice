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

namespace Project_GUI_s
{
    public partial class ServiceProviderForm : Form
    {
        SqlConnection con;
        public void dbcon()
        {


            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\saifu\Downloads\ProjectDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
        }


        string Temp_Email = "sadmanProvider@gmail.com";
        public void Get_Info(string Temp_Email)
        {
            dbcon();
            string query = "SELECT SP_ID, User_Type, SP_Type, SP_Name, SP_Mobile, SP_Address, SP_Balance, SP_Email, SP_Password FROM Service_Provider_Details WHERE SP_Email = @Temp_Email";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Temp_Email", Temp_Email);// SqlCommand with parameterized query
            

            // Execute query and read data
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                // Set the data to labels
                label1.Text = "User Type        : " + reader["User_Type"].ToString();
                label2.Text = "Service Type     : " + reader["SP_Type"].ToString();
                label3.Text = "User ID          : " + reader["SP_ID"].ToString();
                label4.Text = "Name             : " + reader["SP_Name"].ToString();
                label5.Text = "Mobile           : " + reader["SP_Mobile"].ToString();
                label6.Text = "Email            : " + reader["SP_Email"].ToString();
                label7.Text = "Address          : " + reader["SP_Address"].ToString();
                label8.Text = "Balance          : " + reader["SP_Balance"].ToString();

            }
            else
            {
                MessageBox.Show("No user found with this email.");
            }

            con.Close();
        }

        public ServiceProviderForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Hide();
            Get_Info(Temp_Email);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }
    }
}
