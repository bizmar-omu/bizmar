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

namespace bizmar
{
    public partial class girissayfasi : Form
    {
        market marketSahibi;
        public girissayfasi()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            using(mahalleMarketiEntities db = new mahalleMarketiEntities())
            {
                String girilenKulAdi = txtKulAdi.Text;
                String girilenSifre = txtSifre.Text;

                marketSahibi = db.market.FirstOrDefault(x => x.kullaniciAdi == girilenKulAdi && x.sifre == girilenSifre);

                bool kayitVarmi = marketSahibi != null;

                if (kayitVarmi)
                {
                    AnaSayfa asa = new AnaSayfa();
                    asa.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Kayıt bulunamadı");
                }
            }
        }

        private void girissayfasi_Load(object sender, EventArgs e)
        {

        }
    }
}
