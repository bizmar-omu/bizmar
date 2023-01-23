using kar_zarar_rapor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace bizmar
{
    public partial class raporlar : Form
    {
        public raporlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ikitarihgrafik xb = new ikitarihgrafik();
            xb.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Karzarar xc = new Karzarar();
            xc.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            coktanazaurunlistesi xa = new coktanazaurunlistesi();
            xa.Show();
            this.Hide();
        }



    }
}
