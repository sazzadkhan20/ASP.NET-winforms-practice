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

namespace WFADBC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-HASIB;Initial Catalog=CFallDb;User ID=sa;Password=P@$$w0rd");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand("select * from UserInfo;", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            this.label1.Text = ds.Tables[0].Rows[0][0].ToString();
            this.label2.Text = ds.Tables[0].Rows[3][1].ToString();
            this.label3.Text = ds.Tables[0].Rows[2][2].ToString();
            this.label4.Text = ds.Tables[0].Rows[0][3].ToString();

            sqlcon.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
