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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtttborc
            // 
            this.txtttborc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtttborc.Location = new System.Drawing.Point(257, 84);
            this.txtttborc.Name = "txtttborc";
            this.txtttborc.ReadOnly = true;
            this.txtttborc.Size = new System.Drawing.Size(127, 28);
            this.txtttborc.TabIndex = 17;
            // 
            // txttodenecek
            // 
            this.txttodenecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttodenecek.Location = new System.Drawing.Point(257, 135);
            this.txttodenecek.Name = "txttodenecek";
            this.txttodenecek.Size = new System.Drawing.Size(127, 28);
            this.txttodenecek.TabIndex = 16;
            // 
            // txttno
            // 
            this.txttno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttno.Location = new System.Drawing.Point(257, 35);
            this.txttno.Name = "txttno";
            this.txttno.Size = new System.Drawing.Size(127, 28);
            this.txttno.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Toplam Borç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ödenecek Miktar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tedarikçi No";
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 512);
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
    }
}