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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (radioButton1.Checked&&
                txt_user.Text!=""&&
                txt_surname.Text!= "" &&
                txt_pass.Text!="" &&
                txt_name.Text !="" &&
                txt_tel.Text !="" &&
                 txt_mail.Text !="" &&
                 txt_adres.Text !=""
                )
            {
            SqlConnection baglanti = new SqlConnection("server=LAPTOP-6LLA5LIQ;database=giris;trusted_connection=true;");
            SqlCommand cmd = new SqlCommand();
                
            cmd.CommandText = "insert kayit(kul_adi,sifre,isim,soyisim,telefon,mail,adres) values(@kul,@soyisim,@sifre,@isim,@telefon,@mail,@adres)";

            cmd.Connection = baglanti;
            cmd.Parameters.AddWithValue("@kul", txt_user.Text);
            cmd.Parameters.AddWithValue("@soyisim", txt_surname.Text);
            cmd.Parameters.AddWithValue("@sifre", txt_pass.Text);
            cmd.Parameters.AddWithValue("@isim", txt_name.Text);
            cmd.Parameters.AddWithValue("@telefon", txt_tel.Text);
            cmd.Parameters.AddWithValue("@mail", txt_mail.Text);
            cmd.Parameters.AddWithValue("@adres", txt_adres.Text);
            
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }

                int sonuc = cmd.ExecuteNonQuery();


                if (sonuc > 0)
                {
                    MessageBox.Show("GİRİŞ EKRANINDAN SİSTEME GİRİŞ YAPABİLİRSİNİZ","KAYIT BAŞARILI",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txt_user.Clear();
                    txt_surname.Clear();
                    txt_pass.Clear();
                    txt_name.Clear();
                    txt_tel.Clear();
                    txt_mail.Clear();
                    txt_adres.Clear();

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
                MessageBox.Show("TÜM KUTUCUKLARI DOLDURDUĞUNUZDAN EMİN OLUNUZ","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_user.Clear();
                txt_surname.Clear();
                txt_pass.Clear();
                txt_name.Clear();
                txt_tel.Clear();
                txt_mail.Clear();
                txt_adres.Clear();
            }
                    
        }
        //kvk linki açar
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kvkk.gov.tr/Icerik/2033/Aydinlatma-Yukumlulugu-");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
