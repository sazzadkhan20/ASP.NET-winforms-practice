using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HomePageFrame
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(24)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.GhostWhite;
            this.button5.Location = new System.Drawing.Point(1486, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 80);
            this.button5.TabIndex = 10;
            this.button5.Text = "SignIn";
            this.button5.UseMnemonic = false;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BDT",
            "PKR"});
            this.comboBox1.Location = new System.Drawing.Point(1320, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 33);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(118, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1442, 588);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(24)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.GhostWhite;
            this.button1.Location = new System.Drawing.Point(620, 984);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(346, 80);
            this.button1.TabIndex = 13;
            this.button1.Text = "Search";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel7
            // 
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel7.Controls.Add(this.textBox5);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Location = new System.Drawing.Point(718, 338);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(414, 141);
            this.panel7.TabIndex = 11;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(26, 77);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(368, 43);
            this.textBox5.TabIndex = 1;
            this.textBox5.Text = "Economy";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.Enter += new System.EventHandler(this.textBox5_Enter);
            this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Traveler,Class";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel6
            // 
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Controls.Add(this.textBox4);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(213, 338);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(414, 141);
            this.panel6.TabIndex = 10;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(26, 77);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(368, 43);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "10 January Friday";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.Enter += new System.EventHandler(this.textBox4_Enter);
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Return Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(950, 158);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(414, 141);
            this.panel5.TabIndex = 9;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(26, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(368, 43);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "6 January,Monday";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Journey Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(502, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(414, 141);
            this.panel4.TabIndex = 8;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(26, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(368, 43);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Cox\'s Bazar";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "To";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(58, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 141);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(26, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 43);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Dhaka";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "From";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Cambria Math", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(494, 14);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(199, 138);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Multi City";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Cambria Math", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(272, 14);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(214, 138);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Round Way";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Cambria Math", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(58, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(186, 138);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "One Way";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(390, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 125);
            this.panel2.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::HomePage.Properties.Resources.Tour;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Location = new System.Drawing.Point(788, 20);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 89);
            this.button6.TabIndex = 3;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::HomePage.Properties.Resources.Hotel;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(540, 20);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 89);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::HomePage.Properties.Resources.Bus;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(292, 20);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 89);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::HomePage.Properties.Resources.Flight;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(45, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 89);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(58, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 112);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1654, 1214);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HomePage";
            this.Text = "EarthCove";
            this.Load += new System.EventHandler(this.Form1_Loader);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // Correct placement for the Form1_Load method
        private void Form1_Loader(object sender, EventArgs e)
        {
            // Resize the form dynamically on load
            this.ClientSize = new System.Drawing.Size(850, 650); // New size: 800x600
        }
        private Button button5;
        private ComboBox comboBox1;
        private Panel panel1;
        private Panel panel2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton4;
        private Panel panel3;
        private TextBox textBox1;
        private Label label3;
        private Panel panel5;
        private TextBox textBox3;
        private Label label2;
        private Panel panel4;
        private TextBox textBox2;
        private Label label1;
        private Panel panel7;
        private TextBox textBox5;
        private Label label5;
        private Panel panel6;
        private TextBox textBox4;
        private Label label4;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button6;
        private Button button4;
        private Button button3;
    }
}
