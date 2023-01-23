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

namespace kar_zarar_rapor
{
    public partial class Karzarar : Form
    {
        pesinSatis psatis = new pesinSatis();   
        cariSatis cariSatis= new cariSatis();
        irsaliye irs = new irsaliye();

        int ptoplam = 0;
        int ctoplam = 0;
        int itoplam = 0;

        public Karzarar()
        {
            InitializeComponent();
        }
        void psgetir()
        {
            dgvpesinsatis.AutoGenerateColumns = false;
            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                dgvpesinsatis.DataSource = db.pesinSatis.ToList<pesinSatis>();
            }
        }
        void csgetir()
        {
            dgvcarisatis.AutoGenerateColumns = false;
            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                dgvcarisatis.DataSource = db.cariSatis.ToList<cariSatis>();
            }
        }

        void irsgetir()
        {
            dgvirsaliye.AutoGenerateColumns = false;
            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                dgvirsaliye.DataSource = db.irsaliye.ToList<irsaliye>();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            psgetir(); 
            csgetir(); 
            irsgetir();
            ptutarhesapla();
            ctutarhesapla();
            itutarhesapla();

            txtciro.Text = ((ptoplam + ctoplam) - itoplam).ToString();
        }

        private void dgvpesinsatis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ptutarhesapla()
        {
            
            for (int i = 0; i <dgvpesinsatis.Rows.Count; ++i)
            {
                ptoplam += Convert.ToInt32(dgvpesinsatis.Rows[i].Cells[1].Value);
            }
            txtpsno.Text = ptoplam.ToString();
        }

        public void ctutarhesapla()
        {

            for (int i = 0; i < dgvcarisatis.Rows.Count; ++i)
            {
                ctoplam += Convert.ToInt32(dgvcarisatis.Rows[i].Cells[1].Value);
            }
           txtcsstoplam.Text = ctoplam.ToString();
        }

        public void itutarhesapla()
        {

            for (int i = 0; i < dgvirsaliye.Rows.Count; ++i)
            {
                itoplam += Convert.ToInt32(dgvirsaliye.Rows[i].Cells[1].Value);
            }
            txtirsaliyetoplam.Text = itoplam.ToString();

        }

    }
}
