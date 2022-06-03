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
    public partial class Franchise : Form
    {
        public Franchise()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        SqlConnection baglanti = new SqlConnection("server=LAPTOP-6LLA5LIQ;database=Franchise;trusted_connection=true;");
        SqlCommand cmd = new SqlCommand();

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFname.Text != "" && txtFsurname.Text != "" && txtFtel.Text != "")
            {
                cmd.CommandText = "insert fran(Ad,Soyad,Telefon) values(@adi,@soyadi,@tel)";

                cmd.Connection = baglanti;
                cmd.Parameters.AddWithValue("@adi", txtFname.Text);
                cmd.Parameters.AddWithValue("@soyadi", txtFsurname.Text);
                cmd.Parameters.AddWithValue("@tel", txtFtel.Text);

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
                        txtFname.Clear();
                        txtFsurname.Clear();
                        txtFtel.Clear();

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
                txtFname.Clear();
                txtFsurname.Clear();
                txtFtel.Clear();


            }

        }
    }
    }

