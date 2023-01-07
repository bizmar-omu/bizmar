
namespace bizmar
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txturunKod = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtsatis = new System.Windows.Forms.TextBox();
            this.txtirsaliye = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.urunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokMiktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.irsaliyeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btekle = new System.Windows.Forms.Button();
            this.btsil = new System.Windows.Forms.Button();
            this.bttemizle = new System.Windows.Forms.Button();
            this.bbul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Kodu  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barkod No  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok Miktarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Satış Fiyatı ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(21, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "İrsaliye No ";
            // 
            // txturunKod
            // 
            this.txturunKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunKod.Location = new System.Drawing.Point(166, 91);
            this.txturunKod.Name = "txturunKod";
            this.txturunKod.Size = new System.Drawing.Size(146, 28);
            this.txturunKod.TabIndex = 5;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(166, 125);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(146, 28);
            this.txtBarkod.TabIndex = 6;
            // 
            // txtStok
            // 
            this.txtStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStok.Location = new System.Drawing.Point(166, 159);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(146, 28);
            this.txtStok.TabIndex = 7;
            // 
            // txtsatis
            // 
            this.txtsatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsatis.Location = new System.Drawing.Point(166, 193);
            this.txtsatis.Name = "txtsatis";
            this.txtsatis.Size = new System.Drawing.Size(146, 28);
            this.txtsatis.TabIndex = 8;
            // 
            // txtirsaliye
            // 
            this.txtirsaliye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtirsaliye.Location = new System.Drawing.Point(166, 227);
            this.txtirsaliye.Name = "txtirsaliye";
            this.txtirsaliye.Size = new System.Drawing.Size(146, 28);
            this.txtirsaliye.TabIndex = 9;
            // 
            // dgv
            // 
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunKodu,
            this.barkodNo,
            this.stokMiktari,
            this.satisFiyati,
            this.irsaliyeNo});
            this.dgv.Location = new System.Drawing.Point(365, 52);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(774, 546);
            this.dgv.TabIndex = 10;
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // urunKodu
            // 
            this.urunKodu.DataPropertyName = "urunKodu";
            this.urunKodu.HeaderText = "urunKodu";
            this.urunKodu.MinimumWidth = 6;
            this.urunKodu.Name = "urunKodu";
            this.urunKodu.ReadOnly = true;
            this.urunKodu.Width = 92;
            // 
            // barkodNo
            // 
            this.barkodNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.barkodNo.DataPropertyName = "barkodNo";
            this.barkodNo.HeaderText = "Barkod No";
            this.barkodNo.MinimumWidth = 6;
            this.barkodNo.Name = "barkodNo";
            this.barkodNo.ReadOnly = true;
            // 
            // stokMiktari
            // 
            this.stokMiktari.DataPropertyName = "stokMiktari";
            this.stokMiktari.HeaderText = "Stok Miktari";
            this.stokMiktari.MinimumWidth = 6;
            this.stokMiktari.Name = "stokMiktari";
            this.stokMiktari.ReadOnly = true;
            this.stokMiktari.Width = 105;
            // 
            // satisFiyati
            // 
            this.satisFiyati.DataPropertyName = "satisFiyati";
            this.satisFiyati.HeaderText = "Satis Fiyatı";
            this.satisFiyati.MinimumWidth = 6;
            this.satisFiyati.Name = "satisFiyati";
            this.satisFiyati.ReadOnly = true;
            this.satisFiyati.Width = 101;
            // 
            // irsaliyeNo
            // 
            this.irsaliyeNo.DataPropertyName = "irsaliyeNo";
            this.irsaliyeNo.HeaderText = "İrsaliye No";
            this.irsaliyeNo.MinimumWidth = 6;
            this.irsaliyeNo.Name = "irsaliyeNo";
            this.irsaliyeNo.ReadOnly = true;
            // 
            // btekle
            // 
            this.btekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btekle.Location = new System.Drawing.Point(116, 310);
            this.btekle.Name = "btekle";
            this.btekle.Size = new System.Drawing.Size(196, 55);
            this.btekle.TabIndex = 11;
            this.btekle.Text = "EKLE";
            this.btekle.UseVisualStyleBackColor = false;
            this.btekle.Click += new System.EventHandler(this.btekle_Click);
            // 
            // btsil
            // 
            this.btsil.BackColor = System.Drawing.Color.Crimson;
            this.btsil.Location = new System.Drawing.Point(116, 382);
            this.btsil.Name = "btsil";
            this.btsil.Size = new System.Drawing.Size(196, 55);
            this.btsil.TabIndex = 12;
            this.btsil.Text = "SİL";
            this.btsil.UseVisualStyleBackColor = false;
            this.btsil.Click += new System.EventHandler(this.btsil_Click);
            // 
            // bttemizle
            // 
            this.bttemizle.BackColor = System.Drawing.Color.Cyan;
            this.bttemizle.Location = new System.Drawing.Point(116, 456);
            this.bttemizle.Name = "bttemizle";
            this.bttemizle.Size = new System.Drawing.Size(196, 60);
            this.bttemizle.TabIndex = 13;
            this.bttemizle.Text = "TEMİZLE";
            this.bttemizle.UseVisualStyleBackColor = false;
            this.bttemizle.Click += new System.EventHandler(this.bttemizle_Click);
            // 
            // bbul
            // 
            this.bbul.Location = new System.Drawing.Point(116, 537);
            this.bbul.Name = "bbul";
            this.bbul.Size = new System.Drawing.Size(196, 56);
            this.bbul.TabIndex = 14;
            this.bbul.Text = "Bul";
            this.bbul.UseVisualStyleBackColor = true;
            this.bbul.Click += new System.EventHandler(this.bbul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1204, 711);
            this.Controls.Add(this.bbul);
            this.Controls.Add(this.bttemizle);
            this.Controls.Add(this.btsil);
            this.Controls.Add(this.btekle);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtirsaliye);
            this.Controls.Add(this.txtsatis);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.txturunKod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txturunKod;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtsatis;
        private System.Windows.Forms.TextBox txtirsaliye;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btekle;
        private System.Windows.Forms.Button btsil;
        private System.Windows.Forms.Button bttemizle;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokMiktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn irsaliyeNo;
        private System.Windows.Forms.Button bbul;
    }
}

