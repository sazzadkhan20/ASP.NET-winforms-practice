using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ResetPassword
{
    partial class ForgatePassword
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
        // Event handler for email text box (textBox1) - Enter
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "someone@example.com")
            {
                textBox1.Text = ""; // Clear placeholder
                textBox1.ForeColor = System.Drawing.Color.Black; // Set active text color
            }
        }

        // Event handler for email text box (textBox1) - Leave
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "someone@example.com"; // Restore placeholder
                textBox1.ForeColor = System.Drawing.SystemColors.GrayText; // Set placeholder color
            }
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgatePassword));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(351, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 701);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(30, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 58);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(81, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(249, 112);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(24, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 62);
            this.label1.TabIndex = 11;
            this.label1.Text = "Please enter your email address and we\'ll send you \r\na link to reset your passwor" +
    "d";
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(30, 357);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 140);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(68, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(827, 43);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "someone@example.com";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(24)))));
            this.button4.ForeColor = System.Drawing.Color.GhostWhite;
            this.button4.Location = new System.Drawing.Point(30, 570);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(944, 88);
            this.button4.TabIndex = 5;
            this.button4.Text = "Send Mail";
            this.button4.UseMnemonic = false;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(24)))));
            this.label2.Location = new System.Drawing.Point(21, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "Forgot Password?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(24)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.GhostWhite;
            this.button5.Location = new System.Drawing.Point(1475, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 80);
            this.button5.TabIndex = 6;
            this.button5.Text = "SignIn";
            this.button5.UseMnemonic = false;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BDT",
            "PKR"});
            this.comboBox1.Location = new System.Drawing.Point(1303, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 45);
            this.comboBox1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(47, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 112);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2769, 145);
            this.panel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Location = new System.Drawing.Point(552, 25);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(151, 85);
            this.button6.TabIndex = 16;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Location = new System.Drawing.Point(726, 25);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(151, 85);
            this.button7.TabIndex = 17;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.Location = new System.Drawing.Point(896, 25);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(151, 85);
            this.button8.TabIndex = 18;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.Location = new System.Drawing.Point(1067, 25);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(151, 85);
            this.button9.TabIndex = 19;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // ForgatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1654, 1214);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ForgatePassword";
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.Form1_Loader);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        // Paint event handler for panel3
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Define the border color and width
            System.Drawing.Color borderColor = System.Drawing.Color.FromArgb(80, 80, 80); // Choose your desired color
            int borderWidth = 2;

            // Get the panel's graphics object
            using (var pen = new System.Drawing.Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.panel3.ClientSize.Width - 1, this.panel3.ClientSize.Height - 1);
            }
        }

        #endregion

        // Correct placement for the Form1_Load method
        private void Form1_Loader(object sender, EventArgs e)
        {
            // Resize the form dynamically on load
            this.ClientSize = new System.Drawing.Size(850, 650); // New size: 800x600
        }

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button5;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
    }
}
