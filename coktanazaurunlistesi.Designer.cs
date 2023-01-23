namespace WindowsFormsApp1
{
    partial class coktanazaurunlistesi
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
            this.dgvUrunListesi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.urunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunSayaci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUrunListesi
            // 
            this.dgvUrunListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunKodu,
            this.urunAd,
            this.urunSayaci});
            this.dgvUrunListesi.Location = new System.Drawing.Point(56, 101);
            this.dgvUrunListesi.Name = "dgvUrunListesi";
            this.dgvUrunListesi.Size = new System.Drawing.Size(630, 271);
            this.dgvUrunListesi.TabIndex = 0;
            this.dgvUrunListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunListesi_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(157, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Çok Satılandan Az Satılana Ürün Listesi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // urunKodu
            // 
            this.urunKodu.DataPropertyName = "urunKodu";
            this.urunKodu.HeaderText = "Ürün Kodu";
            this.urunKodu.Name = "urunKodu";
            // 
            // urunAd
            // 
            this.urunAd.DataPropertyName = "urunAd";
            this.urunAd.HeaderText = "Ürün Adı";
            this.urunAd.Name = "urunAd";
            // 
            // urunSayaci
            // 
            this.urunSayaci.DataPropertyName = "urunSayaci";
            this.urunSayaci.HeaderText = "Ürün Sayacı";
            this.urunSayaci.Name = "urunSayaci";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUrunListesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUrunListesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunSayaci;
    }
}

