using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bizmar
{

    public partial class Form1 : Form
    {
        urun model = new urun();
        public Form1()
        {
            InitializeComponent();
        }

        private void bttemizle_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            txtBarkod.Text = txturunKod.Text = txtsatis.Text = txtStok.Text = txtirsaliye.Text = "";
            btekle.Text = "Ekle";
            btsil.Enabled = false;
            model.urunKodu = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clear();
            LoadData(); 

        }

        private void btekle_Click(object sender, EventArgs e)
        {
            model.urunKodu = int.Parse(txturunKod.Text.Trim());
            model.barkodNo = txtBarkod.Text.Trim();
            model.stokMiktari = int.Parse(txtStok.Text.Trim());
            model.satisFiyati = int.Parse(txtsatis.Text.Trim());
            model.irsaliyeNo = int.Parse(txtirsaliye.Text.Trim());
            using(mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                if(model.urunKodu == 0)
                    db.urun.Add(model);
                    
                else
                    db.Entry(model).State =  System.Data.Entity.EntityState.Modified;

                db.SaveChanges();
            }
            clear();
            LoadData();
            MessageBox.Show("İşlem tamamlandı");
        }

        void LoadData()
        {
            dgv.AutoGenerateColumns = false;
            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                dgv.DataSource = db.urun.ToList<urun>();

            }
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            if(dgv.CurrentRow.Index != 1)
            {
                model.urunKodu = Convert.ToInt32(dgv.CurrentRow.Cells["urunKodu"].Value);
                using (mahalleMarketiEntities db = new mahalleMarketiEntities())
                {
                    model = db.urun.Where(x => x.urunKodu == model.urunKodu).FirstOrDefault();
                    txturunKod.Text = model.urunKodu.ToString();
                    txtBarkod.Text = model.barkodNo;
                    txtStok.Text = model.stokMiktari.ToString();
                    txtsatis.Text = model.satisFiyati.ToString();
                    txtirsaliye.Text = model.irsaliyeNo.ToString(); 

                }

                btekle.Text = "GÜNCELLE";
                btsil.Enabled = true;
            }
        }

        private void btsil_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Kaydı silmek istediğinize emin misiniz","Message",MessageBoxButtons.YesNo) == DialogResult.Yes) {
                using (mahalleMarketiEntities db = new mahalleMarketiEntities())
                {
                    var entry = db.Entry(model);
                    if(entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.urun.Attach(model);
                        db.urun.Remove(model);  
                        db.SaveChanges();
                        LoadData();
                        clear();                      
                        MessageBox.Show("Silme islemi basarili sekilde tamamlandi");
                    }
                }
            }
        }

        private void bbul_Click(object sender, EventArgs e)
        {
           mahalleMarketiEntities db = new mahalleMarketiEntities();
           int urun = Convert.ToInt32(txturunKod.Text);   
           dgv.DataSource = db.urun.Where(x => x.urunKodu == (urun)).ToList(); 
        }
    }
}
