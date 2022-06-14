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
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("20. maddesinin 1. fıkrasının (a) bendi", 50000, 500000, 68100, 681000);
            dataGridView1.Rows.Add("20. maddesinin 1. fıkrasının (b) bendi", 20000, 200000, 27420, 274200);
            dataGridView1.Rows.Add("20. maddesinin 1. fıkrasının (c) bendi", 20000, 200000, 27420, 274200);
            dataGridView1.Rows.Add("20. maddesinin 1. fıkrasının (ç) bendi", 10000, 100000, 13620, 136200);
            dataGridView1.Rows.Add("20. maddesinin 1. fıkrasının (e) bendi", 7000, 70000, 9534, 95340);
            dataGridView1.Rows.Add("20. maddesinin 5. fıkrası", 20000, 200000, 27420, 274200);
        }

        
    }
}
