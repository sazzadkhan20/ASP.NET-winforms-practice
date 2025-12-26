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

namespace DataBaseDemo
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public void dbcon()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zohur\Downloads\OneDrive_1_1-14-2025\DemoData.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbcon();
            SqlCommand sq1 = new SqlCommand("select * from UserTable", con);
            DataTable dt = new DataTable();

            SqlDataReader sdr = sq1.ExecuteReader();
            dt.Load(sdr);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
