namespace WFADBC
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMovie = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIMDB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMovie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 408);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 440);
            this.panel1.TabIndex = 0;
            // 
            // dgvMovie
            // 
            this.dgvMovie.AllowUserToAddRows = false;
            this.dgvMovie.AllowUserToDeleteRows = false;
            this.dgvMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.IMDB,
            this.Income,
            this.ReleaseDate,
            this.Genre});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMovie.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovie.Location = new System.Drawing.Point(0, 0);
            this.dgvMovie.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvMovie.Name = "dgvMovie";
            this.dgvMovie.ReadOnly = true;
            this.dgvMovie.RowHeadersWidth = 82;
            this.dgvMovie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovie.Size = new System.Drawing.Size(1348, 440);
            this.dgvMovie.TabIndex = 0;
            this.dgvMovie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovie_CellContentClick);
            this.dgvMovie.DoubleClick += new System.EventHandler(this.dgvMovie_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Movie ID";
            this.Id.MinimumWidth = 10;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 200;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Movie Title";
            this.Title.MinimumWidth = 10;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // IMDB
            // 
            this.IMDB.DataPropertyName = "IMDB";
            this.IMDB.HeaderText = "IMDB";
            this.IMDB.MinimumWidth = 10;
            this.IMDB.Name = "IMDB";
            this.IMDB.ReadOnly = true;
            this.IMDB.Width = 60;
            // 
            // Income
            // 
            this.Income.DataPropertyName = "Income";
            this.Income.HeaderText = "Box Office";
            this.Income.MinimumWidth = 10;
            this.Income.Name = "Income";
            this.Income.ReadOnly = true;
            this.Income.ToolTipText = "Gross Box Office Collection";
            this.Income.Width = 80;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReleaseDate.DataPropertyName = "ReleaseDate";
            this.ReleaseDate.HeaderText = "Release Date";
            this.ReleaseDate.MinimumWidth = 10;
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 10;
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Width = 200;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAutoSearch);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnShowDetails);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 354);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1348, 54);
            this.panel2.TabIndex = 1;
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Location = new System.Drawing.Point(610, 10);
            this.txtAutoSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(284, 31);
            this.txtAutoSearch.TabIndex = 3;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(306, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 44);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(284, 31);
            this.txtSearch.TabIndex = 1;
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetails.Location = new System.Drawing.Point(1122, 6);
            this.btnShowDetails.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(220, 44);
            this.btnShowDetails.TabIndex = 0;
            this.btnShowDetails.Text = "Show Details >>";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cmbGenre);
            this.panel3.Controls.Add(this.dtpReleaseDate);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtIncome);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtIMDB);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtTitle);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1348, 354);
            this.panel3.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(934, 229);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(280, 50);
            this.label11.TabIndex = 74;
            this.label11.Text = "* Just type in search by title\r\n\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGreen;
            this.label10.Location = new System.Drawing.Point(934, 179);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(339, 25);
            this.label10.TabIndex = 74;
            this.label10.Text = "* Double click on any row to edit.\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(668, 323);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 25);
            this.label9.TabIndex = 73;
            this.label9.Text = "Search by Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(60, 323);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 25);
            this.label8.TabIndex = 72;
            this.label8.Text = "Search by Genre";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(940, 15);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 133);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(778, 167);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 133);
            this.btnClear.TabIndex = 70;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(778, 15);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 133);
            this.btnSave.TabIndex = 69;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(510, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 25);
            this.label7.TabIndex = 68;
            this.label7.Text = "(Format: yyyy-MM-dd)";
            // 
            // cmbGenre
            // 
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Items.AddRange(new object[] {
            "action",
            "adventure",
            "comedy",
            "drama",
            "horror",
            "thriller"});
            this.cmbGenre.Location = new System.Drawing.Point(230, 265);
            this.cmbGenre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(264, 33);
            this.cmbGenre.TabIndex = 67;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.CustomFormat = "yyyy-MM-dd";
            this.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReleaseDate.Location = new System.Drawing.Point(230, 215);
            this.dtpReleaseDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(264, 31);
            this.dtpReleaseDate.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 31);
            this.label5.TabIndex = 65;
            this.label5.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 31);
            this.label6.TabIndex = 64;
            this.label6.Text = "Release Date";
            // 
            // txtIncome
            // 
            this.txtIncome.Location = new System.Drawing.Point(230, 165);
            this.txtIncome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(264, 31);
            this.txtIncome.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 31);
            this.label3.TabIndex = 62;
            this.label3.Text = "Box Office";
            // 
            // txtIMDB
            // 
            this.txtIMDB.Location = new System.Drawing.Point(230, 115);
            this.txtIMDB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtIMDB.Name = "txtIMDB";
            this.txtIMDB.Size = new System.Drawing.Size(264, 31);
            this.txtIMDB.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 31);
            this.label4.TabIndex = 60;
            this.label4.Text = "IMDB";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(230, 65);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(264, 31);
            this.txtTitle.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 58;
            this.label2.Text = "Movie Title";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(230, 15);
            this.txtID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(264, 31);
            this.txtID.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 31);
            this.label1.TabIndex = 56;
            this.label1.Text = "Movie ID";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 848);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMovie;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIMDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Income;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}