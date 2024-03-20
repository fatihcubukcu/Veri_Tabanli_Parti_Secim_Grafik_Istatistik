namespace Veri_Tabanli_Parti_Secim_Grafik_Istatistik
{
    partial class frmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GbGrafikler = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.IlceDegerleri = new System.Windows.Forms.GroupBox();
            this.LblE = new System.Windows.Forms.Label();
            this.LblD = new System.Windows.Forms.Label();
            this.LblB = new System.Windows.Forms.Label();
            this.LblC = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GbGrafikler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.IlceDegerleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbGrafikler
            // 
            this.GbGrafikler.Controls.Add(this.chart1);
            this.GbGrafikler.Location = new System.Drawing.Point(12, 12);
            this.GbGrafikler.Name = "GbGrafikler";
            this.GbGrafikler.Size = new System.Drawing.Size(1119, 313);
            this.GbGrafikler.TabIndex = 0;
            this.GbGrafikler.TabStop = false;
            this.GbGrafikler.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(3, 26);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Partiler";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1113, 284);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // IlceDegerleri
            // 
            this.IlceDegerleri.Controls.Add(this.LblE);
            this.IlceDegerleri.Controls.Add(this.LblD);
            this.IlceDegerleri.Controls.Add(this.LblB);
            this.IlceDegerleri.Controls.Add(this.LblC);
            this.IlceDegerleri.Controls.Add(this.LblA);
            this.IlceDegerleri.Controls.Add(this.progressBar5);
            this.IlceDegerleri.Controls.Add(this.label6);
            this.IlceDegerleri.Controls.Add(this.progressBar3);
            this.IlceDegerleri.Controls.Add(this.label4);
            this.IlceDegerleri.Controls.Add(this.progressBar4);
            this.IlceDegerleri.Controls.Add(this.label5);
            this.IlceDegerleri.Controls.Add(this.progressBar2);
            this.IlceDegerleri.Controls.Add(this.label3);
            this.IlceDegerleri.Controls.Add(this.progressBar1);
            this.IlceDegerleri.Controls.Add(this.label2);
            this.IlceDegerleri.Controls.Add(this.comboBox1);
            this.IlceDegerleri.Controls.Add(this.label1);
            this.IlceDegerleri.Location = new System.Drawing.Point(15, 331);
            this.IlceDegerleri.Name = "IlceDegerleri";
            this.IlceDegerleri.Size = new System.Drawing.Size(1116, 278);
            this.IlceDegerleri.TabIndex = 1;
            this.IlceDegerleri.TabStop = false;
            this.IlceDegerleri.Text = "İlçe Değerleri";
            // 
            // LblE
            // 
            this.LblE.AutoSize = true;
            this.LblE.Location = new System.Drawing.Point(738, 222);
            this.LblE.Name = "LblE";
            this.LblE.Size = new System.Drawing.Size(24, 24);
            this.LblE.TabIndex = 16;
            this.LblE.Text = "0";
            // 
            // LblD
            // 
            this.LblD.AutoSize = true;
            this.LblD.Location = new System.Drawing.Point(738, 195);
            this.LblD.Name = "LblD";
            this.LblD.Size = new System.Drawing.Size(24, 24);
            this.LblD.TabIndex = 15;
            this.LblD.Text = "0";
            // 
            // LblB
            // 
            this.LblB.AutoSize = true;
            this.LblB.Location = new System.Drawing.Point(738, 139);
            this.LblB.Name = "LblB";
            this.LblB.Size = new System.Drawing.Size(24, 24);
            this.LblB.TabIndex = 14;
            this.LblB.Text = "0";
            // 
            // LblC
            // 
            this.LblC.AutoSize = true;
            this.LblC.Location = new System.Drawing.Point(738, 166);
            this.LblC.Name = "LblC";
            this.LblC.Size = new System.Drawing.Size(24, 24);
            this.LblC.TabIndex = 13;
            this.LblC.Text = "0";
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Location = new System.Drawing.Point(738, 109);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(24, 24);
            this.LblA.TabIndex = 12;
            this.LblA.Text = "0";
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(191, 222);
            this.progressBar5.Maximum = 250;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(530, 23);
            this.progressBar5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "E Partisi:";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(190, 168);
            this.progressBar3.Maximum = 250;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(530, 23);
            this.progressBar3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "D Partisi:";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(190, 195);
            this.progressBar4.Maximum = 250;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(530, 23);
            this.progressBar4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "C Partisi:";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(191, 139);
            this.progressBar2.Maximum = 250;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(530, 23);
            this.progressBar2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "B Partisi:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(191, 110);
            this.progressBar1.Maximum = 250;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(530, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "A Partisi:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(460, 35);
            this.comboBox1.MaxDropDownItems = 81;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(301, 32);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçin:";
            // 
            // frmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1182, 621);
            this.Controls.Add(this.IlceDegerleri);
            this.Controls.Add(this.GbGrafikler);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmGrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seçim Grafikler";
            this.Load += new System.EventHandler(this.frmGrafikler_Load);
            this.GbGrafikler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.IlceDegerleri.ResumeLayout(false);
            this.IlceDegerleri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbGrafikler;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox IlceDegerleri;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblE;
        private System.Windows.Forms.Label LblD;
        private System.Windows.Forms.Label LblB;
        private System.Windows.Forms.Label LblC;
        private System.Windows.Forms.Label LblA;
    }
}