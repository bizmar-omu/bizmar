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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace a
{
    public partial class Form5 : Form
    {
        todeme model = new todeme();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            timer1.Start();
            LoadData();
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

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                ws.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }


            for (int i = 0; i < (dataGridView1.Rows.Count)  ; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        ws.Cells[i + 2 , j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }

        private void txtno_TextChanged(object sender, EventArgs e)
        {

        }
  
        void LoadData()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                dataGridView1.DataSource = db.todeme.ToList<todeme>();
                int todeme = Convert.ToInt32(txtno.Text);
                dataGridView1.DataSource = db.todeme.Where(x => x.tNo == (todeme)).ToList();

            }

        }

    }

}
