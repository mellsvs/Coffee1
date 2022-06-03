using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Caffee1
{
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-6LLA5LIQ;Initial Catalog=yonetici;Integrated Security=True");
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        //Data Source=LAPTOP-6LLA5LIQ;Initial Catalog=yonetici;Integrated Security=True

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Employer where giris_id ='" + txtY_Kod.Text.Trim() + "'and password ='" + txtY_Sifre.Text.Trim() + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                YoneticiAraYuz yoneticiAraYuz = new YoneticiAraYuz();
                yoneticiAraYuz.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ");
                txtY_Kod.Clear();
                txtY_Sifre.Clear();

            }
            baglanti.Close();
        }
    }
}
