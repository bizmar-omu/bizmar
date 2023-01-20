using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bizmar
{
    public partial class ikitarihgrafik : Form
    {
        public ikitarihgrafik()
        {
            InitializeComponent();
        }

        void grafigeYansit()
        {
            using (mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                chart1.Series.Clear();

                DateTime baslangicTarihi = Convert.ToDateTime(dtpBaslangic.Text);
                DateTime bitisTarihi = Convert.ToDateTime(dtpBitis.Text);

                // Cari Satış
                ArrayList cari_xvalues = new ArrayList();
                ArrayList cari_yvalues = new ArrayList();

                var siralanmisCS = db.cariSatis
                    .OrderBy(x => x.csTarih)
                    .Where(x => x.csTarih >= baslangicTarihi && x.csTarih <= bitisTarihi)
                    .ToList();

                siralanmisCS.ForEach(x => cari_xvalues.Add(x.csTarih));
                siralanmisCS.ForEach(x => cari_yvalues.Add(x.csTutar));

                chart1.Series.Add("cariSatis");
                chart1.Series["cariSatis"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;

                for (int i = 0; i < cari_xvalues.ToArray().Length; i++)
                {
                    String cari_xvalue = Convert.ToString(cari_xvalues[i]);
                    String cari_yvalue = Convert.ToString(cari_yvalues[i]);

                    chart1.Series["cariSatis"].Points.AddXY(cari_xvalue, cari_yvalue);
                }

                chart1.Series["cariSatis"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series["cariSatis"].BorderWidth = 3;
                chart1.ChartAreas[0].AxisX.Interval = 1;

                // Peşin Satış
                ArrayList pesin_xvalues = new ArrayList();
                ArrayList pesin_yvalues = new ArrayList();

                var siralanmisPS = db.pesinSatis
                   .OrderBy(x => x.psTarih)
                   .Where(x => x.psTarih >= baslangicTarihi && x.psTarih <= bitisTarihi)
                   .ToList();

                siralanmisPS.ForEach(x => pesin_xvalues.Add(x.psTarih));
                siralanmisPS.ForEach(x => pesin_yvalues.Add(x.psTutar));

                chart1.Series.Add("pesinSatis");
                chart1.Series["pesinSatis"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;

                for (int i = 0; i < pesin_xvalues.ToArray().Length; i++)
                {
                    String pesin_xvalue = Convert.ToString(pesin_xvalues[i]);
                    String pesin_yvalue = Convert.ToString(pesin_yvalues[i]);

                    chart1.Series["pesinSatis"].Points.AddXY(pesin_xvalue, pesin_yvalue);
                }

                chart1.Series["pesinSatis"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series["pesinSatis"].BorderWidth = 3;
                chart1.ChartAreas[0].AxisX.Interval = 1;

                chart1.ChartAreas[0].AxisX.Title = "Tarih";
                chart1.ChartAreas[0].AxisY.Title = "Satış Tutarı";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grafigeYansit();
        }

        private void btnYansit_Click(object sender, EventArgs e)
        {
            grafigeYansit();
        }
    }
}
