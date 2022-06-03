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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server=LAPTOP-6LLA5LIQ;database=giris;trusted_connection=true;");
        //
        //
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //
        //
        

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/maps/place/Arabica+Coffee+House+Be%C5%9Fevler/@39.9320189,32.8233112,17z/data=!3m1!4b1!4m5!3m4!1s0x14d3451f67ac6edf:0xd17db610eeb16bec!8m2!3d39.9320182!4d32.8254999");
        }

        public void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {


            System.Diagnostics.Process.Start("https://www.youtube.com/");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");


        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/intl/tr/gmail/about/");

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Help form2 = new Help();
            form2.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu2 menu2 = new Menu2();
            menu2.Show();
            this.Hide();
        }

       

        private void button9_Click(object sender, EventArgs e)
        {
            KayitOl form4 = new KayitOl();
            form4.Show();
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
         
            BizeKatil bizeKatil = new BizeKatil();
            bizeKatil.Show();
            this.Hide();  
            

        }

       

       

   
        private void button7_Click(object sender, EventArgs e)
        {
            Sube sube = new Sube();
            sube.Show();
            this.Hide();
        }

       

        private void button10_Click(object sender, EventArgs e)
        {
            Magaza magaza = new Magaza();
            magaza.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Davet davet = new Davet();
            davet.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Franchise franchise = new Franchise();
            franchise.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Yonetici yonetici = new Yonetici();
            yonetici.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // giriş butonu

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kayit where kul_adi ='" + txt_user.Text.Trim() + "'and sifre ='" + txt_pass.Text.Trim() + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Giris giris = new Giris();
                giris.Show();
                txt_user.Clear();
                txt_pass.Clear();
                button8.Enabled = true;

            }
            else
            {
                MessageBox.Show("yanlış giriş");
                txt_user.Clear();
                txt_pass.Clear();

            }
            baglanti.Close();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
   private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SanaOzel sanaOzel = new SanaOzel();
            sanaOzel.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CalisanaMain calisanaMain = new CalisanaMain();
            calisanaMain.Show();
            this.Hide();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Firsatlar firsatlar = new Firsatlar();
            firsatlar.Show();
            this.Hide();

        }
    }
    }

