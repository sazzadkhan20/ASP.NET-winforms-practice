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
    public partial class FormDashboard : Form
    {
        private DataAccess Da { get; set; }

        public FormDashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
            //this.AutoIdGenerate();
        }

        private void PopulateGridView(string sql = "select * from Movie;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvMovie.AutoGenerateColumns = false;
            this.dgvMovie.DataSource = ds.Tables[0];
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var sql = "select * from Movie where Genre = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Movie where Title like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = "select * from Movie where Id = '" + this.txtID.Text + "'";
                DataTable dt = this.Da.ExecuteQueryTable(query);
                if(dt.Rows.Count == 1)
                {
                    //update
                    var sql = @"update Movie
                                set Title = '" + this.txtTitle.Text + @"',
                                IMDB = " + this.txtIMDB.Text + @",
                                Income = " + this.txtIncome.Text + @",
                                ReleaseDate = '" + this.dtpReleaseDate.Text + @"',
                                Genre = '" + this.cmbGenre.Text + @"'
                                where Id = '" + this.txtID.Text + "'; ";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated properly");
                    else
                        MessageBox.Show("Data hasn't been updated properly");
                }
                else
                {
                    //insert
                    var sql = "insert into Movie values('" + this.txtID.Text + "', '" + this.txtTitle.Text + "', " + this.txtIMDB.Text + ", " + this.txtIncome.Text + ", '" + this.dtpReleaseDate.Text + "', '" + this.cmbGenre.Text + "'); ";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been added properly");
                    else
                        MessageBox.Show("Data hasn't been added properly");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch(Exception exc)
            {
                MessageBox.Show("An error has occured, please check: " + exc.Message);
            }            
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtID.Text) || string.IsNullOrEmpty(this.txtTitle.Text) ||
                string.IsNullOrEmpty(this.txtIMDB.Text) || string.IsNullOrEmpty(this.txtIncome.Text) ||
                string.IsNullOrEmpty(this.cmbGenre.Text))
                return false;
            else
                return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            //this.AutoIdGenerate();
        }

        private void ClearAll()
        {
            this.txtID.Text = "";
            this.txtTitle.Clear();
            this.txtIMDB.Clear();
            this.txtIncome.Clear();
            this.dtpReleaseDate.Text = "";
            this.cmbGenre.SelectedIndex = -1;

            this.txtSearch.Clear();
            this.txtAutoSearch.Clear();

            this.dgvMovie.ClearSelection();

            this.AutoIdGenerate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.dgvMovie.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var id = this.dgvMovie.CurrentRow.Cells[0].Value.ToString();
                var title = this.dgvMovie.CurrentRow.Cells[1].Value.ToString();
                //MessageBox.Show(id);

                DialogResult result = MessageBox.Show("Are you sure you want to delete " + title + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;

                var sql = "delete from Movie where Id = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(title.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("Data hasn't been removed properly");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch(Exception exc)
            {
                MessageBox.Show("An error has occured, please check: " + exc.Message);
            }
            
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            this.dgvMovie.ClearSelection();
            this.AutoIdGenerate();
        }

        private void dgvMovie_DoubleClick(object sender, EventArgs e)
        {
            this.txtID.Text = this.dgvMovie.CurrentRow.Cells["Id"].Value.ToString();
            this.txtTitle.Text = this.dgvMovie.CurrentRow.Cells["Title"].Value.ToString();
            this.txtIMDB.Text = this.dgvMovie.CurrentRow.Cells["IMDB"].Value.ToString();
            this.txtIncome.Text = this.dgvMovie.CurrentRow.Cells[3].Value.ToString();
            this.dtpReleaseDate.Text = this.dgvMovie.CurrentRow.Cells[4].Value.ToString();
            this.cmbGenre.Text = this.dgvMovie.CurrentRow.Cells["Genre"].Value.ToString();
        }

        private void AutoIdGenerate()
        {
            var query = "select max(Id) from Movie;";
            var dt = this.Da.ExecuteQueryTable(query);
            var oldId = dt.Rows[0][0].ToString();
            string[] temp = oldId.Split('-');
            var num = Convert.ToInt32(temp[1]);
            var newId = "m-" + (++num).ToString("d3");
            //MessageBox.Show(newId);
            this.txtID.Text = newId;
        }

        private void dgvMovie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
