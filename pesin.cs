using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satış
{
    public partial class pesin : Form
    {


        pesinSatis psatis = new pesinSatis();
        public DataGridViewRowCollection urunler;

       
        public pesin(DataGridViewRowCollection urunler)
        {
            InitializeComponent();
            this.urunler = urunler;
        }

        List<pesinSatisUrunu> parseDataGridView(int psNo)
        {
            List<pesinSatisUrunu> temp1 = new List<pesinSatisUrunu>();

           foreach(DataGridViewRow urun in urunler)
            {
                pesinSatisUrunu temp2 = new pesinSatisUrunu();

                temp2.psuNo = Convert.ToInt32(urun.Cells[0].Value);
                temp2.psuBarkodNo = Convert.ToString(urun.Cells[1].Value);
                temp2.psuAd = Convert.ToString(urun.Cells[2].Value);
                temp2.psuMiktar = Convert.ToInt32(urun.Cells[3].Value);
                temp2.psuFiyat = Convert.ToDouble(urun.Cells[4].Value);
                temp2.psNo = psNo;

                temp1.Add(temp2);
            }

            return temp1;
        }
        
        void kaydet()
        {
                psatis.psNo = int.Parse(txtpsNo.Text.Trim());
                psatis.psTutar = int.Parse(txttoplamtutar3.Text.Trim());
                psatis.psTarih = dateTimePicker1.Value;           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            txtparaüstü.Text = (Convert.ToInt32(txtodenen.Text) - (Convert.ToInt32(txttoplamtutar3.Text))).ToString();

        }

        private void btamamla_Click(object sender, EventArgs e)
        {
            psatis.psNo = int.Parse(txtpsNo.Text.Trim());
            psatis.psTutar = int.Parse(txttoplamtutar3.Text.Trim());
            psatis.psTarih = dateTimePicker1.Value;

            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                List<pesinSatisUrunu> urunler = parseDataGridView(psatis.psNo);

                foreach (pesinSatisUrunu psu in urunler)
                {
                    if (psu.psuAd != "")
                        db.pesinSatisUrunu.Add(psu);
                }

                db.pesinSatis.Add(psatis);
                db.SaveChanges();
            }
            this.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                pesinSatis sonSatis = db.pesinSatis.ToList<pesinSatis>().LastOrDefault<pesinSatis>();
                psatis.psNo = sonSatis != null ? sonSatis.psNo + 1 : 0;
                txtpsNo.Text = (psatis.psNo).ToString();
            }


        }


    }
}
