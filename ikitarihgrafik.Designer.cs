namespace bizmar
{
    partial class ikitarihgrafik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYansit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 60);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(776, 359);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(12, 34);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(104, 20);
            this.dtpBaslangic.TabIndex = 1;
            this.dtpBaslangic.Value = new System.DateTime(2023, 1, 15, 0, 0, 0, 0);
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(150, 34);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(104, 20);
            this.dtpBitis.TabIndex = 2;
            this.dtpBitis.Value = new System.DateTime(2023, 1, 20, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(147, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // btnYansit
            // 
            this.btnYansit.Location = new System.Drawing.Point(275, 26);
            this.btnYansit.Name = "btnYansit";
            this.btnYansit.Size = new System.Drawing.Size(100, 28);
            this.btnYansit.TabIndex = 5;
            this.btnYansit.Text = "Grafiğe Yansıt";
            this.btnYansit.UseVisualStyleBackColor = true;
            this.btnYansit.Click += new System.EventHandler(this.btnYansit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.btnYansit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "İki Tarih Arasındaki Satışların Grafiği";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYansit;
    }
}