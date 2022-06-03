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
    public partial class YoneticiAraYuz : Form
    {
        public YoneticiAraYuz()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FranGor franGor = new FranGor();
            franGor.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Workers workers = new Workers();
            workers.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BasvuruGor basvuru = new BasvuruGor();
            basvuru.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UyeGor uyeGor = new UyeGor();
            uyeGor.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SatisMiktarics satisMiktarics = new SatisMiktarics();
            satisMiktarics.Show();
            this.Hide();
        }
    }
}
