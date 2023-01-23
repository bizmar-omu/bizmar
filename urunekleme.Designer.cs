
namespace bizmar
{
    partial class urunekleme
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
            this.dataGridViewİrsaliye = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.urunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokMiktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewİrsaliye)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewİrsaliye
            // 
            this.dataGridViewİrsaliye.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewİrsaliye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewİrsaliye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunKodu,
            this.urunAd,
            this.barkodNo,
            this.stokMiktari,
            this.satisFiyati});
            this.dataGridViewİrsaliye.Location = new System.Drawing.Point(322, 124);
            this.dataGridViewİrsaliye.Name = "dataGridViewİrsaliye";
            this.dataGridViewİrsaliye.Size = new System.Drawing.Size(441, 222);
            this.dataGridViewİrsaliye.TabIndex = 1;
            this.dataGridViewİrsaliye.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewİrsaliye_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(492, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Stoğa Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Dosya Seç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(43, 124);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(248, 222);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // urunKodu
            // 
            this.urunKodu.DataPropertyName = "urunKodu";
            this.urunKodu.HeaderText = "urunKodu";
            this.urunKodu.Name = "urunKodu";
            // 
            // urunAd
            // 
            this.urunAd.DataPropertyName = "urunAd";
            this.urunAd.HeaderText = "urunAd";
            this.urunAd.Name = "urunAd";
            // 
            // barkodNo
            // 
            this.barkodNo.DataPropertyName = "barkodNo";
            this.barkodNo.HeaderText = "barkodNo";
            this.barkodNo.Name = "barkodNo";
            // 
            // stokMiktari
            // 
            this.stokMiktari.DataPropertyName = "stokMiktari";
            this.stokMiktari.HeaderText = "stokMiktari";
            this.stokMiktari.Name = "stokMiktari";
            // 
            // satisFiyati
            // 
            this.satisFiyati.DataPropertyName = "satisFiyati";
            this.satisFiyati.HeaderText = "satisFiyati";
            this.satisFiyati.Name = "satisFiyati";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewİrsaliye);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewİrsaliye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewİrsaliye;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokMiktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisFiyati;
    }
}

