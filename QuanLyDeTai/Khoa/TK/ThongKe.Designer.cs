
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
            this.labelTapChi = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cmbTapChi = new System.Windows.Forms.ComboBox();
            this.cmbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtSLDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTKDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKDTBM)).BeginInit();
            this.panelTKGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTKDT
            // 
            this.panelTKDT.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.panelTKDT.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelTKDT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTKDT.BackgroundImage")));
            this.panelTKDT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTKDT.BorderColor = System.Drawing.Color.Transparent;
            this.panelTKDT.BorderRadius = 3;
            this.panelTKDT.BorderThickness = 1;
            this.panelTKDT.Controls.Add(this.label5);
            this.panelTKDT.Controls.Add(this.txtSLDT);
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
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm";
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
            this.chartTKDTBM.Location = new System.Drawing.Point(261, 25);
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
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đề tài";
            // 
            // panelTKGV
            // 
            this.panelTKGV.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelTKGV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTKGV.BackgroundImage")));
            this.panelTKGV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTKGV.BorderColor = System.Drawing.Color.Transparent;
            this.panelTKGV.BorderRadius = 3;
            this.panelTKGV.BorderThickness = 1;
            this.panelTKGV.Controls.Add(this.labelTapChi);
            this.panelTKGV.Controls.Add(this.bunifuLabel1);
            this.panelTKGV.Controls.Add(this.cmbTapChi);
            this.panelTKGV.Controls.Add(this.cmbChuyenNganh);
            this.panelTKGV.Controls.Add(this.label4);
            this.panelTKGV.Controls.Add(this.label1);
            this.panelTKGV.Controls.Add(this.comboBox1);
            this.panelTKGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTKGV.Location = new System.Drawing.Point(0, 0);
            this.panelTKGV.Name = "panelTKGV";
            this.panelTKGV.ShowBorders = true;
            this.panelTKGV.Size = new System.Drawing.Size(1504, 362);
            this.panelTKGV.TabIndex = 0;
            // 
            // labelTapChi
            // 
            this.labelTapChi.AllowParentOverrides = false;
            this.labelTapChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTapChi.AutoEllipsis = false;
            this.labelTapChi.CursorType = null;
            this.labelTapChi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTapChi.Location = new System.Drawing.Point(829, 20);
            this.labelTapChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelTapChi.Name = "labelTapChi";
            this.labelTapChi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTapChi.Size = new System.Drawing.Size(49, 19);
            this.labelTapChi.TabIndex = 11;
            this.labelTapChi.Text = "Tạp chí";
            this.labelTapChi.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelTapChi.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(439, 20);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(94, 19);
            this.bunifuLabel1.TabIndex = 10;
            this.bunifuLabel1.Text = "Chuyên ngành";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cmbTapChi
            // 
            this.cmbTapChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTapChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTapChi.FormattingEnabled = true;
            this.cmbTapChi.Location = new System.Drawing.Point(892, 14);
            this.cmbTapChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTapChi.Name = "cmbTapChi";
            this.cmbTapChi.Size = new System.Drawing.Size(175, 26);
            this.cmbTapChi.TabIndex = 9;
            // 
            // cmbChuyenNganh
            // 
            this.cmbChuyenNganh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbChuyenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChuyenNganh.FormattingEnabled = true;
            this.cmbChuyenNganh.Location = new System.Drawing.Point(558, 14);
            this.cmbChuyenNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChuyenNganh.Name = "cmbChuyenNganh";
            this.cmbChuyenNganh.Size = new System.Drawing.Size(168, 26);
            this.cmbChuyenNganh.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bài báo khoa học";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(222, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // txtSLDT
            // 
            this.txtSLDT.BackColor = System.Drawing.SystemColors.Control;
            this.txtSLDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSLDT.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSLDT.Location = new System.Drawing.Point(108, 121);
            this.txtSLDT.Name = "txtSLDT";
            this.txtSLDT.Size = new System.Drawing.Size(100, 15);
            this.txtSLDT.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số lượng";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.UI.WinForms.BunifuLabel labelTapChi;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.ComboBox cmbTapChi;
        private System.Windows.Forms.ComboBox cmbChuyenNganh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSLDT;
    }
}