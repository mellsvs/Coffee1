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
    public partial class BizeKatil : Form
    {
        public BizeKatil()
        {
            InitializeComponent();
        }

        private void BizeKatil_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        SqlConnection baglanti = new SqlConnection("server=LAPTOP-6LLA5LIQ;database=BizeKatil;trusted_connection=true;");
        SqlCommand cmd = new SqlCommand();


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBizeKatilAd.Text != "" && txtBizeKatilNo.Text != "" && txtBizeKatilSoyad.Text != "")
            {
                cmd.CommandText = "insert katil(Ad,Soyad,Telefon) values(@adi,@soyadi,@tel)";

                cmd.Connection = baglanti;
                cmd.Parameters.AddWithValue("@adi", txtBizeKatilAd.Text);
                cmd.Parameters.AddWithValue("@soyadi", txtBizeKatilSoyad.Text);
                cmd.Parameters.AddWithValue("@tel", txtBizeKatilNo.Text);

                try
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }

                    int sonuc = cmd.ExecuteNonQuery();


                    if (sonuc > 0)
                    {
                        MessageBox.Show("BİLGİLERİNİZ SİSTEME KAYDEDİLMİŞTİR.DÖNÜŞ YAPILACAKTIR", "İLGİNİZ İÇİN TEŞEKKÜR EDERİZ.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBizeKatilSoyad.Clear();
                        txtBizeKatilAd.Clear();
                        txtBizeKatilNo.Clear();

                    }
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("ALANLAR BOŞ BIRAKILAMAZ!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBizeKatilSoyad.Clear();
                txtBizeKatilAd.Clear();
                txtBizeKatilNo.Clear();

            }

        }
    }
}

