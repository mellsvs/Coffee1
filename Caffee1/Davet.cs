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
    public partial class Davet : Form
    {
        public Davet()
        {
            InitializeComponent();
        }


        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("server=LAPTOP-6LLA5LIQ;database=giris;trusted_connection=true;");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "insert davet(DavetKodu) values(@davet)";

            cmd.Connection = baglanti;
            cmd.Parameters.AddWithValue("@davet", davettxt.Text);
            try
            { if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                int sonuc = cmd.ExecuteNonQuery();
                if (sonuc > 0)
                {

                    MessageBox.Show("SİPARİŞİNİZİ VEREBİLRİSİNİZ", "iyi günler", MessageBoxButtons.OK);
                    davettxt.Clear();

                }
                baglanti.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

      
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
