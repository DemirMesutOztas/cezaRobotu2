﻿using System;
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
        public double altlimit=0;
        public double sinif = 0;
        public double hse = 0;
        public double tekrar = 1;
        public double olum = 1;
        public double sonuc = 0;
        public double ustlimit;
        public double aykirilik;


        Form2 secondForm = new Form2();
            
            
            


        public Form1()
        {
            InitializeComponent();

            
            
        }

        public void cezaLimitleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

            secondForm.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*

            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 2)
            {
                comboBox4.Enabled = true;
                comboBox7.Enabled = true;
                


            }
          
            */
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
            if (comboBox6.SelectedItem.ToString() == "Evet")
            {
                tekrar = 2;
            }
            else
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
        {
            if (comboBox5.SelectedItem.ToString() == "Hayır")
            {
                olum = 1;
            }
            else if (comboBox5.SelectedItem.ToString() == "Evet")
            {
                olum = ustlimit;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            x = comboBox1.SelectedIndex;

            if (comboBox2.SelectedItem.ToString() == "2021")
            {
                altlimit = Convert.ToInt32(secondForm.dataGridView1.Rows[x].Cells[2].Value);
                ustlimit = Convert.ToInt32(secondForm.dataGridView1.Rows[x].Cells[3].Value);
            }
            else if (comboBox2.SelectedItem.ToString() == "2022")
            {
                altlimit = Convert.ToInt32(secondForm.dataGridView1.Rows[x].Cells[4].Value);
                ustlimit = Convert.ToInt32(secondForm.dataGridView1.Rows[x].Cells[5].Value);
            }


            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 13)
            {
                sonuc = altlimit * sinif * hse * tekrar * olum;
            }
            else if (comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 2 || comboBox1.SelectedIndex == 3 || comboBox1.SelectedIndex == 4
                     || comboBox1.SelectedIndex == 7 || comboBox1.SelectedIndex == 9 || comboBox1.SelectedIndex == 10 || comboBox1.SelectedIndex == 12 
                     || comboBox1.SelectedIndex == 14 || comboBox1.SelectedIndex == 15 || comboBox1.SelectedIndex == 17 || comboBox1.SelectedIndex == 20 
                     || comboBox1.SelectedIndex == 21 || comboBox1.SelectedIndex == 22 || comboBox1.SelectedIndex == 23 || comboBox1.SelectedIndex == 26 
                     || comboBox1.SelectedIndex == 28 || comboBox1.SelectedIndex == 29 || comboBox1.SelectedIndex == 31 || comboBox1.SelectedIndex == 32 
                     || comboBox1.SelectedIndex == 33 || comboBox1.SelectedIndex == 37 || comboBox1.SelectedIndex == 39 || comboBox1.SelectedIndex == 40)
            {

                sonuc = altlimit * sinif * tekrar;

            }
            else if (comboBox1.SelectedIndex == 19 || comboBox1.SelectedIndex == 27)
            {
                if (comboBox8.SelectedItem.ToString() == "Evet")
                {
                    sonuc = altlimit * aykirilik * hse * tekrar*olum;
                }
                else if(comboBox8.SelectedItem.ToString()=="Hayır")
                {
                    sonuc = altlimit * aykirilik * tekrar;
                }
                
            }
            else if ((comboBox1.SelectedIndex == 5 || comboBox1.SelectedIndex == 6 || comboBox1.SelectedIndex == 8 || comboBox1.SelectedIndex == 11
                      || comboBox1.SelectedIndex == 16 || comboBox1.SelectedIndex == 18 || comboBox1.SelectedIndex == 24 || comboBox1.SelectedIndex == 25
                      || comboBox1.SelectedIndex == 30 || comboBox1.SelectedIndex == 34 || comboBox1.SelectedIndex == 35 || comboBox1.SelectedIndex == 36
                      || comboBox1.SelectedIndex == 38 || comboBox1.SelectedIndex == 41))
            {
                sonuc = altlimit * tekrar;
            }
            

            if (sonuc > ustlimit || (comboBox7.SelectedItem.ToString() == "Evet"))
            {
                sonuc = ustlimit;
            }

           

            textBox2.Text += comboBox1.SelectedItem.ToString()+"\n" + comboBox2.SelectedItem.ToString()+"\n" + comboBox3.SelectedItem.ToString()+"\n" +
                            comboBox5.SelectedItem.ToString()+"\n" + comboBox4.SelectedItem.ToString()+"\n" + comboBox6.SelectedItem.ToString()+"\n" +
                            comboBox7.SelectedItem.ToString()+"\n" + comboBox8.SelectedItem.ToString()+"\n";

            textBox1.Text = sonuc.ToString();


        }

       
    }
}
