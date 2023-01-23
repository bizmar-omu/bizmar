using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bizmar;

namespace Satış
{
    public partial class musteriKayit : Form
    {
        musteri model = new musteri();
        public musteriKayit()
        {
            InitializeComponent();
        }


        private void txtmüsteriekle_Click(object sender, EventArgs e)
        {
            model.mNo = int.Parse(txtmno.Text.Trim());
            model.ad = txtAd.Text.Trim();
            model.soyad = txtsoyad.Text.Trim();
            model.telno = txttelefon.Text.Trim();    
            model.toplamOdenen = 0;
            model.toplamBorc = 0;
            model.toplamSatis = 0;
            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                db.musteri.Add(model);
                db.SaveChanges();           
            }
            this.Close();   

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void musteriKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
