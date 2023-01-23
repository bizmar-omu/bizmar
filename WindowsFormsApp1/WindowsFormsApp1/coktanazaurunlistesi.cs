using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class coktanazaurunlistesi : Form
    {
        public coktanazaurunlistesi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (mahalleMarketiEntities1 db = new mahalleMarketiEntities1())
            {
                var urunler = db.sayac.Join(db.urun, s => s.urunKodu, u => u.urunKodu, 
                    (s, u) => new { urunKodu = s.urunKodu,
                    urunAd = u.urunAd, urunSayaci = s.urunSayaci}).ToList();
                urunler.Reverse();

                dgvUrunListesi.AutoGenerateColumns = false;
                dgvUrunListesi.DataSource = urunler;
            }
        }

        private void dgvUrunListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
