namespace a
{
    partial class MusteriBorcOdeme
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
            this.components = new System.ComponentModel.Container();
            this.btamam = new System.Windows.Forms.Button();
            this.biptal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmno = new System.Windows.Forms.TextBox();
            this.txtodenecek = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamSatis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamBorc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamOdenen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttborc = new System.Windows.Forms.TextBox();
            this.buttonara2 = new System.Windows.Forms.Button();
            this.brapor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btamam
            // 
            this.btamam.Location = new System.Drawing.Point(524, 62);
            this.btamam.Name = "btamam";
            this.btamam.Size = new System.Drawing.Size(127, 56);
            this.btamam.TabIndex = 0;
            this.btamam.Text = "TAMAMLA";
            this.btamam.UseVisualStyleBackColor = true;
            this.btamam.Click += new System.EventHandler(this.btamam_Click);
            // 
            // biptal
            // 
            this.biptal.Location = new System.Drawing.Point(524, 144);
            this.biptal.Name = "biptal";
            this.biptal.Size = new System.Drawing.Size(127, 59);
            this.biptal.TabIndex = 1;
            this.biptal.Text = "İPTAL";
            this.biptal.UseVisualStyleBackColor = true;
            this.biptal.Click += new System.EventHandler(this.biptal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Müşteri No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ödenecek Miktar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Toplam Borç:";
            // 
            // txtmno
            // 
            this.txtmno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmno.Location = new System.Drawing.Point(319, 77);
            this.txtmno.Name = "txtmno";
            this.txtmno.Size = new System.Drawing.Size(127, 28);
            this.txtmno.TabIndex = 5;
            // 
            // txtodenecek
            // 
            this.txtodenecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtodenecek.Location = new System.Drawing.Point(319, 175);
            this.txtodenecek.Name = "txtodenecek";
            this.txtodenecek.Size = new System.Drawing.Size(127, 28);
            this.txtodenecek.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mNo,
            this.ad,
            this.soyad,
            this.telno,
            this.toplamSatis,
            this.toplamBorc,
            this.toplamOdenen});
            this.dataGridView2.Location = new System.Drawing.Point(3, 265);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1112, 271);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.DoubleClick += new System.EventHandler(this.dataGridView2_DoubleClick);
            // 
            // mNo
            // 
            this.mNo.DataPropertyName = "mNo";
            this.mNo.HeaderText = "Müşteri No";
            this.mNo.MinimumWidth = 6;
            this.mNo.Name = "mNo";
            this.mNo.ReadOnly = true;
            // 
            // ad
            // 
            this.ad.DataPropertyName = "ad";
            this.ad.HeaderText = "Müşteri Adı";
            this.ad.MinimumWidth = 6;
            this.ad.Name = "ad";
            this.ad.ReadOnly = true;
            // 
            // soyad
            // 
            this.soyad.DataPropertyName = "soyad";
            this.soyad.HeaderText = "Müşteri Soyadı";
            this.soyad.MinimumWidth = 6;
            this.soyad.Name = "soyad";
            this.soyad.ReadOnly = true;
            // 
            // telno
            // 
            this.telno.DataPropertyName = "telno";
            this.telno.HeaderText = "Telefon";
            this.telno.MinimumWidth = 6;
            this.telno.Name = "telno";
            this.telno.ReadOnly = true;
            // 
            // toplamSatis
            // 
            this.toplamSatis.DataPropertyName = "toplamSatis";
            this.toplamSatis.HeaderText = "Toplam Satış";
            this.toplamSatis.MinimumWidth = 6;
            this.toplamSatis.Name = "toplamSatis";
            this.toplamSatis.ReadOnly = true;
            // 
            // toplamBorc
            // 
            this.toplamBorc.DataPropertyName = "toplamBorc";
            this.toplamBorc.HeaderText = "Toplam Borç";
            this.toplamBorc.MinimumWidth = 6;
            this.toplamBorc.Name = "toplamBorc";
            this.toplamBorc.ReadOnly = true;
            // 
            // toplamOdenen
            // 
            this.toplamOdenen.DataPropertyName = "toplamOdenen";
            this.toplamOdenen.HeaderText = "Toplam Ödenen";
            this.toplamOdenen.MinimumWidth = 6;
            this.toplamOdenen.Name = "toplamOdenen";
            this.toplamOdenen.ReadOnly = true;
            // 
            // txttborc
            // 
            this.txttborc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttborc.Location = new System.Drawing.Point(319, 126);
            this.txttborc.Name = "txttborc";
            this.txttborc.ReadOnly = true;
            this.txttborc.Size = new System.Drawing.Size(127, 28);
            this.txttborc.TabIndex = 9;
            this.txttborc.TextChanged += new System.EventHandler(this.txttborc_TextChanged);
            // 
            // buttonara2
            // 
            this.buttonara2.Location = new System.Drawing.Point(678, 62);
            this.buttonara2.Name = "buttonara2";
            this.buttonara2.Size = new System.Drawing.Size(127, 53);
            this.buttonara2.TabIndex = 10;
            this.buttonara2.Text = "ARA";
            this.buttonara2.UseVisualStyleBackColor = true;
            this.buttonara2.Click += new System.EventHandler(this.buttonara2_Click);
            // 
            // brapor
            // 
            this.brapor.Location = new System.Drawing.Point(678, 144);
            this.brapor.Name = "brapor";
            this.brapor.Size = new System.Drawing.Size(127, 59);
            this.brapor.TabIndex = 11;
            this.brapor.Text = "RAPOR";
            this.brapor.UseVisualStyleBackColor = true;
            this.brapor.Click += new System.EventHandler(this.brapor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(875, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "00:00";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(875, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "10-10-2023";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(878, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ödeme No:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(319, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(127, 28);
            this.textBox1.TabIndex = 16;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 533);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.brapor);
            this.Controls.Add(this.buttonara2);
            this.Controls.Add(this.txttborc);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtodenecek);
            this.Controls.Add(this.txtmno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.biptal);
            this.Controls.Add(this.btamam);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Borç Ödeme Ekranı";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btamam;
        private System.Windows.Forms.Button biptal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmno;
        private System.Windows.Forms.TextBox txtodenecek;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txttborc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn telno;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamSatis;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamBorc;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamOdenen;
        private System.Windows.Forms.Button buttonara2;
        private System.Windows.Forms.Button brapor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

