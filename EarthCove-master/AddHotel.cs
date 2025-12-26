using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EarthCove
{
    public partial class AddHotel : Form
    {
        public AddHotel()//Service Provider Adding Hotel
        {
            InitializeComponent();
        }

        private void AddHotel_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                }
            }
        }
    }
}
