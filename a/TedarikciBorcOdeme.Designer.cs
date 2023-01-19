namespace a
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.txtttborc = new System.Windows.Forms.TextBox();
            this.txttodenecek = new System.Windows.Forms.TextBox();
            this.txttno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.biptal = new System.Windows.Forms.Button();
            this.btamam = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBorc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOdemeBilgileri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonara = new System.Windows.Forms.Button();
            this.buttonr = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtttborc
            // 
            this.txtttborc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtttborc.Location = new System.Drawing.Point(257, 123);
            this.txtttborc.Name = "txtttborc";
            this.txtttborc.ReadOnly = true;
            this.txtttborc.Size = new System.Drawing.Size(127, 28);
            this.txtttborc.TabIndex = 17;
            // 
            // txttodenecek
            // 
            this.txttodenecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttodenecek.Location = new System.Drawing.Point(257, 177);
            this.txttodenecek.Name = "txttodenecek";
            this.txttodenecek.Size = new System.Drawing.Size(127, 28);
            this.txttodenecek.TabIndex = 16;
            this.txttodenecek.TextChanged += new System.EventHandler(this.txttodenecek_TextChanged);
            // 
            // txttno
            // 
            this.txttno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttno.Location = new System.Drawing.Point(257, 77);
            this.txttno.Name = "txttno";
            this.txttno.Size = new System.Drawing.Size(127, 28);
            this.txttno.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Toplam Borç:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ödenecek Miktar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tedarikçi No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // biptal
            // 
            this.biptal.Location = new System.Drawing.Point(462, 166);
            this.biptal.Name = "biptal";
            this.biptal.Size = new System.Drawing.Size(127, 49);
            this.biptal.TabIndex = 11;
            this.biptal.Text = "İPTAL";
            this.biptal.UseVisualStyleBackColor = true;
            this.biptal.Click += new System.EventHandler(this.biptal_Click);
            // 
            // btamam
            // 
            this.btamam.Location = new System.Drawing.Point(462, 38);
            this.btamam.Name = "btamam";
            this.btamam.Size = new System.Drawing.Size(127, 49);
            this.btamam.TabIndex = 10;
            this.btamam.Text = "TAMAMLA";
            this.btamam.UseVisualStyleBackColor = true;
            this.btamam.Click += new System.EventHandler(this.btamam_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tNo,
            this.tBorc,
            this.tOdemeBilgileri});
            this.dataGridView3.Location = new System.Drawing.Point(12, 237);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(880, 247);
            this.dataGridView3.TabIndex = 18;
            this.dataGridView3.DoubleClick += new System.EventHandler(this.dataGridView3_DoubleClick);
            // 
            // tNo
            // 
            this.tNo.DataPropertyName = "tNo";
            this.tNo.HeaderText = "Tedarikçi No";
            this.tNo.MinimumWidth = 6;
            this.tNo.Name = "tNo";
            this.tNo.ReadOnly = true;
            // 
            // tBorc
            // 
            this.tBorc.DataPropertyName = "tBorc";
            this.tBorc.HeaderText = "Tedarikçi Borcu";
            this.tBorc.MinimumWidth = 6;
            this.tBorc.Name = "tBorc";
            this.tBorc.ReadOnly = true;
            // 
            // tOdemeBilgileri
            // 
            this.tOdemeBilgileri.DataPropertyName = "tOdemeBilgileri";
            this.tOdemeBilgileri.HeaderText = "ÖdemeBilgisi";
            this.tOdemeBilgileri.MinimumWidth = 6;
            this.tOdemeBilgileri.Name = "tOdemeBilgileri";
            this.tOdemeBilgileri.ReadOnly = true;
            // 
            // buttonara
            // 
            this.buttonara.Location = new System.Drawing.Point(462, 102);
            this.buttonara.Name = "buttonara";
            this.buttonara.Size = new System.Drawing.Size(127, 49);
            this.buttonara.TabIndex = 19;
            this.buttonara.Text = "ARA";
            this.buttonara.UseVisualStyleBackColor = true;
            this.buttonara.Click += new System.EventHandler(this.buttonara_Click);
            // 
            // buttonr
            // 
            this.buttonr.Location = new System.Drawing.Point(667, 166);
            this.buttonr.Name = "buttonr";
            this.buttonr.Size = new System.Drawing.Size(195, 49);
            this.buttonr.TabIndex = 21;
            this.buttonr.Text = "RAPOR";
            this.buttonr.UseVisualStyleBackColor = true;
            this.buttonr.Click += new System.EventHandler(this.buttonr_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "00:00";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "10-10-2023";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(257, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(127, 28);
            this.textBox1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(132, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ödeme No:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(641, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 487);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonr);
            this.Controls.Add(this.buttonara);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.txtttborc);
            this.Controls.Add(this.txttodenecek);
            this.Controls.Add(this.txttno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.biptal);
            this.Controls.Add(this.btamam);
            this.Name = "Form2";
            this.Text = "Tedarikçi Borç Ödeme Ekranı";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtttborc;
        private System.Windows.Forms.TextBox txttodenecek;
        private System.Windows.Forms.TextBox txttno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button biptal;
        private System.Windows.Forms.Button btamam;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tBorc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOdemeBilgileri;
        private System.Windows.Forms.Button buttonara;
        private System.Windows.Forms.Button buttonr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}