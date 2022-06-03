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
    public partial class CalisanaMain : Form
    {
        public CalisanaMain()
        {
            InitializeComponent();
        }

        private void CalisanaMain_Load(object sender, EventArgs e)
        {

        }
        //
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("server=LAPTOP-6LLA5LIQ;database=calisan;trusted_connection=true;");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Employee where id ='" + txt_id.Text.Trim() + "' and isim ='" + txt_user.Text.Trim() + "' and Soyad='"+txt_surname.Text.Trim()+"'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                CalisanGiris calisanGiris = new CalisanGiris();
                calisanGiris.Show();
                this.Hide();
                txt_user.Clear();
                txt_surname.Clear();
               

            }
            else
            {
                MessageBox.Show("YANLIŞ GİRİŞ","Hata", MessageBoxButtons.OKCancel);
                txt_user.Clear();
                txt_surname.Clear();

            }
            baglanti.Close();
        }



    }
    }

