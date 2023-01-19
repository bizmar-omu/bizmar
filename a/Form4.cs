using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace a
{
    public partial class Form4 : Form
    {
        odeme model = new odeme();
        musteri model2 = new musteri();

        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadData();
            timer1.Start();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;

            for(int i = 1; i <dataGridView1.Columns.Count + 1; i++)
            {
                ws.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < (dataGridView1.Rows.Count); i++)
                {
                   for (int j = 0; j < dataGridView1.Columns.Count ; j++)
                  {
                      ws.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                  }
             }









        }

        void LoadData()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                dataGridView1.DataSource = db.odeme.ToList<odeme>();
                int odeme = Convert.ToInt32(txtno.Text);
                dataGridView1.DataSource = db.odeme.Where(x => x.mNo == (odeme)).ToList();

            }


        }

        private void txtno_TextChanged(object sender, EventArgs e)
        { 
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    
}
