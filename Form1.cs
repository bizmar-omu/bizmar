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
using System.IO;

namespace bizmar
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (EFDBEntities db = new EFDBEntities())
            {
                dataGridViewİrsaliye.AutoGenerateColumns = false;
                dataGridViewİrsaliye.DataSource = db.urun.ToList<urun>();
            }
                
        }

        private void dataGridViewİrsaliye_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //dosya seç işlemi
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                List<string> lines = File.ReadAllLines(path).ToList();
                foreach (string line in lines)
                {
                    richTextBox1.Text += String.Format("{0}\n", line);            
                }
               
            }


        }

        //stoğa ekle işlemi
        private void button1_Click(object sender, EventArgs e)
        {
            using (EFDBEntities db = new EFDBEntities())
            {

                string[] lines = richTextBox1.Text.Split('\n');
               
                for(int i = 0; i < lines.Length - 1; i++) 
                {
                    string line = lines[i];
                    string[] array = line.Split(',');


                    urun product = new urun();
                   try
                    {
                        product.urunKodu = int.Parse(array[0]);
                        product.urunAd = array[1];
                        product.barkodNo = array[2];
                        product.stokMiktari = int.Parse(array[3]);
                        product.satisFiyati = int.Parse(array[4]);
                    } catch
                    {
                        MessageBox.Show(line);
                    }

                    db.urun.Add(product);

                }
                richTextBox1.Clear();
                db.SaveChanges();
                dataGridViewİrsaliye.DataSource = db.urun.ToList<urun>();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
