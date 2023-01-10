using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bizmar.models;

namespace bizmar
{
    public partial class Form1 : Form
    {
        market marketSahibi;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            using(EFDBEntities db = new EFDBEntities())
            {
                String girilenKulAdi = txtKulAdi.Text;
                String girilenSifre = txtSifre.Text;

                marketSahibi = db.market.FirstOrDefault(x => x.kullaniciAdi == girilenKulAdi && x.sifre == girilenSifre);

                bool kayitVarmi = marketSahibi != null;

                if (kayitVarmi)
                {
                    MessageBox.Show(marketSahibi.kullaniciAdi);
                    MessageBox.Show(marketSahibi.sifre);
                } else
                {
                    MessageBox.Show("Kayıt bulunamadı");
                }
            }
        }
    }
}
