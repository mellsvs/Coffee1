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

namespace Caffee1
{
    public partial class SatisMiktarics : Form
    {

        public SatisMiktarics()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
       
       
        private void SatisMiktarics_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-6LLA5LIQ;Initial Catalog=Siparis;Integrated Security=True");
            string kayit = "select * from Fiyat";
            da = new SqlDataAdapter(kayit, con);
            DataTable tablo = new DataTable(); // tablo oluşturuluyor
            da.Fill(tablo); // tabloyu doldur
            dataGridView1.DataSource = tablo; // tabloyu dataGridViewe aktar
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 2; i++)
            {
                sum = sum + int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }
            textBox1.Text = sum.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            YoneticiAraYuz yoneticiAraYuz = new YoneticiAraYuz();
            yoneticiAraYuz.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }
    }
}
