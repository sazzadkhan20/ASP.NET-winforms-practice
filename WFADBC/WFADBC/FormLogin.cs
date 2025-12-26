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

namespace WFADBC
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtUserId.Text) || string.IsNullOrEmpty(this.txtPassword.Text))
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                string sql = "select * from UserInfo where Id = '" + this.txtUserId.Text + "' and Password = '" + this.txtPassword.Text + "'";
                SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-HASIB;Initial Catalog=CFallDb;User ID=sa;Password=P@$$w0rd");
                sqlcon.Open();
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                var name = ds.Tables[0].Rows[0][1].ToString();

                if (ds.Tables[0].Rows.Count == 1)
                {
                    this.Visible = false;
                    MessageBox.Show("Valid User");
                    if (ds.Tables[0].Rows[0][3].ToString().Equals("admin"))
                    {
                        //FormAdmin fa = new FormAdmin(name, this);
                        //fa.Show();//fa.Visible = true;
                        new FormAdmin(name, this).Show();
                    }
                    else if (ds.Tables[0].Rows[0][3].ToString().Equals("member"))
                    {
                        new FormMember(name, this).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User");
                }

                sqlcon.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }            

            //bool notFound = true;
            //int index = 0;
            //while(index < ds.Tables[0].Rows.Count)
            //{
            //    if (this.txtUserId.Text == ds.Tables[0].Rows[index][0].ToString() && this.txtPassword.Text == ds.Tables[0].Rows[index][2].ToString())
            //    {
            //        notFound = false;
            //        MessageBox.Show("Valid User");
            //        break;
            //    }

            //    index++;
            //}
            //if (notFound)
            //    MessageBox.Show("Invalid User");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUserId.Clear();
            this.txtPassword.Text = "";
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
