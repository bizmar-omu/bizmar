using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satış
{
    public partial class anaSatisEkrani : Form
    {
        urun model2 = new urun();
        mahalleMarketiEntities db = new mahalleMarketiEntities();

        void Clear()
        {
            txtbarkodNo.Text = txtsatisfiyat.Text = txtmiktar.Text ="";
            bekle.Text = "Ekle";

        }
        public anaSatisEkrani()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Clear();
            txtmiktar.Text = "1";
            LoadData();
        }

        private void bekle_Click(object sender, EventArgs e)
        {
          
           txtbarkodNo.Select(); 
           sepeteekle();
           miktarazalat();
           Clear();
           txtmiktar.Text = "1";
           txtbarkodNo.Select();
           LoadData(); 
           tutarhesapla();
        }

        int n = 0;
        void sepeteekle()
        {
           
            int total = (Convert.ToInt32(txtsatisfiyat.Text)) * (Convert.ToInt32(txtmiktar.Text));
            int grdtotal = 0;

            DataGridViewRow newRow = new DataGridViewRow();

            newRow.CreateCells(dgvsepet);

            newRow.Cells[0].Value = ++n;
            newRow.Cells[1].Value = txtbarkodNo.Text;
            newRow.Cells[2].Value = model2.urunAd;
            newRow.Cells[3].Value = txtmiktar.Text;
            newRow.Cells[4].Value = (Convert.ToInt32(txtsatisfiyat.Text)) * (Convert.ToInt32(txtmiktar.Text));

            dgvsepet.Rows.Add(newRow);
            grdtotal = grdtotal + total;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtbarkodNo.Select();
            LoadData();
        }

        private void btamamla_Click(object sender, EventArgs e)
        {
            tutarhesapla();
            satisTuru frm2= new satisTuru();
            frm2.txttoplamtutar.Text= txttoplam.Text;
            frm2.urunler = dgvsepet.Rows;
            frm2.Show();

        }

        void LoadData()
        {
            dgvurun.AutoGenerateColumns=false;
            using(mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                dgvurun.DataSource = db.urun.ToList<urun>();
            }
        }

        private void dgvurun_DoubleClick(object sender, EventArgs e)
        {
            if (dgvurun.CurrentRow.Index != 1)
            {
                model2.barkodNo = (dgvurun.CurrentRow.Cells["barkodNo"].Value).ToString();
                using (mahalleMarketiEntities db2 = new mahalleMarketiEntities())
                {
                    model2 = db2.urun.Where(x => x.barkodNo == (model2.barkodNo)).FirstOrDefault();
                    txtbarkodNo.Text = model2.barkodNo;
                    txtsatisfiyat.Text = model2.satisFiyati.ToString();
                }
            }
        }

        private void txtbarkodNo_TextChanged(object sender, EventArgs e)
        {
            mahalleMarketiEntities db = new mahalleMarketiEntities();
            string urun = txtbarkodNo.Text;
            dgvurun.DataSource = db.urun.Where(x => x.barkodNo == (urun)).ToList();

        }

        public  void tutarhesapla()
        {
            int toplam = 0; 
            for (int i = 0; i < dgvsepet.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dgvsepet.Rows[i].Cells[4].Value);
            }
            txttoplam.Text =toplam.ToString();
        }

        void sayaciArttir()
        {
            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                sayac urunSayaci = db.sayac.Where(x => x.urunKodu == model2.urunKodu).FirstOrDefault();
                
                if(urunSayaci == null)
                {
                    sayac sonSayac = db.sayac.ToList<sayac>().LastOrDefault<sayac>();
                    int sonSayacNo = sonSayac != null ? sonSayac.sayacNo + 1 : 0;

                    urunSayaci = new sayac();
                    urunSayaci.sayacNo = sonSayacNo;
                    urunSayaci.urunKodu = model2.urunKodu;
                    urunSayaci.urunSayaci = 0;

                    db.sayac.Add(urunSayaci);
                }

                int urunMevcutSayaci = urunSayaci.urunSayaci;
                int satilanMiktar = Convert.ToInt32(txtmiktar.Text);
                urunSayaci.urunSayaci = urunMevcutSayaci + satilanMiktar;

                db.SaveChanges();
            }
        }

        void sayaciAzalt()
        {
            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                sayac urunSayaci = db.sayac.Where(x => x.urunKodu == model2.urunKodu).FirstOrDefault();
                int urunMevcutSayaci = urunSayaci.urunSayaci;
                int satilanMiktar = Convert.ToInt32(txtmiktar.Text);
                urunSayaci.urunSayaci = urunMevcutSayaci - satilanMiktar;

                db.SaveChanges();
            }
        }
        
        void miktarazalat()
        {
            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                model2 = db.urun.Where(x => x.barkodNo == model2.barkodNo).FirstOrDefault();
                int a;
                a = Convert.ToInt32(txtmiktar.Text);
                model2.stokMiktari -= a;               
                db.SaveChanges();
                if (model2.stokMiktari < 10)
                {
                    MessageBox.Show("Bu urunden 10 adetten az kalmistir.");
                }
            }

            sayaciArttir();
        }

        void miktararttır()
        {
            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                model2 = db.urun.Where(x => x.barkodNo == model2.barkodNo).FirstOrDefault();
                int a;
                a = Convert.ToInt32(txtmiktar.Text);
                model2.stokMiktari += a;
                db.SaveChanges();

            }

            sayaciAzalt();

        }

        private void bsil_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgvsepet.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                dgvsepet.Rows.RemoveAt(selectedIndex);
                dgvsepet.Refresh();
            }
            DataGridViewRow newRow = new DataGridViewRow();

            newRow.CreateCells(dgvsepet);

            newRow.Cells[0].Value = --n;
           
            miktararttır();
            db.SaveChanges();
            LoadData();
        }

    }
}
