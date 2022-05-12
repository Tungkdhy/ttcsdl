
namespace QuanLyDeTai.Khoa.QLDT
{
    partial class ThongTinTV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinTV));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDT = new System.Windows.Forms.TextBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.listTV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMaGV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXoaGV = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnThemGV = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listTV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ĐT:";
            // 
            // txtMaDT
            // 
            this.txtMaDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDT.Location = new System.Drawing.Point(106, 42);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.ReadOnly = true;
            this.txtMaDT.Size = new System.Drawing.Size(128, 23);
            this.txtMaDT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên ĐT:";
            // 
            // txtTenDT
            // 
            this.txtTenDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDT.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTenDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDT.Location = new System.Drawing.Point(413, 42);
            this.txtTenDT.Name = "txtTenDT";
            this.txtTenDT.ReadOnly = true;
            this.txtTenDT.Size = new System.Drawing.Size(425, 23);
            this.txtTenDT.TabIndex = 3;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.listTV);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 152);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1105, 269);
            this.bunifuPanel1.TabIndex = 4;
            // 
            // listTV
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.listTV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listTV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listTV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTV.Location = new System.Drawing.Point(0, 0);
            this.listTV.Name = "listTV";
            this.listTV.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.listTV.RowTemplate.Height = 24;
            this.listTV.Size = new System.Drawing.Size(1105, 269);
            this.listTV.TabIndex = 0;
            this.listTV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listTV_CellClick);
            this.listTV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listTV_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thành viên";
            // 
            // cmbMaGV
            // 
            this.cmbMaGV.FormattingEnabled = true;
            this.cmbMaGV.Location = new System.Drawing.Point(405, 112);
            this.cmbMaGV.Name = "cmbMaGV";
            this.cmbMaGV.Size = new System.Drawing.Size(121, 24);
            this.cmbMaGV.TabIndex = 6;
            this.cmbMaGV.SelectedIndexChanged += new System.EventHandler(this.cmbMaGV_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã GV";
            // 
            // txtTenGV
            // 
            this.txtTenGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenGV.Enabled = false;
            this.txtTenGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGV.Location = new System.Drawing.Point(662, 111);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.ReadOnly = true;
            this.txtTenGV.Size = new System.Drawing.Size(195, 23);
            this.txtTenGV.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(580, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tên GV";
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.AllowAnimations = true;
            this.btnXoaGV.AllowMouseEffects = true;
            this.btnXoaGV.AllowToggling = false;
            this.btnXoaGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaGV.AnimationSpeed = 200;
            this.btnXoaGV.AutoGenerateColors = false;
            this.btnXoaGV.AutoRoundBorders = false;
            this.btnXoaGV.AutoSizeLeftIcon = true;
            this.btnXoaGV.AutoSizeRightIcon = true;
            this.btnXoaGV.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaGV.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnXoaGV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaGV.BackgroundImage")));
            this.btnXoaGV.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoaGV.ButtonText = "Xóa";
            this.btnXoaGV.ButtonTextMarginLeft = 0;
            this.btnXoaGV.ColorContrastOnClick = 45;
            this.btnXoaGV.ColorContrastOnHover = 45;
            this.btnXoaGV.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnXoaGV.CustomizableEdges = borderEdges1;
            this.btnXoaGV.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoaGV.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXoaGV.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXoaGV.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXoaGV.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnXoaGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaGV.ForeColor = System.Drawing.Color.White;
            this.btnXoaGV.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaGV.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnXoaGV.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnXoaGV.IconMarginLeft = 11;
            this.btnXoaGV.IconPadding = 10;
            this.btnXoaGV.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaGV.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnXoaGV.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnXoaGV.IconSize = 25;
            this.btnXoaGV.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXoaGV.IdleBorderRadius = 1;
            this.btnXoaGV.IdleBorderThickness = 1;
            this.btnXoaGV.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnXoaGV.IdleIconLeftImage = null;
            this.btnXoaGV.IdleIconRightImage = null;
            this.btnXoaGV.IndicateFocus = false;
            this.btnXoaGV.Location = new System.Drawing.Point(920, 95);
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXoaGV.OnDisabledState.BorderRadius = 1;
            this.btnXoaGV.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoaGV.OnDisabledState.BorderThickness = 1;
            this.btnXoaGV.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXoaGV.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXoaGV.OnDisabledState.IconLeftImage = null;
            this.btnXoaGV.OnDisabledState.IconRightImage = null;
            this.btnXoaGV.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXoaGV.onHoverState.BorderRadius = 1;
            this.btnXoaGV.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoaGV.onHoverState.BorderThickness = 1;
            this.btnXoaGV.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXoaGV.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnXoaGV.onHoverState.IconLeftImage = null;
            this.btnXoaGV.onHoverState.IconRightImage = null;
            this.btnXoaGV.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXoaGV.OnIdleState.BorderRadius = 1;
            this.btnXoaGV.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoaGV.OnIdleState.BorderThickness = 1;
            this.btnXoaGV.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnXoaGV.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnXoaGV.OnIdleState.IconLeftImage = null;
            this.btnXoaGV.OnIdleState.IconRightImage = null;
            this.btnXoaGV.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXoaGV.OnPressedState.BorderRadius = 1;
            this.btnXoaGV.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoaGV.OnPressedState.BorderThickness = 1;
            this.btnXoaGV.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXoaGV.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnXoaGV.OnPressedState.IconLeftImage = null;
            this.btnXoaGV.OnPressedState.IconRightImage = null;
            this.btnXoaGV.Size = new System.Drawing.Size(150, 39);
            this.btnXoaGV.TabIndex = 12;
            this.btnXoaGV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoaGV.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoaGV.TextMarginLeft = 0;
            this.btnXoaGV.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnXoaGV.UseDefaultRadiusAndThickness = true;
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // btnThemGV
            // 
            this.btnThemGV.AllowAnimations = true;
            this.btnThemGV.AllowMouseEffects = true;
            this.btnThemGV.AllowToggling = false;
            this.btnThemGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemGV.AnimationSpeed = 200;
            this.btnThemGV.AutoGenerateColors = false;
            this.btnThemGV.AutoRoundBorders = false;
            this.btnThemGV.AutoSizeLeftIcon = true;
            this.btnThemGV.AutoSizeRightIcon = true;
            this.btnThemGV.BackColor = System.Drawing.Color.Transparent;
            this.btnThemGV.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnThemGV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemGV.BackgroundImage")));
            this.btnThemGV.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemGV.ButtonText = "Thêm thành viên";
            this.btnThemGV.ButtonTextMarginLeft = 0;
            this.btnThemGV.ColorContrastOnClick = 45;
            this.btnThemGV.ColorContrastOnHover = 45;
            this.btnThemGV.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnThemGV.CustomizableEdges = borderEdges2;
            this.btnThemGV.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemGV.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnThemGV.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnThemGV.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnThemGV.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnThemGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemGV.ForeColor = System.Drawing.Color.White;
            this.btnThemGV.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemGV.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnThemGV.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnThemGV.IconMarginLeft = 11;
            this.btnThemGV.IconPadding = 10;
            this.btnThemGV.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemGV.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnThemGV.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnThemGV.IconSize = 25;
            this.btnThemGV.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnThemGV.IdleBorderRadius = 1;
            this.btnThemGV.IdleBorderThickness = 1;
            this.btnThemGV.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnThemGV.IdleIconLeftImage = null;
            this.btnThemGV.IdleIconRightImage = null;
            this.btnThemGV.IndicateFocus = false;
            this.btnThemGV.Location = new System.Drawing.Point(920, 26);
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnThemGV.OnDisabledState.BorderRadius = 1;
            this.btnThemGV.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemGV.OnDisabledState.BorderThickness = 1;
            this.btnThemGV.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnThemGV.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnThemGV.OnDisabledState.IconLeftImage = null;
            this.btnThemGV.OnDisabledState.IconRightImage = null;
            this.btnThemGV.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnThemGV.onHoverState.BorderRadius = 1;
            this.btnThemGV.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemGV.onHoverState.BorderThickness = 1;
            this.btnThemGV.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnThemGV.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnThemGV.onHoverState.IconLeftImage = null;
            this.btnThemGV.onHoverState.IconRightImage = null;
            this.btnThemGV.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnThemGV.OnIdleState.BorderRadius = 1;
            this.btnThemGV.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemGV.OnIdleState.BorderThickness = 1;
            this.btnThemGV.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnThemGV.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnThemGV.OnIdleState.IconLeftImage = null;
            this.btnThemGV.OnIdleState.IconRightImage = null;
            this.btnThemGV.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThemGV.OnPressedState.BorderRadius = 1;
            this.btnThemGV.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThemGV.OnPressedState.BorderThickness = 1;
            this.btnThemGV.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThemGV.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnThemGV.OnPressedState.IconLeftImage = null;
            this.btnThemGV.OnPressedState.IconRightImage = null;
            this.btnThemGV.Size = new System.Drawing.Size(150, 39);
            this.btnThemGV.TabIndex = 13;
            this.btnThemGV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemGV.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThemGV.TextMarginLeft = 0;
            this.btnThemGV.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnThemGV.UseDefaultRadiusAndThickness = true;
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // ThongTinTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 421);
            this.Controls.Add(this.btnThemGV);
            this.Controls.Add(this.btnXoaGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMaGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.txtTenDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaDT);
            this.Controls.Add(this.label1);
            this.Name = "ThongTinTV";
            this.Text = "ThongTinTV";
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listTV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDT;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView listTV;
        private System.Windows.Forms.ComboBox cmbMaGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnXoaGV;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnThemGV;
    }
}