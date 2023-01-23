using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using a;
using bizmar;
using Satış;

namespace bizmar
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaSatisEkrani x3 = new anaSatisEkrani();
            x3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BorcOdeme x5 = new BorcOdeme();
            x5.Show();
            this.Hide();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            urunekleme x9 = new urunekleme();
            x9.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            raporlar xx= new raporlar();
            xx.Show();    
            this.Hide();

        }
    }
}
