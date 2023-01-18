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
    public partial class Form2 : Form
    {
        tedarikci model2 = new tedarikci();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Clear();
            this.ActiveControl = txttno;
            Loaddata();

        }


        private void txtttborc_TextChanged(object sender, EventArgs e)
        {

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
    }

}
