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
using bizmar;



namespace a
{
    public partial class Form2 : Form
    {
        tedarikci model2 = new tedarikci();
        todeme model = new todeme();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Clear();
            this.ActiveControl = txttno;
            Loaddata();


            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                todeme sonsatis = db.todeme.ToList<todeme>().Last<todeme>();
                model.todemeNo = sonsatis.todemeNo + 1;
                textBox1.Text = (model.todemeNo).ToString();

            }
        }

        private void txtttborc_TextChanged(object sender, EventArgs e)
        {

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
            txttno.Text = txttodenecek.Text = txtttborc.Text = "";
        }


        void Loaddata()
        {
            dataGridView3.AutoGenerateColumns = false;
            using (mahalleMarketiEntities db2 = new mahalleMarketiEntities())
            {
                dataGridView3.DataSource = db2.tedarikci.ToList<tedarikci>();
            }
        }

        void Hesaplama()
        {
            using (mahalleMarketiEntities db2 = new mahalleMarketiEntities())
            {
                model2 = db2.tedarikci.Where(x => x.tNo == model2.tNo).FirstOrDefault();
                int b;
                b = Convert.ToInt32(txttodenecek.Text);
                model2.tBorc -= b;
                db2.SaveChanges();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow.Index != 1)
            {
                model2.tNo = Convert.ToInt32(dataGridView3.CurrentRow.Cells["tNo"].Value);
                using (mahalleMarketiEntities db = new mahalleMarketiEntities())
                {
                    model2 = db.tedarikci.Where(x => x.tNo == model2.tNo).FirstOrDefault();
                    txttno.Text = model2.tNo.ToString();
                    txtttborc.Text = model2.tBorc.ToString();
                }
            }
        }

        private void buttonara_Click(object sender, EventArgs e)
        {
            mahalleMarketiEntities db = new mahalleMarketiEntities();
            int tedarikci = Convert.ToInt32(txttno.Text);
            dataGridView3.DataSource = db.tedarikci.Where(x => x.tNo == (tedarikci)).ToList();
        }

        private void txttodenecek_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonr_Click(object sender, EventArgs e)
        {
            TedarikciBorcRaporEkrani frm5 = new TedarikciBorcRaporEkrani();
            frm5.txtno.Text = txttno.Text;
            frm5.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }


        void ode()
        {
            model.tNo = int.Parse(txttno.Text.Trim());
            model.odenenTutar = int.Parse(txttodenecek.Text.Trim());
            model.odenenTarih = dateTimePicker1.Value;
            model.todemeNo = int.Parse(textBox1.Text.Trim());
            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                db.todeme.Add(model);
                db.SaveChanges();
            }

        }

    }

}
