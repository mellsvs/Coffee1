using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Web.UI.WebControls;

namespace Caffee1
{
    public partial class Menu2 : MetroSetForm
    {
        private readonly object listbox1;

        public Menu2()
        {
            InitializeComponent();
        }



        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void turkartı_Click(object sender, EventArgs e)
        {
            int kafi = Convert.ToInt32(miktar1.Text);
            kafi++;
            miktar1.Text = Convert.ToString(kafi);
        }

        private void turkeksi_Click(object sender, EventArgs e)
        {
            int kafi=0;
            if (kafi >= 0)
            {
                kafi = Convert.ToInt32(miktar1.Text);
                kafi--;
                miktar1.Text = Convert.ToString(kafi);
                if (kafi < 0)
                {
                    kafi = kafi * -1;
                    miktar1.Text = Convert.ToString(kafi);
                }
            }
            }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { // türk kahvesi sepete ekleme
            {   
                int toplam;

                if (checkBox1.Checked)
                {
                    listBox1.Items.Add(miktar1.Text+ " " + checkBox1.Text + " " + label3.Text);
                    
                    toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(label3.Text) * Convert.ToInt32(miktar1.Text);
                    textBox.Text = toplam.ToString();
                }
                else
                {
                    listBox1.Items.Remove(miktar1.Text+ " "+checkBox1.Text + " " + label3.Text);
                    
                    toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(label3.Text) * Convert.ToInt32(miktar1.Text);
                    textBox.Text = toplam.ToString();

                }

            }
        }


