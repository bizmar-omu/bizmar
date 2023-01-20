namespace Satış
{
    partial class satisTuru
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
            this.txttoplamtutar = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btpesinsatis = new System.Windows.Forms.Button();
            this.btcarisatis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txttoplamtutar
            // 
            this.txttoplamtutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttoplamtutar.Location = new System.Drawing.Point(260, 38);
            this.txttoplamtutar.Name = "txttoplamtutar";
            this.txttoplamtutar.ReadOnly = true;
            this.txttoplamtutar.Size = new System.Drawing.Size(181, 34);
            this.txttoplamtutar.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(86, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toplam Tutar";
            // 
            // btpesinsatis
            // 
            this.btpesinsatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btpesinsatis.Location = new System.Drawing.Point(66, 161);
            this.btpesinsatis.Name = "btpesinsatis";
            this.btpesinsatis.Size = new System.Drawing.Size(206, 100);
            this.btpesinsatis.TabIndex = 3;
            this.btpesinsatis.Text = "Peşin Satış";
            this.btpesinsatis.UseVisualStyleBackColor = true;
            this.btpesinsatis.Click += new System.EventHandler(this.btpesinsatis_Click);
            // 
            // btcarisatis
            // 
            this.btcarisatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btcarisatis.Location = new System.Drawing.Point(297, 161);
            this.btcarisatis.Name = "btcarisatis";
            this.btcarisatis.Size = new System.Drawing.Size(203, 100);
            this.btcarisatis.TabIndex = 4;
            this.btcarisatis.Text = "Cari Satış";
            this.btcarisatis.UseVisualStyleBackColor = true;
            this.btcarisatis.Click += new System.EventHandler(this.btcarisatis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(177, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Satış Türünü Seçiniz";
            // 
            // satis_türü_ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 352);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btcarisatis);
            this.Controls.Add(this.btpesinsatis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttoplamtutar);
            this.Name = "satis_türü_ekranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btpesinsatis;
        private System.Windows.Forms.Button btcarisatis;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txttoplamtutar;
    }
}