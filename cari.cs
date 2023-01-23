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
    
    public partial class cari : Form
    {
        musteri model = new musteri();
        cariSatis cSatis= new cariSatis();

        public DataGridViewRowCollection urunler;

        public cari(DataGridViewRowCollection urunler)
        {
            InitializeComponent();
            this.urunler = urunler;
        }

        List<cariSatisUrunu> parseDataGridView(int csNo)
        {
            List<cariSatisUrunu> temp1 = new List<cariSatisUrunu>();

            int soncsuNo;

            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                cariSatisUrunu sonUrun = db.cariSatisUrunu.ToList<cariSatisUrunu>().LastOrDefault<cariSatisUrunu>();
                soncsuNo = sonUrun != null ? sonUrun.csuNo + 1 : 0;
            }

            foreach (DataGridViewRow urun in urunler)
            {
                cariSatisUrunu temp2 = new cariSatisUrunu();

                temp2.csuNo = soncsuNo++;
                temp2.csuBarkodNo = Convert.ToString(urun.Cells[1].Value);
                temp2.csuAd = Convert.ToString(urun.Cells[2].Value);
                temp2.csuMiktar = Convert.ToInt32(urun.Cells[3].Value);
                temp2.csuFiyat = Convert.ToDouble(urun.Cells[4].Value);
                temp2.csNo = csNo;

                temp1.Add(temp2);
            }

            return temp1;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                cariSatis sonSatis = db.cariSatis.ToList<cariSatis>().LastOrDefault<cariSatis>();
                cSatis.csNo = sonSatis != null ? sonSatis.csNo + 1 : 0;
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

            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                List<cariSatisUrunu> urunler = parseDataGridView(cSatis.csNo);
               
                foreach(cariSatisUrunu csu in urunler)
                {
                    if(csu.csuAd != "")
                        db.cariSatisUrunu.Add(csu);
                }

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
            musteriKayit form5= new musteriKayit();
            form5.Show();
        }

        private void bYenile_Click(object sender, EventArgs e)
        {
            LoadData(); 
        }
    }
}