        private void label62_Click(object sender, EventArgs e)
        {
            int espresso = Convert.ToInt32(miktar2.Text);
            espresso++;
            miktar2.Text = Convert.ToString(espresso);

        }
        private void espressoeksi_Click(object sender, EventArgs e)
        {
            int espresso = 0;
            if (espresso >= 0)
            {
                espresso = Convert.ToInt32(miktar2.Text);
                espresso--;
                miktar2.Text = Convert.ToString(espresso);
                if (espresso < 0)
                {
                    espresso = espresso * -1;
                    miktar2.Text = Convert.ToString(espresso);
                }
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            {
                
             

                int toplam;
                if (checkBox2.Checked)
                {
                    listBox1.Items.Add(miktar2.Text + " " + checkBox2.Text + " " + label4.Text);
                    
                    toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(label4.Text) * Convert.ToInt32(miktar2.Text); ;
                    textBox.Text = toplam.ToString();
                }
                else
                {
                    listBox1.Items.Remove(miktar2.Text + " "+checkBox2.Text + " " + label4.Text);
                   
                    toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(label4.Text) * Convert.ToInt32(miktar2.Text); 
                    textBox.Text = toplam.ToString();

                }

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            {

                int toplam;
                if (checkBox3.Checked)
                {
                    listBox1.Items.Add(miktar3.Text + " " + checkBox3.Text + " " + label50.Text);
                    
                    toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(label50.Text) * Convert.ToInt32(miktar3.Text); ;
                    textBox.Text = toplam.ToString();
                }
                else
                {
                    listBox1.Items.Remove(miktar3.Text + " "+checkBox3.Text + " " + label50.Text);

                    toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(label50.Text) * Convert.ToInt32(miktar3.Text); ;
                    textBox.Text = toplam.ToString();

                }

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            {
                
                
                int toplam;
                if (checkBox4.Checked)
                {
                    listBox1.Items.Add(miktar4.Text + " " + checkBox4.Text + " " + label32.Text);
                    
                    toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(label32.Text) * Convert.ToInt32(miktar4.Text); 
                    textBox.Text = toplam.ToString();
                }
                else
                {
                    listBox1.Items.Remove(miktar4.Text + " "+checkBox4.Text + " " + label32.Text);
                    
                    toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(label32.Text) * Convert.ToInt32(miktar4.Text); 
                    textBox.Text = toplam.ToString();

                }

            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            {
                
              
                int toplam;
                if (checkBox5.Checked)
                {
                    listBox1.Items.Add(miktar5.Text + "" + checkBox5.Text + " " + label57.Text);
                    
                    toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(label57.Text) * Convert.ToInt32(miktar5.Text); ;
                    textBox.Text = toplam.ToString();
                }
                else
                {
                    listBox1.Items.Remove(miktar5.Text + " "+checkBox5.Text + " " + label57.Text);
                   
                    toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(label57.Text) * Convert.ToInt32(miktar5.Text);
                    textBox.Text = toplam.ToString();

                }

            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            {
               
              
                int toplam;
                if (checkBox6.Checked)
                {
                    listBox1.Items.Add(miktar6.Text + " " + checkBox6.Text + " " + label8.Text);
                   
                    toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(label8.Text) * Convert.ToInt32(miktar6.Text); 
                    textBox.Text = toplam.ToString();
                }
                else
                {
                    listBox1.Items.Remove(miktar6.Text + " "+checkBox6.Text + " " + label8.Text);
                  
                    toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(label8.Text) * Convert.ToInt32(miktar6.Text); 
                    textBox.Text = toplam.ToString();

                }

            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;

            
            if (checkBox7.Checked)
            {
                listBox1.Items.Add(miktar7.Text + " " + checkBox7.Text + " " + label13.Text);
                
                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(label13.Text) * Convert.ToInt32(miktar7.Text); 
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktar7.Text + " "+checkBox7.Text + " " + label13.Text);
               
                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(label13.Text) * Convert.ToInt32(miktar7.Text);
                textBox.Text = toplam.ToString();

            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

          
           
            int toplam;
            if (checkBox8.Checked)
            {
                listBox1.Items.Add(miktar8.Text + " " + checkBox8.Text + " " + label58.Text);
                
                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(label58.Text) * Convert.ToInt32(miktar8.Text); 
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktar8.Text + " "+miktar8.Text + " " + checkBox8.Text + " " + label58.Text);
               
                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(label58.Text) * Convert.ToInt32(miktar8.Text); 
                textBox.Text = toplam.ToString();
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {




            double toplam;
            toplam = Convert.ToInt32(textBox.Text);
        
            richTextBox1.Text += "Ödenecek tutar= " + toplam;

            SqlConnection baglanti = new SqlConnection("server=LAPTOP-6LLA5LIQ;database=Siparis;trusted_connection=true;");
            SqlCommand cmd = new SqlCommand();

           
     


            try
            {
                baglanti.Open();

                cmd.CommandText = "insert Fiyat(toplam) values(@toplam)";
         

                cmd.Connection = baglanti;
                cmd.Parameters.AddWithValue("@toplam", textBox.Text);
               
              //  cmd.Parameters.AddWithValue("@siparis", listBox1.Text.Trim());

                object sonuc = null;
                sonuc = cmd.ExecuteNonQuery();
                if (sonuc != null)
                {
                    //MessageBox.Show("Sisteme başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //int a = 0;
                }

                else
                    MessageBox.Show("Sisteme eklenemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                baglanti.Close();
            }
            catch (Exception HataYakala)
            {
                MessageBox.Show("Hata: " + HataYakala.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label64_Click(object sender, EventArgs e)
        {
            int filtre = Convert.ToInt32(miktar3.Text);
            filtre++;
            miktar3.Text = Convert.ToString(filtre);
        }

        private void filtreeksi_Click(object sender, EventArgs e)
        {
            int filtre = 0;
            if (filtre >= 0)
            {
                filtre = Convert.ToInt32(miktar3.Text);
                filtre--;
                miktar3.Text = Convert.ToString(filtre);
                if (filtre < 0)
                {
                    filtre = filtre * -1;
                    miktar3.Text = Convert.ToString(filtre);
                }
            }
        }

        private void sicakarti_Click(object sender, EventArgs e)
        {
            int sicak = Convert.ToInt32(miktar4.Text);
            sicak++;
            miktar4.Text = Convert.ToString(sicak);
        }

        private void sicakeksi_Click(object sender, EventArgs e)
        {
            int sicak = 0;
            if (sicak >= 0)
            { 
                sicak = Convert.ToInt32(miktar4.Text);
                sicak--;
                miktar4.Text = Convert.ToString(sicak);
                if (sicak < 0)
                {
                    sicak= sicak * -1;
                    miktar4.Text = Convert.ToString(sicak);
                }
            }
        }

        private void lattearti_Click(object sender, EventArgs e)
        {
            int latte = Convert.ToInt32(miktar5.Text);
            latte++;
            miktar5.Text = Convert.ToString(latte);
        }

        private void latteeksi_Click(object sender, EventArgs e)
        {
            int latte = 0;
            if (latte >= 0)
            {
                latte = Convert.ToInt32(miktar5.Text);
                latte--;
                miktar5.Text = Convert.ToString(latte);
                if (latte < 0)
                {
                    latte = latte * -1;
                    miktar5.Text = Convert.ToString(latte);
                }
            }
        }

        private void mochaarti_Click(object sender, EventArgs e)
        {
            int mocha = Convert.ToInt32(miktar6.Text);
            mocha++;
            miktar6.Text = Convert.ToString(mocha);

        }

        private void mochaeksi_Click(object sender, EventArgs e)
        {
            int mocha = 0;
            if (mocha >= 0)
            {
                mocha= Convert.ToInt32(miktar6.Text);
                mocha--;
                miktar6.Text = Convert.ToString(mocha);
                if (mocha < 0)
                {
                    mocha = mocha * -1;
                    miktar6.Text = Convert.ToString(mocha);
                }
            }

        }

        private void cayarti_Click(object sender, EventArgs e)
        {
            int cay = Convert.ToInt32(miktar7.Text);
            cay++;
            miktar7.Text = Convert.ToString(cay);
        }

        private void cayeksi_Click(object sender, EventArgs e)
        {
            int cay = 0;
            if (cay >= 0)
            {
                cay = Convert.ToInt32(miktar7.Text);
                cay--;
                miktar7.Text = Convert.ToString(cay);
                if (cay < 0)
                {
                    cay = cay * -1;
                    miktar7.Text = Convert.ToString(cay);
                }
            }

        }

        private void saleparti_Click(object sender, EventArgs e)
        {
            int salep = Convert.ToInt32(miktar8.Text);
            salep++;
            miktar8.Text = Convert.ToString(salep);
        }

        private void salepeksi_Click(object sender, EventArgs e)
        {
            int salep = 0;
            if (salep >= 0)
            {
                salep = Convert.ToInt32(miktar8.Text);
                salep--;
                miktar8.Text = Convert.ToString(salep);
                if (salep < 0)
                {
                    salep = salep * -1;
                    miktar8.Text = Convert.ToString(salep);
                }
            }

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

            int toplam;
            if (checkBox9.Checked)
            {
                listBox1.Items.Add(miktarsoguk1.Text + " " + checkBox9.Text + " " + labellimon.Text);

                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(labellimon.Text) * Convert.ToInt32(miktarsoguk1.Text);
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove( miktarsoguk1.Text + " " + checkBox9.Text + " " + labellimon.Text);

                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(labellimon.Text) * Convert.ToInt32(miktarsoguk1.Text);
                textBox.Text = toplam.ToString();
            }


        }

        private void limonarti_Click(object sender, EventArgs e)
        {

            int limon = Convert.ToInt32(miktarsoguk1.Text);
            limon++;
            miktarsoguk1.Text = Convert.ToString(limon);
        }

        private void limoneksi_Click(object sender, EventArgs e)
        {
            int limon = 0;
            if (limon >= 0)
            {
                limon = Convert.ToInt32(miktarsoguk1.Text);
                limon--;
                miktarsoguk1.Text = Convert.ToString(limon);
                if (limon < 0)
                {
                    limon = limon * -1;
                    miktarsoguk1.Text = Convert.ToString(limon);
                }
            }
        }

        private void label75_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_Gazli_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox_Gazli.Checked)
            {
                listBox1.Items.Add(miktarsoguk2.Text + " " + checkBox_Gazli.Text + " " + labelgaz.Text);

                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(labelgaz.Text) * Convert.ToInt32(miktarsoguk2.Text);
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktarsoguk2.Text + " " + checkBox_Gazli.Text + " " + labelgaz.Text);

                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(labelgaz.Text) * Convert.ToInt32(miktarsoguk2.Text);
                textBox.Text = toplam.ToString();
            }

        }

        private void gazarti_Click(object sender, EventArgs e)
        {
            int gaz = Convert.ToInt32(miktarsoguk2.Text);
            gaz++;
            miktarsoguk2.Text = Convert.ToString(gaz);
        }

        private void gazeksi_Click(object sender, EventArgs e)
        {
            int gaz = 0;
            if (gaz >= 0)
            {
                gaz = Convert.ToInt32(miktarsoguk2.Text);
                gaz--;
                miktarsoguk2.Text = Convert.ToString(gaz);
                if (gaz < 0)
                {
                    gaz = gaz * -1;
                    miktarsoguk2.Text = Convert.ToString(gaz);
                }
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox11.Checked)
            {
                listBox1.Items.Add(miktarsoguk3.Text + " " + checkBox11.Text + " " + labelmeyve.Text);

                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(labelmeyve.Text) * Convert.ToInt32(miktarsoguk3.Text);
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktarsoguk3.Text + " " + checkBox11.Text + " " + labelmeyve.Text);

                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(labelmeyve.Text) * Convert.ToInt32(miktarsoguk3.Text);
                textBox.Text = toplam.ToString();
            }
        }

        private void meyvearti_Click(object sender, EventArgs e)
        {

            int meyve = Convert.ToInt32(miktarsoguk3.Text);
            meyve++;
            miktarsoguk3.Text = Convert.ToString(meyve);
        }

        private void meyveeksi_Click(object sender, EventArgs e)
        {
            int meyve = 0;
            if (meyve >= 0)
            {
                meyve = Convert.ToInt32(miktarsoguk3.Text);
                meyve--;
                miktarsoguk3.Text = Convert.ToString(meyve);
                if (meyve < 0)
                {
                    meyve= meyve * -1;
                    miktarsoguk3.Text = Convert.ToString(meyve);
                }
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox12.Checked)
            {
                listBox1.Items.Add(miktarsoguk4.Text + " " + checkBox12.Text + " " + labelice.Text);

                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(labelice.Text) * Convert.ToInt32(miktarsoguk4.Text);
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktarsoguk4.Text + " " + checkBox12.Text + " " + labelice.Text);

                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(labelice.Text) * Convert.ToInt32(miktarsoguk4.Text);
                textBox.Text = toplam.ToString();
            }
        }

        private void icearti_Click(object sender, EventArgs e)
        {
            int ice = Convert.ToInt32(miktarsoguk4.Text);
            ice++;
            miktarsoguk4.Text = Convert.ToString(ice);
        }

        private void iceeksi_Click(object sender, EventArgs e)
        {
            int ice= 0;
            if (ice >= 0)
            {
                ice = Convert.ToInt32(miktarsoguk4.Text);
                ice--;
                miktarsoguk4.Text = Convert.ToString(ice);
                if (ice < 0)
                {
                    ice = ice * -1;
                    miktarsoguk4.Text = Convert.ToString(ice);
                }
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox14.Checked)
            {
                listBox1.Items.Add(miktarsoguk5.Text + " " + checkBox14.Text + " " + labelsoda.Text);

                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(labelsoda.Text) * Convert.ToInt32(miktarsoguk5.Text);
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktarsoguk5.Text + " " + checkBox14.Text + " " + labelsoda.Text);

                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(labelsoda.Text) * Convert.ToInt32(miktarsoguk5.Text);
                textBox.Text = toplam.ToString();
            }
        }

        private void sodaarti_Click(object sender, EventArgs e)
        {
            int soda = Convert.ToInt32(miktarsoguk5.Text);
            soda++;
            miktarsoguk5.Text = Convert.ToString(soda);
        }

        private void sodaeksi_Click(object sender, EventArgs e)
        {
            int soda = 0;
            if (soda>= 0)
            {
                soda = Convert.ToInt32(miktarsoguk5.Text);
                soda--;
                miktarsoguk5.Text = Convert.ToString(soda);
                if (soda < 0)
                {
                    soda = soda * -1;
                    miktarsoguk5.Text = Convert.ToString(soda);
                }
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox15.Checked)
            {
                listBox1.Items.Add(miktarsoguk6.Text + " " + checkBox15.Text + " " + labelaff.Text);

                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(labelaff.Text) * Convert.ToInt32(miktarsoguk6.Text);
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktarsoguk6.Text + " " + checkBox15.Text + " " + labelaff.Text);

                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(labelaff.Text) * Convert.ToInt32(miktarsoguk6.Text);
                textBox.Text = toplam.ToString();
            }
        }

        private void affarti_Click(object sender, EventArgs e)
        {
            int aff = Convert.ToInt32(miktarsoguk6.Text);
            aff++;
            miktarsoguk6.Text = Convert.ToString(aff);
        }

        private void affeksi_Click(object sender, EventArgs e)
        {
            int aff = 0;
            if (aff >= 0)
            {
                aff = Convert.ToInt32(miktarsoguk6.Text);
              aff--;
                miktarsoguk6.Text = Convert.ToString(aff);
                if (aff < 0)
                {
                    aff= aff * -1;
                    miktarsoguk6.Text = Convert.ToString(aff);
                }
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox16.Checked)
            {
                listBox1.Items.Add(miktarsoguk7.Text + " " + checkBox16.Text + " " + labelsu.Text);

                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(labelsu.Text) * Convert.ToInt32(miktarsoguk7.Text);
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktarsoguk7.Text + " " + checkBox16.Text + " " + labelsu.Text);

                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(labelsu.Text) * Convert.ToInt32(miktarsoguk7.Text);
                textBox.Text = toplam.ToString();
            }
        }

        private void suarti_Click(object sender, EventArgs e)
        {
            int su = Convert.ToInt32(miktarsoguk7.Text);
            su++;
            miktarsoguk7.Text = Convert.ToString(su);
        }

        private void sueksi_Click(object sender, EventArgs e)
        {
            int su = 0;
            if (su >= 0)
            {
                su = Convert.ToInt32(miktarsoguk7.Text);
                su--;
                miktarsoguk7.Text = Convert.ToString(su);
                if (su < 0)
                {
                    su = su * -1;
                    miktarsoguk7.Text = Convert.ToString(su);
                }
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox13.Checked)
            {
                listBox1.Items.Add(miktarsoguk8.Text + " " + checkBox13.Text + " " + labelmilk.Text);

                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(labelmilk.Text) * Convert.ToInt32(miktarsoguk8.Text);
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktarsoguk8.Text + " " + checkBox13.Text + " " + labelmilk.Text);

                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(labelmilk.Text) * Convert.ToInt32(miktarsoguk8.Text);
                textBox.Text = toplam.ToString();
            }

        }

        private void milkarti_Click(object sender, EventArgs e)
        {
            int milk = Convert.ToInt32(miktarsoguk7.Text);
            milk++;
            miktarsoguk8.Text = Convert.ToString(milk);
        }

        private void milkeksi_Click(object sender, EventArgs e)
        {
            int milk = 0;
            if (milk >= 0)
            {
                milk= Convert.ToInt32(miktarsoguk8.Text);
                milk--;
                miktarsoguk8.Text = Convert.ToString(milk);
                if (milk < 0)
                {
                    milk = milk * -1;
                    miktarsoguk8.Text = Convert.ToString(milk);
                }
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox17.Checked)
            {
                listBox1.Items.Add(miktardon.Text + " " + checkBox17.Text + " " + labeldon.Text);

                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(labeldon.Text) * Convert.ToInt32(miktardon.Text);
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktardon.Text + " " + checkBox17.Text + " " + labeldon.Text);

                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(labeldon.Text) * Convert.ToInt32(miktardon.Text);
                textBox.Text = toplam.ToString();
            }
        }

        private void donarti_Click(object sender, EventArgs e)
        {

            int don = Convert.ToInt32(miktardon.Text);
            don++;
            miktardon.Text = Convert.ToString(don);

        }

        private void doneksi_Click(object sender, EventArgs e)
        {
            int don = 0;
            if (don >= 0)
            {
                don= Convert.ToInt32(miktardon.Text);
                don--;
                miktardon.Text = Convert.ToString(don);
                if (don< 0)
                {
                    don = don  * -1;
                    miktardon.Text = Convert.ToString(don);
                }
            }

        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox18.Checked)
            {
                listBox1.Items.Add(miktarcookie.Text + " " + checkBox18.Text + " " + labelc.Text);

                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(labelc.Text) * Convert.ToInt32(miktarcookie.Text);
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktarcookie.Text + " " + checkBox18.Text + " " + labelc.Text);

                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(labelc.Text) * Convert.ToInt32(miktarcookie.Text);
                textBox.Text = toplam.ToString();
            }

        }

