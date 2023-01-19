namespace Satış
{
    partial class cari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txttoplamm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpbox1 = new System.Windows.Forms.GroupBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtmNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamsatış = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tborc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todenen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonayla = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcsNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bkapat = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.byenimüsteri = new System.Windows.Forms.Button();
            this.bYenile = new System.Windows.Forms.Button();
            this.grpbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttoplamm
            // 
            this.txttoplamm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttoplamm.Location = new System.Drawing.Point(166, 98);
            this.txttoplamm.Name = "txttoplamm";
            this.txttoplamm.Size = new System.Drawing.Size(147, 28);
            this.txttoplamm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cari Satış Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toplam Tutar";
            // 
            // grpbox1
            // 
            this.grpbox1.Controls.Add(this.txtSoyad);
            this.grpbox1.Controls.Add(this.txtAd);
            this.grpbox1.Controls.Add(this.txtmNo);
            this.grpbox1.Controls.Add(this.label5);
            this.grpbox1.Controls.Add(this.label4);
            this.grpbox1.Controls.Add(this.label3);
            this.grpbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbox1.Location = new System.Drawing.Point(125, 82);
            this.grpbox1.Name = "grpbox1";
            this.grpbox1.Size = new System.Drawing.Size(302, 189);
            this.grpbox1.TabIndex = 3;
            this.grpbox1.TabStop = false;
            this.grpbox1.Text = "Müşteri Bilgileri";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(130, 125);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(135, 28);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(130, 91);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(135, 28);
            this.txtAd.TabIndex = 4;
            // 
            // txtmNo
            // 
            this.txtmNo.Location = new System.Drawing.Point(130, 53);
            this.txtmNo.Name = "txtmNo";
            this.txtmNo.Size = new System.Drawing.Size(135, 28);
            this.txtmNo.TabIndex = 3;
            this.txtmNo.TextChanged += new System.EventHandler(this.txtmNo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = " No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mno,
            this.add,
            this.soyad,
            this.tel,
            this.toplamsatış,
            this.tborc,
            this.todenen});
            this.dataGridView1.Location = new System.Drawing.Point(76, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1070, 287);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // mno
            // 
            this.mno.DataPropertyName = "mNo";
            this.mno.HeaderText = "Müşteri No";
            this.mno.MinimumWidth = 6;
            this.mno.Name = "mno";
            // 
            // add
            // 
            this.add.DataPropertyName = "ad";
            this.add.HeaderText = "Ad";
            this.add.MinimumWidth = 6;
            this.add.Name = "add";
            // 
            // soyad
            // 
            this.soyad.DataPropertyName = "soyad";
            this.soyad.HeaderText = "Soyad";
            this.soyad.MinimumWidth = 6;
            this.soyad.Name = "soyad";
            // 
            // tel
            // 
            this.tel.DataPropertyName = "telno";
            this.tel.HeaderText = "Telefon";
            this.tel.MinimumWidth = 6;
            this.tel.Name = "tel";
            // 
            // toplamsatış
            // 
            this.toplamsatış.DataPropertyName = "toplamSatis";
            this.toplamsatış.HeaderText = "Toplam Satış";
            this.toplamsatış.MinimumWidth = 6;
            this.toplamsatış.Name = "toplamsatış";
            // 
            // tborc
            // 
            this.tborc.DataPropertyName = "toplamBorc";
            this.tborc.HeaderText = "Toplam Borç";
            this.tborc.MinimumWidth = 6;
            this.tborc.Name = "tborc";
            // 
            // todenen
            // 
            this.todenen.DataPropertyName = "toplamOdenen";
            this.todenen.HeaderText = "Toplam Ödenen";
            this.todenen.MinimumWidth = 6;
            this.todenen.Name = "todenen";
            // 
            // bonayla
            // 
            this.bonayla.Location = new System.Drawing.Point(844, 98);
            this.bonayla.Name = "bonayla";
            this.bonayla.Size = new System.Drawing.Size(173, 67);
            this.bonayla.TabIndex = 5;
            this.bonayla.Text = "Onayla";
            this.bonayla.UseVisualStyleBackColor = true;
            this.bonayla.Click += new System.EventHandler(this.bonayla_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcsNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txttoplamm);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(496, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 195);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Satış";
            // 
            // txtcsNo
            // 
            this.txtcsNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcsNo.Location = new System.Drawing.Point(166, 56);
            this.txtcsNo.Name = "txtcsNo";
            this.txtcsNo.Size = new System.Drawing.Size(147, 27);
            this.txtcsNo.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(62, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Satış No";
            // 
            // bkapat
            // 
            this.bkapat.Location = new System.Drawing.Point(844, 171);
            this.bkapat.Name = "bkapat";
            this.bkapat.Size = new System.Drawing.Size(173, 64);
            this.bkapat.TabIndex = 7;
            this.bkapat.Text = "Kapat";
            this.bkapat.UseVisualStyleBackColor = true;
            this.bkapat.Click += new System.EventHandler(this.bkapat_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(844, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 27);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // byenimüsteri
            // 
            this.byenimüsteri.Location = new System.Drawing.Point(1023, 98);
            this.byenimüsteri.Name = "byenimüsteri";
            this.byenimüsteri.Size = new System.Drawing.Size(162, 65);
            this.byenimüsteri.TabIndex = 9;
            this.byenimüsteri.Text = "Yeni Müşteri";
            this.byenimüsteri.UseVisualStyleBackColor = true;
            this.byenimüsteri.Click += new System.EventHandler(this.byenimüsteri_Click);
            // 
            // bYenile
            // 
            this.bYenile.Location = new System.Drawing.Point(1023, 168);
            this.bYenile.Name = "bYenile";
            this.bYenile.Size = new System.Drawing.Size(162, 67);
            this.bYenile.TabIndex = 10;
            this.bYenile.Text = "Yenile";
            this.bYenile.UseVisualStyleBackColor = true;
            this.bYenile.Click += new System.EventHandler(this.bYenile_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 625);
            this.Controls.Add(this.bYenile);
            this.Controls.Add(this.byenimüsteri);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bkapat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bonayla);
            this.Controls.Add(this.grpbox1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.grpbox1.ResumeLayout(false);
            this.grpbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpbox1;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtmNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bonayla;
        public System.Windows.Forms.TextBox txttoplamm;
        private System.Windows.Forms.DataGridViewTextBoxColumn mno;
        private System.Windows.Forms.DataGridViewTextBoxColumn add;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamsatış;
        private System.Windows.Forms.DataGridViewTextBoxColumn tborc;
        private System.Windows.Forms.DataGridViewTextBoxColumn todenen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcsNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bkapat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button byenimüsteri;
        private System.Windows.Forms.Button bYenile;
    }
}