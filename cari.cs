using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satış
{
    
    public partial class cari : Form
    {
        musteri model = new musteri();
        cariSatis cSatis= new cariSatis();
        public cari()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                cariSatis sonSatis = db.cariSatis.ToList<cariSatis>().Last<cariSatis>();
                cSatis.csNo = sonSatis.csNo + 1;
                txtcsNo.Text = (cSatis.csNo).ToString();
            }
            LoadData();
        }

        void LoadData()
        {
            dataGridView1.AutoGenerateColumns = false;
            using(mahalleMarketiEntities db= new mahalleMarketiEntities())
            {
                dataGridView1.DataSource = db.musteri.ToList<musteri>();
            }
        }

        void ara()
        {
            mahalleMarketiEntities db = new mahalleMarketiEntities();
            int musteri = Convert.ToInt32(txtmNo.Text);
            dataGridView1.DataSource = db.musteri.Where(x => x.mNo == (musteri)).ToList();
        }

        private void txtmNo_TextChanged(object sender, EventArgs e)
        {
            ara();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Index != 1)
            {
                model.mNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells["mNo"].Value);
                using (mahalleMarketiEntities db = new mahalleMarketiEntities())
                {
                    model = db.musteri.Where(x => x.mNo ==model.mNo).FirstOrDefault();
                    txtmNo.Text = model.mNo.ToString();
                    txtAd.Text =model.ad.ToString();
                    txtSoyad.Text = model.soyad.ToString(); 
                }
            }
        }

        private void bonayla_Click(object sender, EventArgs e)
        {
            hesapla();
            LoadData();
            ara();
            kaydet();
        }

        void hesapla()
        {
            using(mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                model = db.musteri.Where(x => x.mNo == model.mNo).FirstOrDefault();
                int a;
                a = Convert.ToInt32(txttoplamm.Text);
                model.toplamBorc += a;
                model.toplamSatis += a;
                db.SaveChanges();
            }

        }

        void kaydet()
        {
            cSatis.csNo = int.Parse(txtcsNo.Text.Trim());
            cSatis.csTutar = int.Parse(txttoplamm.Text.Trim());
            cSatis.csTarih = dateTimePicker1.Value;
            cSatis.mNo = int.Parse(txtmNo.Text.Trim());
            cSatis.ulNo = 0;
            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                db.cariSatis.Add(cSatis);
                db.SaveChanges();
            }
        }

        private void bkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void byenimüsteri_Click(object sender, EventArgs e)
        {
            müsteriKayıt form5= new müsteriKayıt();
            form5.Show();
        }

        private void bYenile_Click(object sender, EventArgs e)
        {
            LoadData(); 
        }
    }
}
