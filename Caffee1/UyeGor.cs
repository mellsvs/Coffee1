using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Caffee1
{
    public partial class UyeGor : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public UyeGor()
        {
            InitializeComponent();
        }

        private void UyeGor_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-6LLA5LIQ;Initial Catalog=giris;Integrated Security=True");
            string kayit = "select * from kayit";
            da = new SqlDataAdapter(kayit, con);
            DataTable tablo = new DataTable(); // tablo oluşturuluyor
            da.Fill(tablo); // tabloyu doldur
            dataGridView1.DataSource = tablo; // tabloyu dataGridViewe aktar

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            YoneticiAraYuz yoneticiAraYuz = new YoneticiAraYuz();
            yoneticiAraYuz.Show();
            this.Hide();
        }
    }
}
