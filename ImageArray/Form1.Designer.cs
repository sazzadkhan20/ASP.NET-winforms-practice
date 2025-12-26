using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ImageArray
{
    public partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2769, 145);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(330, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 920);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(209, 444);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(573, 56);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(24)))));
            this.button4.ForeColor = System.Drawing.Color.GhostWhite;
            this.button4.Location = new System.Drawing.Point(25, 743);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(944, 88);
            this.button4.TabIndex = 5;
            this.button4.Text = "SignIn";
            this.button4.UseMnemonic = false;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(24)))));
            this.label2.Location = new System.Drawing.Point(334, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sign In";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1401, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 79);
            this.button1.TabIndex = 2;
            this.button1.Text = "Admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1654, 1214);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Loader);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        // Paint event handler for panel3
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           /* // Define the border color and width
            System.Drawing.Color borderColor = System.Drawing.Color.FromArgb(80, 80, 80); // Choose your desired color
            int borderWidth = 2;

            // Get the panel's graphics object
            using (var pen = new System.Drawing.Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.panel3.ClientSize.Width - 1, this.panel3.ClientSize.Height - 1);
            }*/
        }

        #endregion

        private System.Windows.Forms.Panel panel1;

        // Correct placement for the Form1_Load method


        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private TextBox textBox1;
        private Button button1;
    }
}
