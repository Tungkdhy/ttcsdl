
namespace QuanLyDeTai.Khoa
{
    partial class QuanLyGV
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
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyGV));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.ListGV = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtsearchGV = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnDSCN = new System.Windows.Forms.Button();
            this.btnUndo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lbQLGV = new System.Windows.Forms.Label();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListGV)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.bunifuTransition1.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 741);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1777, 89);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(960, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "  Xóa";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(844, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "  Sửa";
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuTransition1.SetDecoration(this.btnSua, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(847, 3);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(53, 57);
            this.btnSua.TabIndex = 1;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuTransition1.SetDecoration(this.btnXoa, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(963, 3);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(43, 57);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // ListGV
            // 
            this.ListGV.AllowCustomTheming = false;
            this.ListGV.AllowUserToAddRows = false;
            this.ListGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.ListGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ListGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListGV.ColumnHeadersHeight = 40;
            this.ListGV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.ListGV.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ListGV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ListGV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ListGV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ListGV.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.ListGV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ListGV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.ListGV.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.ListGV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ListGV.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.ListGV.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ListGV.CurrentTheme.Name = null;
            this.ListGV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ListGV.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ListGV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ListGV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ListGV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuTransition1.SetDecoration(this.ListGV, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListGV.EnableHeadersVisualStyles = false;
            this.ListGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ListGV.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.ListGV.HeaderBgColor = System.Drawing.Color.Empty;
            this.ListGV.HeaderForeColor = System.Drawing.Color.White;
            this.ListGV.Location = new System.Drawing.Point(0, 95);
            this.ListGV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ListGV.Name = "ListGV";
            this.ListGV.ReadOnly = true;
            this.ListGV.RowHeadersVisible = false;
            this.ListGV.RowHeadersWidth = 51;
            this.ListGV.RowTemplate.Height = 40;
            this.ListGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListGV.Size = new System.Drawing.Size(1777, 646);
            this.ListGV.TabIndex = 3;
            this.ListGV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.ListGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListGV_CellClick_1);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.txtsearchGV);
            this.bunifuPanel1.Controls.Add(this.btnDSCN);
            this.bunifuPanel1.Controls.Add(this.btnUndo);
            this.bunifuPanel1.Controls.Add(this.lbQLGV);
            this.bunifuPanel1.Controls.Add(this.btnXuatExcel);
            this.bunifuPanel1.Controls.Add(this.btnThem);
            this.bunifuTransition1.SetDecoration(this.bunifuPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1777, 95);
            this.bunifuPanel1.TabIndex = 2;
            // 
            // txtsearchGV
            // 
            this.txtsearchGV.AcceptsReturn = false;
            this.txtsearchGV.AcceptsTab = false;
            this.txtsearchGV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtsearchGV.AnimationSpeed = 200;
            this.txtsearchGV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtsearchGV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtsearchGV.BackColor = System.Drawing.Color.Transparent;
            this.txtsearchGV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtsearchGV.BackgroundImage")));
            this.txtsearchGV.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtsearchGV.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtsearchGV.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtsearchGV.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtsearchGV.BorderRadius = 1;
            this.txtsearchGV.BorderThickness = 1;
            this.txtsearchGV.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtsearchGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txtsearchGV, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txtsearchGV.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtsearchGV.DefaultText = "";
            this.txtsearchGV.FillColor = System.Drawing.Color.White;
            this.txtsearchGV.HideSelection = true;
            this.txtsearchGV.IconLeft = null;
            this.txtsearchGV.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearchGV.IconPadding = 10;
            this.txtsearchGV.IconRight = null;
            this.txtsearchGV.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearchGV.Lines = new string[0];
            this.txtsearchGV.Location = new System.Drawing.Point(1025, 28);
            this.txtsearchGV.MaxLength = 32767;
            this.txtsearchGV.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtsearchGV.Modified = false;
            this.txtsearchGV.Multiline = false;
            this.txtsearchGV.Name = "txtsearchGV";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtsearchGV.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtsearchGV.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtsearchGV.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtsearchGV.OnIdleState = stateProperties4;
            this.txtsearchGV.Padding = new System.Windows.Forms.Padding(3);
            this.txtsearchGV.PasswordChar = '\0';
            this.txtsearchGV.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtsearchGV.PlaceholderText = "Tìm kiếm theo tên";
            this.txtsearchGV.ReadOnly = false;
            this.txtsearchGV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsearchGV.SelectedText = "";
            this.txtsearchGV.SelectionLength = 0;
            this.txtsearchGV.SelectionStart = 0;
            this.txtsearchGV.ShortcutsEnabled = true;
            this.txtsearchGV.Size = new System.Drawing.Size(271, 44);
            this.txtsearchGV.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtsearchGV.TabIndex = 12;
            this.txtsearchGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtsearchGV.TextMarginBottom = 0;
            this.txtsearchGV.TextMarginLeft = 3;
            this.txtsearchGV.TextMarginTop = 0;
            this.txtsearchGV.TextPlaceholder = "Tìm kiếm theo tên";
            this.txtsearchGV.UseSystemPasswordChar = false;
            this.txtsearchGV.WordWrap = true;
            this.txtsearchGV.TextChanged += new System.EventHandler(this.txtsearchGV_TextChanged);
            // 
            // btnDSCN
            // 
            this.btnDSCN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDSCN.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuTransition1.SetDecoration(this.btnDSCN, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnDSCN.FlatAppearance.BorderSize = 0;
            this.btnDSCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSCN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSCN.ForeColor = System.Drawing.Color.White;
            this.btnDSCN.Location = new System.Drawing.Point(1329, 28);
            this.btnDSCN.Margin = new System.Windows.Forms.Padding(0);
            this.btnDSCN.Name = "btnDSCN";
            this.btnDSCN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDSCN.Size = new System.Drawing.Size(135, 39);
            this.btnDSCN.TabIndex = 11;
            this.btnDSCN.Text = "DS Chủ Nhiệm";
            this.btnDSCN.UseVisualStyleBackColor = false;
            this.btnDSCN.Click += new System.EventHandler(this.btnDSCN_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.AllowAnimations = true;
            this.btnUndo.AllowMouseEffects = true;
            this.btnUndo.AllowToggling = false;
            this.btnUndo.AnimationSpeed = 200;
            this.btnUndo.AutoGenerateColors = false;
            this.btnUndo.AutoRoundBorders = false;
            this.btnUndo.AutoSizeLeftIcon = true;
            this.btnUndo.AutoSizeRightIcon = true;
            this.btnUndo.BackColor = System.Drawing.Color.Transparent;
            this.btnUndo.BackColor1 = System.Drawing.SystemColors.Control;
            this.btnUndo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.BackgroundImage")));
            this.btnUndo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUndo.ButtonText = "";
            this.btnUndo.ButtonTextMarginLeft = 0;
            this.btnUndo.ColorContrastOnClick = 45;
            this.btnUndo.ColorContrastOnHover = 45;
            this.btnUndo.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnUndo.CustomizableEdges = borderEdges1;
            this.bunifuTransition1.SetDecoration(this.btnUndo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnUndo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUndo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUndo.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUndo.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUndo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnUndo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUndo.ForeColor = System.Drawing.Color.White;
            this.btnUndo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUndo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnUndo.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnUndo.IconMarginLeft = 11;
            this.btnUndo.IconPadding = 10;
            this.btnUndo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUndo.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnUndo.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnUndo.IconSize = 25;
            this.btnUndo.IdleBorderColor = System.Drawing.Color.SkyBlue;
            this.btnUndo.IdleBorderRadius = 2;
            this.btnUndo.IdleBorderThickness = 2;
            this.btnUndo.IdleFillColor = System.Drawing.SystemColors.Control;
            this.btnUndo.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.IdleIconLeftImage")));
            this.btnUndo.IdleIconRightImage = null;
            this.btnUndo.IndicateFocus = false;
            this.btnUndo.Location = new System.Drawing.Point(255, 23);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUndo.OnDisabledState.BorderRadius = 2;
            this.btnUndo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUndo.OnDisabledState.BorderThickness = 2;
            this.btnUndo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUndo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUndo.OnDisabledState.IconLeftImage = null;
            this.btnUndo.OnDisabledState.IconRightImage = null;
            this.btnUndo.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnUndo.onHoverState.BorderRadius = 2;
            this.btnUndo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUndo.onHoverState.BorderThickness = 2;
            this.btnUndo.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnUndo.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnUndo.onHoverState.IconLeftImage = null;
            this.btnUndo.onHoverState.IconRightImage = null;
            this.btnUndo.OnIdleState.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnUndo.OnIdleState.BorderRadius = 2;
            this.btnUndo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUndo.OnIdleState.BorderThickness = 2;
            this.btnUndo.OnIdleState.FillColor = System.Drawing.SystemColors.Control;
            this.btnUndo.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnUndo.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.OnIdleState.IconLeftImage")));
            this.btnUndo.OnIdleState.IconRightImage = null;
            this.btnUndo.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnUndo.OnPressedState.BorderRadius = 2;
            this.btnUndo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUndo.OnPressedState.BorderThickness = 2;
            this.btnUndo.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnUndo.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnUndo.OnPressedState.IconLeftImage = null;
            this.btnUndo.OnPressedState.IconRightImage = null;
            this.btnUndo.Size = new System.Drawing.Size(54, 44);
            this.btnUndo.TabIndex = 10;
            this.btnUndo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUndo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUndo.TextMarginLeft = 0;
            this.btnUndo.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnUndo.UseDefaultRadiusAndThickness = true;
            this.btnUndo.Visible = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // lbQLGV
            // 
            this.lbQLGV.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbQLGV, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbQLGV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLGV.Location = new System.Drawing.Point(24, 32);
            this.lbQLGV.Name = "lbQLGV";
            this.lbQLGV.Size = new System.Drawing.Size(206, 27);
            this.lbQLGV.TabIndex = 9;
            this.lbQLGV.Text = "Danh sách giáo viên";
            this.lbQLGV.Click += new System.EventHandler(this.lbQLGV_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuTransition1.SetDecoration(this.btnXuatExcel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.Image")));
            this.btnXuatExcel.Location = new System.Drawing.Point(1663, 28);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnXuatExcel.Size = new System.Drawing.Size(58, 39);
            this.btnXuatExcel.TabIndex = 8;
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuTransition1.SetDecoration(this.btnThem, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(1492, 28);
            this.btnThem.Margin = new System.Windows.Forms.Padding(0);
            this.btnThem.Name = "btnThem";
            this.btnThem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnThem.Size = new System.Drawing.Size(135, 39);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // QuanLyGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1777, 830);
            this.Controls.Add(this.ListGV);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "QuanLyGV";
            this.Text = "QuanLyGV";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListGV)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSua;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Button btnThem;
        private Bunifu.UI.WinForms.BunifuDataGridView ListGV;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Label lbQLGV;
        private System.Windows.Forms.Button btnDSCN;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUndo;
        private Bunifu.UI.WinForms.BunifuTextBox txtsearchGV;
    }
}