namespace Satış
{
    partial class anaSatisEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bekle = new System.Windows.Forms.Button();
            this.bsil = new System.Windows.Forms.Button();
            this.btemizle = new System.Windows.Forms.Button();
            this.btamamla = new System.Windows.Forms.Button();
            this.txtbarkodNo = new System.Windows.Forms.TextBox();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.dgvurun = new System.Windows.Forms.DataGridView();
            this.barkodNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokmiktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisfiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsatisfiyat = new System.Windows.Forms.TextBox();
            this.dgvsepet = new System.Windows.Forms.DataGridView();
            this.sırano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttoplam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvurun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsepet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(62, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miktar";
            // 
            // bekle
            // 
            this.bekle.Location = new System.Drawing.Point(62, 181);
            this.bekle.Name = "bekle";
            this.bekle.Size = new System.Drawing.Size(167, 60);
            this.bekle.TabIndex = 2;
            this.bekle.Text = "Ekle";
            this.bekle.UseVisualStyleBackColor = true;
            this.bekle.Click += new System.EventHandler(this.bekle_Click);
            // 
            // bsil
            // 
            this.bsil.Location = new System.Drawing.Point(255, 180);
            this.bsil.Name = "bsil";
            this.bsil.Size = new System.Drawing.Size(167, 63);
            this.bsil.TabIndex = 3;
            this.bsil.Text = "Sil";
            this.bsil.UseVisualStyleBackColor = true;
            this.bsil.Click += new System.EventHandler(this.bsil_Click);
            // 
            // btemizle
            // 
            this.btemizle.Location = new System.Drawing.Point(62, 247);
            this.btemizle.Name = "btemizle";
            this.btemizle.Size = new System.Drawing.Size(167, 59);
            this.btemizle.TabIndex = 4;
            this.btemizle.Text = "Temizle";
            this.btemizle.UseVisualStyleBackColor = true;
            this.btemizle.Click += new System.EventHandler(this.button3_Click);
            // 
            // btamamla
            // 
            this.btamamla.Location = new System.Drawing.Point(255, 248);
            this.btamamla.Name = "btamamla";
            this.btamamla.Size = new System.Drawing.Size(167, 58);
            this.btamamla.TabIndex = 5;
            this.btamamla.Text = "Tamamla";
            this.btamamla.UseVisualStyleBackColor = true;
            this.btamamla.Click += new System.EventHandler(this.btamamla_Click);
            // 
            // txtbarkodNo
            // 
            this.txtbarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbarkodNo.Location = new System.Drawing.Point(161, 26);
            this.txtbarkodNo.Name = "txtbarkodNo";
            this.txtbarkodNo.Size = new System.Drawing.Size(160, 28);
            this.txtbarkodNo.TabIndex = 6;
            this.txtbarkodNo.TextChanged += new System.EventHandler(this.txtbarkodNo_TextChanged);
            // 
            // txtmiktar
            // 
            this.txtmiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmiktar.Location = new System.Drawing.Point(161, 60);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(161, 28);
            this.txtmiktar.TabIndex = 7;
            this.txtmiktar.Text = "1";
            // 
            // dgvurun
            // 
            this.dgvurun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvurun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvurun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barkodNo,
            this.stokmiktari,
            this.satisfiyat});
            this.dgvurun.Location = new System.Drawing.Point(30, 343);
            this.dgvurun.Name = "dgvurun";
            this.dgvurun.RowHeadersWidth = 51;
            this.dgvurun.RowTemplate.Height = 24;
            this.dgvurun.Size = new System.Drawing.Size(403, 380);
            this.dgvurun.TabIndex = 9;
            this.dgvurun.DoubleClick += new System.EventHandler(this.dgvurun_DoubleClick);
            // 
            // barkodNo
            // 
            this.barkodNo.DataPropertyName = "barkodNo";
            this.barkodNo.HeaderText = "Barkod No";
            this.barkodNo.MinimumWidth = 6;
            this.barkodNo.Name = "barkodNo";
            // 
            // stokmiktari
            // 
            this.stokmiktari.DataPropertyName = "stokMiktari";
            this.stokmiktari.HeaderText = "Stok Miktarı";
            this.stokmiktari.MinimumWidth = 6;
            this.stokmiktari.Name = "stokmiktari";
            // 
            // satisfiyat
            // 
            this.satisfiyat.DataPropertyName = "satisFiyati";
            this.satisfiyat.HeaderText = "Satış Fiyatı";
            this.satisfiyat.MinimumWidth = 6;
            this.satisfiyat.Name = "satisfiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Satış Fiyatı";
            // 
            // txtsatisfiyat
            // 
            this.txtsatisfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsatisfiyat.Location = new System.Drawing.Point(160, 94);
            this.txtsatisfiyat.Name = "txtsatisfiyat";
            this.txtsatisfiyat.Size = new System.Drawing.Size(161, 28);
            this.txtsatisfiyat.TabIndex = 11;
            // 
            // dgvsepet
            // 
            this.dgvsepet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsepet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sırano,
            this.bno,
            this.ürünAdı,
            this.miktarr,
            this.satisFiyati});
            this.dgvsepet.Location = new System.Drawing.Point(546, 45);
            this.dgvsepet.Name = "dgvsepet";
            this.dgvsepet.RowHeadersWidth = 51;
            this.dgvsepet.RowTemplate.Height = 24;
            this.dgvsepet.Size = new System.Drawing.Size(758, 363);
            this.dgvsepet.TabIndex = 12;
            // 
            // sırano
            // 
            this.sırano.FillWeight = 21.39038F;
            this.sırano.HeaderText = "No";
            this.sırano.MinimumWidth = 6;
            this.sırano.Name = "sırano";
            // 
            // bno
            // 
            this.bno.DataPropertyName = "barkodNo";
            this.bno.FillWeight = 126.2032F;
            this.bno.HeaderText = "Barkod No";
            this.bno.MinimumWidth = 6;
            this.bno.Name = "bno";
            // 
            // ürünAdı
            // 
            this.ürünAdı.DataPropertyName = "urunAd";
            this.ürünAdı.HeaderText = "Ürün Adı";
            this.ürünAdı.MinimumWidth = 6;
            this.ürünAdı.Name = "ürünAdı";
            // 
            // miktarr
            // 
            this.miktarr.DataPropertyName = "miktar";
            this.miktarr.FillWeight = 126.2032F;
            this.miktarr.HeaderText = "Miktar";
            this.miktarr.MinimumWidth = 6;
            this.miktarr.Name = "miktarr";
            // 
            // satisFiyati
            // 
            this.satisFiyati.FillWeight = 126.2032F;
            this.satisFiyati.HeaderText = "Fiyat";
            this.satisFiyati.MinimumWidth = 6;
            this.satisFiyati.Name = "satisFiyati";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsatisfiyat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmiktar);
            this.groupBox1.Controls.Add(this.txtbarkodNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 155);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün";
            // 
            // txttoplam
            // 
            this.txttoplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttoplam.Location = new System.Drawing.Point(1159, 433);
            this.txttoplam.Name = "txttoplam";
            this.txttoplam.ReadOnly = true;
            this.txttoplam.Size = new System.Drawing.Size(145, 28);
            this.txttoplam.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1025, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Toplam Tutar";
            // 
            // ana_satis_ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 751);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttoplam);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvsepet);
            this.Controls.Add(this.dgvurun);
            this.Controls.Add(this.btamamla);
            this.Controls.Add(this.btemizle);
            this.Controls.Add(this.bsil);
            this.Controls.Add(this.bekle);
            this.Name = "ana_satis_ekrani";
            this.Text = "Ana Ekran";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvurun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsepet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bekle;
        private System.Windows.Forms.Button bsil;
        private System.Windows.Forms.Button btemizle;
        private System.Windows.Forms.Button btamamla;
        private System.Windows.Forms.TextBox txtbarkodNo;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.DataGridView dgvurun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsatisfiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokmiktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisfiyat;
        private System.Windows.Forms.DataGridView dgvsepet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttoplam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn sırano;
        private System.Windows.Forms.DataGridViewTextBoxColumn bno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarr;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisFiyati;
    }
}

