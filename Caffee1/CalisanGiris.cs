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
    public partial class CalisanGiris : Form
    {
        public CalisanGiris()
        {
            InitializeComponent();
              }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void CalisanGiris_Load(object sender, EventArgs e)
        {
            dataTable();
        }

       public void dataTable()
        {
            con = new SqlConnection("Data Source=LAPTOP-6LLA5LIQ;Initial Catalog=giris;Integrated Security=True");


            string kayit = "select * from davet";
            da = new SqlDataAdapter(kayit, con);
            DataTable tablo = new DataTable(); // tablo oluşturuluyor
            da.Fill(tablo); // tabloyu doldur
            dataGridView1.DataSource = tablo; // tabloyu dataGridViewe aktar
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-6LLA5LIQ;Initial Catalog=giris;Integrated Security=True");
          
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                con.Open();
                SqlCommand komut = new SqlCommand("delete from davet where DavetKodu ='" + dataGridView1.SelectedRows[i].Cells[0].Value.ToString() + "'", con);
                komut.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("SİLME İŞLEMİ BAŞARILI");
            dataTable();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
