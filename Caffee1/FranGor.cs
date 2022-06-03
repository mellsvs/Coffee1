using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Caffee1
{
    public partial class FranGor : Form
       
    {   SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public FranGor()
        {
            InitializeComponent();
        }

        private void FranGor_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-6LLA5LIQ;Initial Catalog=Franchise;Integrated Security=True");
            string kayit = "select * from fran";
            da = new SqlDataAdapter(kayit, con);
            DataTable tablo = new DataTable(); // tablo oluşturuluyor
            da.Fill(tablo); // tabloyu doldur
            dataGridView1.DataSource = tablo; // tabloyu dataGridViewe aktar
           
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            YoneticiAraYuz yoneticiAraYuz = new YoneticiAraYuz();
            yoneticiAraYuz.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
