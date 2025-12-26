using System;
using System.Windows.Forms;

namespace First_GUI
{
    public partial class LogIn : Form
    {
       /* public LogIn()
        {
            InitializeComponent();
        }*/

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(113, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "LogIn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 1000);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(454, 1000);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(454, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 1000);
            this.panel2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.button3.Location = new System.Drawing.Point(442, 608);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 104);
            this.button3.TabIndex = 13;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Location = new System.Drawing.Point(51, 407);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(538, 74);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "";
            /*this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);*/
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox2.Location = new System.Drawing.Point(51, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(558, 74);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "";
            /*this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);*/
            // 
            // LogIn
            // 
            this.ClientSize = new System.Drawing.Size(1104, 1000);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LogIn";
            this.Text = "Login Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Handle login button click
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private Button button3;
    }
}
