namespace kar_zarar_rapor
{
    partial class Form1
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
            this.dgvpesinsatis = new System.Windows.Forms.DataGridView();
            this.psnoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pstutarrr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcarisatis = new System.Windows.Forms.DataGridView();
            this.sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihhh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvirsaliye = new System.Windows.Forms.DataGridView();
            this.isno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutarrrrr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihhhhhhhhhhhh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulnoooo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtirsaliyetoplam = new System.Windows.Forms.TextBox();
            this.txtpsno = new System.Windows.Forms.TextBox();
            this.txtcsstoplam = new System.Windows.Forms.TextBox();
            this.txtciro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpesinsatis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarisatis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvirsaliye)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvpesinsatis
            // 
            this.dgvpesinsatis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpesinsatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpesinsatis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.psnoo,
            this.pstutarrr,
            this.Tarih,
            this.Column1});
            this.dgvpesinsatis.Location = new System.Drawing.Point(45, 92);
            this.dgvpesinsatis.Name = "dgvpesinsatis";
            this.dgvpesinsatis.RowHeadersWidth = 51;
            this.dgvpesinsatis.RowTemplate.Height = 24;
            this.dgvpesinsatis.Size = new System.Drawing.Size(427, 304);
            this.dgvpesinsatis.TabIndex = 0;
            this.dgvpesinsatis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpesinsatis_CellContentClick);
            // 
            // psnoo
            // 
            this.psnoo.DataPropertyName = "psNo";
            this.psnoo.HeaderText = "Satış No";
            this.psnoo.MinimumWidth = 6;
            this.psnoo.Name = "psnoo";
            // 
            // pstutarrr
            // 
            this.pstutarrr.DataPropertyName = "psTutar";
            this.pstutarrr.HeaderText = "Tutar";
            this.pstutarrr.MinimumWidth = 6;
            this.pstutarrr.Name = "pstutarrr";
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "psTarih";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.MinimumWidth = 6;
            this.Tarih.Name = "Tarih";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ulNo";
            this.Column1.HeaderText = "ulNo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // dgvcarisatis
            // 
            this.dgvcarisatis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcarisatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcarisatis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sno,
            this.tutar,
            this.tarihhh,
            this.ulno,
            this.mnoo});
            this.dgvcarisatis.Location = new System.Drawing.Point(540, 92);
            this.dgvcarisatis.Name = "dgvcarisatis";
            this.dgvcarisatis.RowHeadersWidth = 51;
            this.dgvcarisatis.RowTemplate.Height = 24;
            this.dgvcarisatis.Size = new System.Drawing.Size(418, 304);
            this.dgvcarisatis.TabIndex = 1;
            // 
            // sno
            // 
            this.sno.DataPropertyName = "csNo";
            this.sno.HeaderText = "Satış No";
            this.sno.MinimumWidth = 6;
            this.sno.Name = "sno";
            // 
            // tutar
            // 
            this.tutar.DataPropertyName = "csTutar";
            this.tutar.HeaderText = "Tutar";
            this.tutar.MinimumWidth = 6;
            this.tutar.Name = "tutar";
            // 
            // tarihhh
            // 
            this.tarihhh.DataPropertyName = "csTarih";
            this.tarihhh.HeaderText = "Tarih";
            this.tarihhh.MinimumWidth = 6;
            this.tarihhh.Name = "tarihhh";
            // 
            // ulno
            // 
            this.ulno.DataPropertyName = "ulNo";
            this.ulno.HeaderText = "Ulno";
            this.ulno.MinimumWidth = 6;
            this.ulno.Name = "ulno";
            this.ulno.Visible = false;
            // 
            // mnoo
            // 
            this.mnoo.DataPropertyName = "mNo";
            this.mnoo.HeaderText = "Müşteri No";
            this.mnoo.MinimumWidth = 6;
            this.mnoo.Name = "mnoo";
            this.mnoo.Visible = false;
            // 
            // dgvirsaliye
            // 
            this.dgvirsaliye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvirsaliye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvirsaliye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isno,
            this.tutarrrrr,
            this.tarihhhhhhhhhhhh,
            this.ulnoooo,
            this.tno});
            this.dgvirsaliye.Location = new System.Drawing.Point(1004, 92);
            this.dgvirsaliye.Name = "dgvirsaliye";
            this.dgvirsaliye.RowHeadersWidth = 51;
            this.dgvirsaliye.RowTemplate.Height = 24;
            this.dgvirsaliye.Size = new System.Drawing.Size(511, 304);
            this.dgvirsaliye.TabIndex = 2;
            // 
            // isno
            // 
            this.isno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.isno.DataPropertyName = "irsaliyeNo";
            this.isno.HeaderText = "İrsaliy No";
            this.isno.MinimumWidth = 6;
            this.isno.Name = "isno";
            this.isno.Width = 92;
            // 
            // tutarrrrr
            // 
            this.tutarrrrr.DataPropertyName = "irsaliyeTutar";
            this.tutarrrrr.HeaderText = "Tutar";
            this.tutarrrrr.MinimumWidth = 6;
            this.tutarrrrr.Name = "tutarrrrr";
            // 
            // tarihhhhhhhhhhhh
            // 
            this.tarihhhhhhhhhhhh.DataPropertyName = "irsaliyeTarih";
            this.tarihhhhhhhhhhhh.HeaderText = "Tarih";
            this.tarihhhhhhhhhhhh.MinimumWidth = 6;
            this.tarihhhhhhhhhhhh.Name = "tarihhhhhhhhhhhh";
            // 
            // ulnoooo
            // 
            this.ulnoooo.DataPropertyName = "ulNo";
            this.ulnoooo.HeaderText = "UlNo";
            this.ulnoooo.MinimumWidth = 6;
            this.ulnoooo.Name = "ulnoooo";
            this.ulnoooo.Visible = false;
            // 
            // tno
            // 
            this.tno.DataPropertyName = "tNo";
            this.tno.HeaderText = "Tedarikçi No";
            this.tno.MinimumWidth = 6;
            this.tno.Name = "tno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(150, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Peşin Satış";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(659, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cari Satış";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1174, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "İrsaliye";
            // 
            // txtirsaliyetoplam
            // 
            this.txtirsaliyetoplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtirsaliyetoplam.Location = new System.Drawing.Point(1342, 437);
            this.txtirsaliyetoplam.Name = "txtirsaliyetoplam";
            this.txtirsaliyetoplam.Size = new System.Drawing.Size(173, 34);
            this.txtirsaliyetoplam.TabIndex = 6;
            // 
            // txtpsno
            // 
            this.txtpsno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpsno.Location = new System.Drawing.Point(296, 437);
            this.txtpsno.Name = "txtpsno";
            this.txtpsno.Size = new System.Drawing.Size(176, 34);
            this.txtpsno.TabIndex = 7;
            // 
            // txtcsstoplam
            // 
            this.txtcsstoplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcsstoplam.Location = new System.Drawing.Point(783, 437);
            this.txtcsstoplam.Name = "txtcsstoplam";
            this.txtcsstoplam.Size = new System.Drawing.Size(175, 34);
            this.txtcsstoplam.TabIndex = 8;
            // 
            // txtciro
            // 
            this.txtciro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtciro.Location = new System.Drawing.Point(695, 616);
            this.txtciro.Name = "txtciro";
            this.txtciro.Size = new System.Drawing.Size(201, 34);
            this.txtciro.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(49, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Peşin Satış Toplamı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(566, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cari Satış Toplamı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1129, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "İrsaliye Toplamı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(581, 619);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ciro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 771);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtciro);
            this.Controls.Add(this.txtcsstoplam);
            this.Controls.Add(this.txtpsno);
            this.Controls.Add(this.txtirsaliyetoplam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvirsaliye);
            this.Controls.Add(this.dgvcarisatis);
            this.Controls.Add(this.dgvpesinsatis);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpesinsatis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarisatis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvirsaliye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpesinsatis;
        private System.Windows.Forms.DataGridView dgvcarisatis;
        private System.Windows.Forms.DataGridView dgvirsaliye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtirsaliyetoplam;
        private System.Windows.Forms.TextBox txtpsno;
        private System.Windows.Forms.TextBox txtcsstoplam;
        private System.Windows.Forms.TextBox txtciro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn psnoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pstutarrr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihhh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulno;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn isno;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarrrrr;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihhhhhhhhhhhh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulnoooo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tno;
    }
}

