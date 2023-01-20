using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a
{
    public partial class Form1 : Form
    {
        musteri model = new musteri();
        public Form1()
        {
            InitializeComponent();
        }

        private void btamam_Click(object sender, EventArgs e)
        {
            Hesaplama();
            Clear();
            Loaddata();
        }

        private void biptal_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtmno.Text = txtodenecek.Text = txttborc.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            this.ActiveControl = txtmno;
            Loaddata();
        }

        private void txttborc_TextChanged(object sender, EventArgs e)
        {

        }

        void Loaddata()
        {
            dataGridView2.AutoGenerateColumns = false;
            using(mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                dataGridView2.DataSource = db.musteri.ToList<musteri>();
            }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView2.CurrentRow.Index != -1)
            {
                model.mNo = Convert.ToInt32(dataGridView2.CurrentRow.Cells["mNo"].Value);
                using(mahalleMarketiEntities db = new mahalleMarketiEntities())
                {
                    model = db.musteri.Where(x => x.mNo == model.mNo).FirstOrDefault();
                    txtmno.Text = model.mNo.ToString();
                    txttborc.Text = model.toplamBorc.ToString();
                }

            } 
        }

        void Hesaplama()
        {
            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                model = db.musteri.Where(x => x.mNo == model.mNo).FirstOrDefault();
                int a;
                a = Convert.ToInt32(txtodenecek.Text);
                model.toplamBorc -= a;
                model.toplamOdenen += a;
                db.SaveChanges();
            }
        }

    }
}
