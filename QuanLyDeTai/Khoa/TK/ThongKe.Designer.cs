
namespace QuanLyDeTai.Khoa.TK
{
    partial class ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTKDT = new Bunifu.UI.WinForms.BunifuPanel();
            this.chartTKPT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSelectYear = new System.Windows.Forms.ComboBox();
            this.chartTKDTBM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTKGV = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTKDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKDTBM)).BeginInit();
            this.panelTKGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTKDT
            // 
            this.panelTKDT.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelTKDT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTKDT.BackgroundImage")));
            this.panelTKDT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTKDT.BorderColor = System.Drawing.Color.Transparent;
            this.panelTKDT.BorderRadius = 3;
            this.panelTKDT.BorderThickness = 1;
            this.panelTKDT.Controls.Add(this.chartTKPT);
            this.panelTKDT.Controls.Add(this.label3);
            this.panelTKDT.Controls.Add(this.cmbSelectYear);
            this.panelTKDT.Controls.Add(this.chartTKDTBM);
            this.panelTKDT.Controls.Add(this.label2);
            this.panelTKDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTKDT.Location = new System.Drawing.Point(0, 362);
            this.panelTKDT.Name = "panelTKDT";
            this.panelTKDT.ShowBorders = true;
            this.panelTKDT.Size = new System.Drawing.Size(1504, 412);
            this.panelTKDT.TabIndex = 1;
            // 
            // chartTKPT
            // 
            this.chartTKPT.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.chartTKPT.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTKPT.Legends.Add(legend1);
            this.chartTKPT.Location = new System.Drawing.Point(895, 25);
            this.chartTKPT.Name = "chartTKPT";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "TKPT";
            this.chartTKPT.Series.Add(series1);
            this.chartTKPT.Size = new System.Drawing.Size(516, 341);
            this.chartTKPT.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Year";
            // 
            // cmbSelectYear
            // 
            this.cmbSelectYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSelectYear.FormattingEnabled = true;
            this.cmbSelectYear.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmbSelectYear.Location = new System.Drawing.Point(87, 69);
            this.cmbSelectYear.Name = "cmbSelectYear";
            this.cmbSelectYear.Size = new System.Drawing.Size(121, 24);
            this.cmbSelectYear.TabIndex = 3;
            this.cmbSelectYear.SelectedIndexChanged += new System.EventHandler(this.cmbSelectYear_SelectedIndexChanged);
            // 
            // chartTKDTBM
            // 
            this.chartTKDTBM.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea2.Name = "ChartArea1";
            this.chartTKDTBM.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTKDTBM.Legends.Add(legend2);
            this.chartTKDTBM.Location = new System.Drawing.Point(279, 25);
            this.chartTKDTBM.Name = "chartTKDTBM";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "DTBM";
            this.chartTKDTBM.Series.Add(series2);
            this.chartTKDTBM.Size = new System.Drawing.Size(516, 341);
            this.chartTKDTBM.TabIndex = 2;
            this.chartTKDTBM.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Topic";
            // 
            // panelTKGV
            // 
            this.panelTKGV.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelTKGV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTKGV.BackgroundImage")));
            this.panelTKGV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTKGV.BorderColor = System.Drawing.Color.Transparent;
            this.panelTKGV.BorderRadius = 3;
            this.panelTKGV.BorderThickness = 1;
            this.panelTKGV.Controls.Add(this.label1);
            this.panelTKGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTKGV.Location = new System.Drawing.Point(0, 0);
            this.panelTKGV.Name = "panelTKGV";
            this.panelTKGV.ShowBorders = true;
            this.panelTKGV.Size = new System.Drawing.Size(1504, 362);
            this.panelTKGV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 774);
            this.Controls.Add(this.panelTKDT);
            this.Controls.Add(this.panelTKGV);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.panelTKDT.ResumeLayout(false);
            this.panelTKDT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKDTBM)).EndInit();
            this.panelTKGV.ResumeLayout(false);
            this.panelTKGV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel panelTKGV;
        private Bunifu.UI.WinForms.BunifuPanel panelTKDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSelectYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTKDTBM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTKPT;
    }
}