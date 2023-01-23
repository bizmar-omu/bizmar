namespace a
{
    partial class MusteriBorcRaporEkrani
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
            this.txtno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odemeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemeTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemeTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtno
            // 
            this.txtno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtno.Location = new System.Drawing.Point(162, 70);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(139, 28);
            this.txtno.TabIndex = 7;
            this.txtno.TextChanged += new System.EventHandler(this.txtno_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Müşteri No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odemeNo,
            this.mNo,
            this.odemeTutar,
            this.odemeTarih});
            this.dataGridView1.Location = new System.Drawing.Point(12, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(916, 314);
            this.dataGridView1.TabIndex = 12;
            // 
            // odemeNo
            // 
            this.odemeNo.DataPropertyName = "odemeNo";
            this.odemeNo.HeaderText = "Ödeme No";
            this.odemeNo.MinimumWidth = 6;
            this.odemeNo.Name = "odemeNo";
            // 
            // mNo
            // 
            this.mNo.DataPropertyName = "mNo";
            this.mNo.HeaderText = "Müşteri No";
            this.mNo.MinimumWidth = 6;
            this.mNo.Name = "mNo";
            // 
            // odemeTutar
            // 
            this.odemeTutar.DataPropertyName = "odemeTutari";
            this.odemeTutar.HeaderText = "Ödeme Tutarı";
            this.odemeTutar.MinimumWidth = 6;
            this.odemeTutar.Name = "odemeTutar";
            // 
            // odemeTarih
            // 
            this.odemeTarih.DataPropertyName = "odemeTarihi";
            this.odemeTarih.HeaderText = "Ödeme Tarihi";
            this.odemeTarih.MinimumWidth = 6;
            this.odemeTarih.Name = "odemeTarih";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 68);
            this.button1.TabIndex = 13;
            this.button1.Text = "Excelde Raporla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "10-10-2023";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MusteriBorcRaporEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 499);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.label1);
            this.Name = "MusteriBorcRaporEkrani";
            this.Text = "Müşteri Borç Rapor Ekranı";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeTarih;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}