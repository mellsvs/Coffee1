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
    public partial class Workers : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;


        public Workers()
        {
            InitializeComponent();
        }
        public void listele()
        { // bağlantı kuruldu
            con = new SqlConnection("Data Source=LAPTOP-6LLA5LIQ;Initial Catalog=calisan;Integrated Security=True");

            string kayit = "select * from Employee";
            da = new SqlDataAdapter(kayit, con);
            DataTable tablo = new DataTable(); // tablo oluşturuluyor
            da.Fill(tablo); // tabloyu doldur
            dataGridView1.DataSource = tablo; // tabloyu dataGridViewe aktar
            text_Wisim.Clear();
            text_Wsoyad.Clear();
            //text_Wdate.Clear();
            txt_Wden.Clear();
            txt_Wpoz.Clear();
            txt_Wvar.Clear();
        }

        private void Workers_Load(object sender, EventArgs e)
        {
            listele();
        }




        private void btn_Wekle_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-6LLA5LIQ;Initial Catalog=calisan;Integrated Security=True ");
            string kayit = "insert into Employee values (@isim,@Soyad,@DoğumTarihi,@Deneyim,@Pozisyon,@VardiyaBilgileri)";
            cmd = new SqlCommand(kayit, con);
            cmd.Parameters.AddWithValue("@isim", text_Wisim.Text);
            cmd.Parameters.AddWithValue("@Soyad", text_Wsoyad.Text);
            cmd.Parameters.AddWithValue("@DoğumTarihi", date.Value);
            cmd.Parameters.AddWithValue("@Deneyim", txt_Wden.Text);
            cmd.Parameters.AddWithValue("@Pozisyon", txt_Wpoz.Text);
            cmd.Parameters.AddWithValue("@VardiyaBilgileri", txt_Wvar.Text);
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                int sonuc = cmd.ExecuteNonQuery();


                if (sonuc > 0)
                {
                    MessageBox.Show("kullanıcı eklendi");
                    text_Wisim.Clear();
                    text_Wsoyad.Clear();
                    //  date.Clear();text_Wdate
                    txt_Wden.Clear();
                    txt_Wpoz.Clear();
                    txt_Wvar.Clear();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

          
            listele();
        }

        private void btn_wupdate_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-6LLA5LIQ;Initial Catalog=calisan;Integrated Security=True ");
            string komut = "update Employee set isim=@isim,Soyad =@Soyad,DoğumTarihi=@DoğumTarihi,Deneyim=@Deneyim,Pozisyon=@Pozisyon,VardiyaBilgileri=@VardiyaBilgileri where id=@id";
            cmd = new SqlCommand(komut, con);
            cmd.Parameters.AddWithValue("@isim", text_Wisim.Text);
            cmd.Parameters.AddWithValue("@Soyad", text_Wsoyad.Text);
            cmd.Parameters.AddWithValue("@DoğumTarihi", date.Value);
            cmd.Parameters.AddWithValue("@Deneyim", txt_Wden.Text);
            cmd.Parameters.AddWithValue("@Pozisyon", txt_Wpoz.Text);
            cmd.Parameters.AddWithValue("@VardiyaBilgileri", txt_Wvar.Text);
            cmd.Parameters.AddWithValue("@id", textBoxİD.Text.ToString());
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            listele();
        }

        private void btn_Wsil_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-6LLA5LIQ;Initial Catalog=calisan;Integrated Security=True");
            string kayit = " delete from Employee where id =@id ";



            cmd = new SqlCommand(kayit, con);
            cmd.Parameters.AddWithValue("@id", int.Parse(txt_id.Text));

            con.Open();
            cmd.ExecuteNonQuery();

            con.Close();
            listele();
            txt_id.Clear();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            text_Wisim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            text_Wsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           // text_Wdate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_Wden.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_Wpoz.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_Wvar.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();


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

