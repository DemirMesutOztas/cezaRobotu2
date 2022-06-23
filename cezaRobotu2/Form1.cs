using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cezaRobotu2
{
    

    public partial class Form1 : Form
    {
        
        public double altlimit;
        public double sinif;
        public double hse;
        public double tekrar;
        public double olum;
        public double sonuc;
        public double ustlimit;
        public double aykirilik;


        Form2 secondForm = new Form2();
            
            
        public Form1()
        {
            InitializeComponent();
            
            
        }

        public void cezaLimitleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 14)
            {
                
                comboBox5.Enabled = false;
                comboBox8.Enabled = false;
                comboBox4.Enabled = true;
                
                comboBox7.Enabled = true;
                comboBox3.Enabled = true;

               
            }
          else if (comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 2 || comboBox1.SelectedIndex == 3 || comboBox1.SelectedIndex == 4 || comboBox1.SelectedIndex == 5
                         || comboBox1.SelectedIndex == 8 || comboBox1.SelectedIndex == 10 || comboBox1.SelectedIndex == 11 || comboBox1.SelectedIndex == 13 || comboBox1.SelectedIndex == 15
                         || comboBox1.SelectedIndex == 16 || comboBox1.SelectedIndex == 17 || comboBox1.SelectedIndex == 19 || comboBox1.SelectedIndex == 22
                         || comboBox1.SelectedIndex == 23 || comboBox1.SelectedIndex == 24 || comboBox1.SelectedIndex == 25 || comboBox1.SelectedIndex == 28
                         || comboBox1.SelectedIndex == 30 || comboBox1.SelectedIndex == 31 || comboBox1.SelectedIndex == 33 || comboBox1.SelectedIndex == 34
                         || comboBox1.SelectedIndex == 35 || comboBox1.SelectedIndex == 39 || comboBox1.SelectedIndex == 41 || comboBox1.SelectedIndex == 42)
            {
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox8.Enabled = false;
                comboBox7.Enabled = false;
                comboBox3.Enabled = true;


            }
            else if (comboBox1.SelectedIndex == 21 || comboBox1.SelectedIndex == 29)
            {
                if(comboBox7.SelectedIndex==0)
                {
                    comboBox4.Enabled = true;
                }
                else if(comboBox7.SelectedIndex ==1)
                {
                    comboBox4.Enabled = false;
                }
                

                comboBox3.Enabled = false;
                comboBox8.Enabled = true;
                comboBox7.Enabled = true;
                comboBox5.Enabled = true;
            }
            else if ((comboBox1.SelectedIndex == 6 || comboBox1.SelectedIndex == 7 || comboBox1.SelectedIndex == 9 || comboBox1.SelectedIndex == 12
                          || comboBox1.SelectedIndex == 18 || comboBox1.SelectedIndex == 20 || comboBox1.SelectedIndex == 26 || comboBox1.SelectedIndex == 27
                          || comboBox1.SelectedIndex == 32 || comboBox1.SelectedIndex == 36 || comboBox1.SelectedIndex == 37 || comboBox1.SelectedIndex == 38
                          || comboBox1.SelectedIndex == 40 || comboBox1.SelectedIndex == 43))
            {
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox8.Enabled = false;
                comboBox7.Enabled = false;
                
                comboBox3.Enabled = false;

            }
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    sinif = 1;

                    break;
                case 1:
                    sinif = 1.5;

                    break;
                case 2:
                    sinif = 1.5;

                    break;
                case 3:
                    sinif = 2;

                    break;
                case 4:
                    sinif = 2.5;

                    break;
                case 5:
                    sinif = 3;

                    break;
                case 6:
                    sinif = 3;

                    break;
                case 7:
                    sinif = 1;

                    break;
                case 8:
                    sinif = 2;

                    break;
                case 9:
                    sinif = 2.5;

                    break;
                case 10:
                    sinif = 3;

                    break;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedIndex)
            {
                case 0:
                    hse = 1;
                    break;
                case 1:
                    hse = 2;
                    break;
                case 2:
                    hse = 4;
                    break;
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex==0)
            {
                tekrar = 2;
            }
            else if (comboBox6.SelectedIndex==1)
            {
                tekrar = 1;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0)
            {
                aykirilik = 1;
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                aykirilik = 2;
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        { /*
            if (comboBox7.SelectedItem.ToString() == "Hayır")
            {
                olum = 1;
            }
            else if (comboBox7.SelectedItem.ToString() == "Evet")
            {
                olum = 100000;
            }
            */
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            string mesaj = "";
            int x;
            x = comboBox1.SelectedIndex;
            try
            {

                if (comboBox2.SelectedIndex == 0)
                {
                    altlimit = Convert.ToInt32(secondForm.dataGridView1.Rows[x].Cells[2].Value);
                    ustlimit = Convert.ToInt32(secondForm.dataGridView1.Rows[x].Cells[3].Value);
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    altlimit = Convert.ToInt32(secondForm.dataGridView1.Rows[x].Cells[4].Value);
                    ustlimit = Convert.ToInt32(secondForm.dataGridView1.Rows[x].Cells[5].Value);
                }


                if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 14)
                {
                    if (comboBox7.SelectedItem.ToString() == "Evet")
                    {
                        sonuc = ustlimit;
                        if (sonuc > ustlimit)
                        {
                            sonuc = ustlimit;
                        }

                        mesaj += "Ölüm durumunda üst limit uygulanır." + "\r\n" + "Üst Limit: " + ustlimit;
                    }
                    else
                    {
                        sonuc = altlimit * sinif * hse * tekrar;
                        if (sonuc > ustlimit)
                        {
                            sonuc = ustlimit;
                        }

                        mesaj += "Alt Limit: " + altlimit + "\r\n" + "Ürün Sınıfı: " + sinif + "\r\n" +
                                 "Halk Sağlığına Etkisi: " + hse + "\r\n" + "Tekrar Durumu: " + tekrar + "\r\n" +
                                 "Sonuç: " + altlimit + "*" + sinif + "*" + hse + "*" + tekrar;
                    }




                }
                else if (comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 2 || comboBox1.SelectedIndex == 3 ||
                         comboBox1.SelectedIndex == 4 || comboBox1.SelectedIndex == 5
                         || comboBox1.SelectedIndex == 8 || comboBox1.SelectedIndex == 10 ||
                         comboBox1.SelectedIndex == 11 || comboBox1.SelectedIndex == 13 || comboBox1.SelectedIndex == 15
                         || comboBox1.SelectedIndex == 16 || comboBox1.SelectedIndex == 17 ||
                         comboBox1.SelectedIndex == 19 || comboBox1.SelectedIndex == 22
                         || comboBox1.SelectedIndex == 23 || comboBox1.SelectedIndex == 24 ||
                         comboBox1.SelectedIndex == 25 || comboBox1.SelectedIndex == 28
                         || comboBox1.SelectedIndex == 30 || comboBox1.SelectedIndex == 31 ||
                         comboBox1.SelectedIndex == 33 || comboBox1.SelectedIndex == 34
                         || comboBox1.SelectedIndex == 35 || comboBox1.SelectedIndex == 39 ||
                         comboBox1.SelectedIndex == 41 || comboBox1.SelectedIndex == 42)
                {

                    sonuc = altlimit * sinif * tekrar;
                    if (sonuc > ustlimit)
                    {
                        sonuc = ustlimit;
                    }

                    mesaj += "Alt Limit: " + altlimit + "\r\n" + "Ürün Sınıfı: " + sinif + "\r\n" +
                             "Tekrar Durumu: " + tekrar + "\r\n" +
                             "Sonuç: " + altlimit + "*" + sinif + "*" + tekrar;

                }
                else if (comboBox1.SelectedIndex == 21 || comboBox1.SelectedIndex == 29)
                {
                    if (comboBox8.SelectedIndex == 0)
                    {
                        if (comboBox7.SelectedItem.ToString() == "Evet")
                        {
                            sonuc = ustlimit;
                            if (sonuc > ustlimit)
                            {
                                sonuc = ustlimit;
                            }

                            mesaj += "Ölüm durumunda üst limit uygulanır." + "\r\n" + "Üst Limit: " + ustlimit;
                        }
                        else if (comboBox7.SelectedItem.ToString() == "Hayır")
                        {
                            sonuc = altlimit * aykirilik * hse * tekrar;
                            if (sonuc > ustlimit)
                            {
                                sonuc = ustlimit;
                            }

                            mesaj += "Alt Limit: " + altlimit + "\r\n" + "Ürün Sınıfı: " + sinif + "\r\n" +
                                     "Aykırılık Seviyei: " + aykirilik + "\r\n" + "Halk Sağlığına Etkisi: " + hse +
                                     "\r\n" +
                                     "Tekrar Durumu: " + tekrar + "\r\n" +
                                     "Sonuç: " + altlimit + "*" + sinif + "*" + aykirilik + "*" + hse + "*" + tekrar;
                        }




                    }
                    else if (comboBox8.SelectedIndex == 1)
                    {
                        sonuc = altlimit * aykirilik * tekrar;
                        if (sonuc > ustlimit)
                        {
                            sonuc = ustlimit;
                        }

                        mesaj += "Alt Limit: " + altlimit + "\r\n" + "Aykırılık Seviyesi: " + aykirilik + "\r\n" +
                                 "Tekrar Durumu: " + tekrar + "\r\n" +
                                 "Sonuç: " + altlimit + "*" + aykirilik + "*" + tekrar;
                    }

                }
                else if ((comboBox1.SelectedIndex == 6 || comboBox1.SelectedIndex == 7 ||
                          comboBox1.SelectedIndex == 9 || comboBox1.SelectedIndex == 12
                          || comboBox1.SelectedIndex == 18 || comboBox1.SelectedIndex == 20 ||
                          comboBox1.SelectedIndex == 26 || comboBox1.SelectedIndex == 27
                          || comboBox1.SelectedIndex == 32 || comboBox1.SelectedIndex == 36 ||
                          comboBox1.SelectedIndex == 37 || comboBox1.SelectedIndex == 38
                          || comboBox1.SelectedIndex == 40 || comboBox1.SelectedIndex == 43))
                {
                    sonuc = altlimit * tekrar;

                    if (sonuc > ustlimit)
                    {
                        sonuc = ustlimit;
                    }

                    mesaj += "Alt Limit: " + altlimit + "\r\n" +
                             "Tekrar Durumu: " + tekrar + "\r\n" +
                             "Sonuç: " + altlimit + "*" + tekrar;
                }

                foreach (Control clt in this.Controls)
                {
                    if (clt is ComboBox)
                    {
                        if (clt.Enabled)
                        {
                            if (clt.Text == String.Empty)
                            {
                                throw new Exception();

                            }
                        }



                    }
                }


                textBox2.Text = mesaj;
                textBox1.Text = sonuc.ToString();


            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Aktif tüm alanlar doldurulmalıdır!", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                

            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Aktif tüm alanlar doldurulmalıdır!", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

            }
            catch (System.Exception)
            {
                MessageBox.Show("Aktif tüm alanlar doldurulmalıdır!", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;
            
            textBox1.Clear();
            textBox2.Clear();
        }

        private void cezaLimitleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            secondForm.Show();
            this.Hide();
        }

        private void robotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }
    }
}
