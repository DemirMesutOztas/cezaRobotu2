using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 2)
            {
                comboBox4.Enabled = true;
              comboBox7.Enabled = true;
                


            }
            MessageBox.Show(comboBox1.SelectedIndex.ToString());





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

        private void button1_Click(object sender, EventArgs e)
        {
            int x=-1;
            x = comboBox1.SelectedIndex;

            if (comboBox2.SelectedItem.ToString() == "2021")
            {
                altlimit = Convert.ToInt32(secondForm.dataGridView1.Rows[x].Cells[1].Value);
                ustlimit = Convert.ToInt32(secondForm.dataGridView1.Rows[x].Cells[2].Value);
            }
            else if (comboBox2.SelectedItem.ToString() == "2022")
            {
                altlimit = Convert.ToInt32(secondForm.dataGridView1.Rows[x].Cells[3].Value);
                ustlimit = Convert.ToInt32(secondForm.dataGridView1.Rows[x].Cells[4].Value);
            }

           
            sonuc = altlimit * sinif * hse * tekrar;

            if (sonuc > ustlimit || (comboBox7.SelectedItem.ToString() == "Evet"))
            {
                sonuc = ustlimit;
            }
            

            textBox1.Text = sonuc.ToString();


        }
    }
}
