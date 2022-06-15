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
        public int altlimit;
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


            switch (comboBox1.SelectedIndex)
            {
                case 0:

                    altlimit = (int)secondForm.dataGridView1.Rows[0].Cells[1].Value;
                   
                    break;

                case 1:

                    altlimit = (int)secondForm.dataGridView1.Rows[1].Cells[1].Value;

                    break;

                case 2:

                    altlimit = (int)secondForm.dataGridView1.Rows[2].Cells[1].Value;

                    break;

                case 3:

                    altlimit = (int)secondForm.dataGridView1.Rows[3].Cells[1].Value;

                    break;

                case 4:

                    altlimit = (int)secondForm.dataGridView1.Rows[4].Cells[1].Value;

                    break;

                case 5:

                    altlimit = (int)secondForm.dataGridView1.Rows[5].Cells[1].Value;

                    break;

                case 6:

                    altlimit = (int)secondForm.dataGridView1.Rows[6].Cells[1].Value;

                    break;

                case 7:

                    altlimit = (int)secondForm.dataGridView1.Rows[7].Cells[1].Value;

                    break;
            }
            
           
        }
    }
}
