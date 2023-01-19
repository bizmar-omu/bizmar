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

       
        public pesin()
        {
            InitializeComponent();
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
            psatis.ulNo = 0;

            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {          
                db.pesinSatis.Add(psatis);
                db.SaveChanges();
            }
            this.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                pesinSatis sonSatis = db.pesinSatis.ToList<pesinSatis>().Last<pesinSatis>();
                psatis.psNo = sonSatis.psNo + 1;
                txtpsNo.Text = (psatis.psNo).ToString();
            }


        }


    }
}
