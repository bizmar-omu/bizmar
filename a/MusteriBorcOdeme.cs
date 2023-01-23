using Microsoft.Office.Interop.Excel;
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
    public partial class MusteriBorcOdeme : Form
    {
        musteri model = new musteri();
        odeme model2 = new odeme();

        public MusteriBorcOdeme()
        {
            InitializeComponent();
        }

        private void btamam_Click(object sender, EventArgs e)
        {
            Hesaplama();
            ode();
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

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Clear();
            this.ActiveControl = txtmno;
            Loaddata();
           
            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                odeme sonsatis = db.odeme.ToList<odeme>().Last<odeme>();
                model2.odemeNo = sonsatis.odemeNo + 1;
                textBox1.Text = (model2.odemeNo).ToString();
            }
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

        void ode()
        {
            model2.mNo = int.Parse(txtmno.Text.Trim());
            model2.odemeTutari = int.Parse(txtodenecek.Text.Trim());
            model2.odemeTarihi = dateTimePicker1.Value;
            model2.odemeNo = int.Parse(textBox1.Text.Trim());
            using(mahalleMarketiEntities db = new mahalleMarketiEntities())
            {    
                db.odeme.Add(model2);
                db.SaveChanges();
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

        private void buttonara2_Click(object sender, EventArgs e)
        {
            mahalleMarketiEntities db = new mahalleMarketiEntities();
            int musteri = Convert.ToInt32(txtmno.Text);
            dataGridView2.DataSource = db.musteri.Where(x => x.mNo == (musteri)).ToList();
        }

        private void brapor_Click(object sender, EventArgs e)
        {
            MusteriBorcRaporEkrani frm4 = new MusteriBorcRaporEkrani();
            frm4.txtno.Text = txtmno.Text;
            frm4.Show();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;

            for (int i = 1; i < dataGridView2.Columns.Count + 1; i++)
            {
                ws.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < (dataGridView2.Rows.Count); i++)
            {
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    ws.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                }
            }
        }
    }
}
