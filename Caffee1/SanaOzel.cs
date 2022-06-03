using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caffee1
{
    public partial class SanaOzel : Form
    {
        public SanaOzel()
        {
            InitializeComponent();
        }

        private void SanaOzel_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GroupPics group = new GroupPics();
            group.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HwPics hwPics = new HwPics();
            hwPics.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