        private void cookiearti_Click(object sender, EventArgs e)
        {
            int cooke = Convert.ToInt32(miktarcookie.Text);
            cooke++;
            miktarcookie.Text = Convert.ToString(cooke);

        }

        private void cookieeksi_Click(object sender, EventArgs e)
        {
            int cooke = 0;
            if (cooke >= 0)
            {
                cooke = Convert.ToInt32(miktarcookie.Text);
                cooke--;
                miktarcookie.Text = Convert.ToString(cooke);
                if (cooke < 0)
                {
                    cooke = cooke * -1;
                    miktarcookie.Text = Convert.ToString(cooke);
                }
            }

        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox19.Checked)
            {
                listBox1.Items.Add(miktarmuf.Text + " " + checkBox19.Text + " " + labelm.Text);

                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(labelm.Text) * Convert.ToInt32(miktarmuf.Text);
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktarmuf.Text + " " + checkBox19.Text + " " + labelm.Text);

                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(labelm.Text) * Convert.ToInt32(miktarmuf.Text);
                textBox.Text = toplam.ToString();
            }
        }

        private void muffinarti_Click(object sender, EventArgs e)
        {

            int muf = Convert.ToInt32(miktarmuf.Text);
            muf++;
            miktarmuf.Text = Convert.ToString(muf);

        }

        private void muffineksi_Click(object sender, EventArgs e)
        {
            int muf = 0;
            if (muf >= 0)
            {
                muf = Convert.ToInt32(miktarmuf.Text);
                muf--;
                miktarmuf.Text = Convert.ToString(muf);
                if (muf < 0)
                {
                    muf = muf * -1;
                    miktarmuf.Text = Convert.ToString(muf);
                }
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox20.Checked)
            {
                listBox1.Items.Add(miktarcheese.Text + " " + checkBox20.Text + " " + labelcheese.Text);

                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(labelcheese.Text) * Convert.ToInt32(miktarcheese.Text);
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktarcheese.Text + " " + checkBox20.Text + " " + labelcheese.Text);

                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(labelcheese.Text) * Convert.ToInt32(miktarcheese.Text);
                textBox.Text = toplam.ToString();
            }
        }

        private void cheesearti_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(miktarcheese.Text);
            c++;
            miktarcheese.Text = Convert.ToString(c);
        }

        private void cheeseeksi_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (c >= 0)
            {
               c = Convert.ToInt32(miktarcheese.Text);
               c--;
                miktarcheese.Text = Convert.ToString(c);
                if (c < 0)
                {
                    c = c * -1;
                    miktarcheese.Text = Convert.ToString(c);
                }
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox21.Checked)
            {
                listBox1.Items.Add(miktarsand.Text + " " + checkBox21.Text + " " + labelsand.Text);

                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(labelsand.Text) * Convert.ToInt32(miktarsand.Text);
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktarsand.Text + " " + checkBox21.Text + " " + labelsand.Text);

                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(labelsand.Text) * Convert.ToInt32(miktarsand.Text);
                textBox.Text = toplam.ToString();
            }
        }

        private void sandarti_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(miktarsand.Text);
            c++;
            miktarsand.Text = Convert.ToString(c);

        }

        private void sandeksi_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (c >= 0)
            {
                c = Convert.ToInt32(miktarsand.Text);
                c--;
                miktarsand.Text = Convert.ToString(c);
                if (c < 0)
                {
                    c = c * -1;
                    miktarsand.Text = Convert.ToString(c);
                }
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox22.Checked)
            {
                listBox1.Items.Add(miktarbrownie.Text + " " + checkBox22.Text + " " + labelbrow.Text);

                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(labelbrow.Text) * Convert.ToInt32(miktarbrownie.Text);
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktarbrownie.Text + " " + checkBox22.Text + " " + labelbrow.Text);

                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(labelbrow.Text) * Convert.ToInt32(miktarbrownie.Text);
                textBox.Text = toplam.ToString();
            }
        }

        private void browarti_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(miktarbrownie.Text);
            c++;
            miktarbrownie.Text = Convert.ToString(c);
        }

        private void broweksi_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (c >= 0)
            {
                c = Convert.ToInt32(miktarbrownie.Text);
                c--;
                miktarbrownie.Text = Convert.ToString(c);
                if (c < 0)
                {
                    c = c * -1;
                    miktarbrownie.Text = Convert.ToString(c);
                }
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox23.Checked)
            {
                listBox1.Items.Add(miktarwaffle.Text + " " + checkBox23.Text + " " + labelwaffle.Text);

                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(labelwaffle.Text) * Convert.ToInt32(miktarwaffle.Text);
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktarwaffle.Text + " " + checkBox23.Text + " " + labelwaffle.Text);

                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(labelwaffle.Text) * Convert.ToInt32(miktarwaffle.Text);
                textBox.Text = toplam.ToString();
            }
        }

        private void wafflearti_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(miktarwaffle.Text);
            c++;
            miktarwaffle.Text = Convert.ToString(c);
        }

        private void waffleeksi_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (c >= 0)
            {
                c = Convert.ToInt32(miktarwaffle.Text);
                c--;
                miktarwaffle.Text = Convert.ToString(c);
                if (c < 0)
                {
                    c = c * -1;
                    miktarwaffle.Text = Convert.ToString(c);
                }
            }
        }

        private void CheckBoxd_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBoxd.Checked)
            {
                listBox1.Items.Add(miktardonut.Text + " " + checkBoxd.Text + " " + labeldonut.Text);

                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(labeldonut.Text) * Convert.ToInt32(miktardonut.Text);
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktardonut.Text + " " + checkBoxd.Text + " " + labeldonut.Text);

                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(labeldonut.Text) * Convert.ToInt32(miktardonut.Text);
                textBox.Text = toplam.ToString();
            }
        }

        private void donutarti_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(miktardonut.Text);
            c++;
            miktardonut.Text = Convert.ToString(c);
        }

        private void donuteksi_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (c >= 0)
            {
                c = Convert.ToInt32(miktardonut.Text);
                c--;
                miktardonut.Text = Convert.ToString(c);
                if (c < 0)
                {
                    c = c * -1;
                    miktardonut.Text = Convert.ToString(c);
                }
            }
        }

        private void Menu2_Load(object sender, EventArgs e)
        {

        }

        private void metroSetSetTabPage1_Click(object sender, EventArgs e)
        {

        }
    }

}



