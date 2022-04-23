namespace QuanLyDeTai.User.New
{
    partial class New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxDetail = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textbox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.no = new Bunifu.UI.WinForms.BunifuLabel();
            this.add = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.CausesValidation = false;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "ChuyenNganh",
            "TapChi"});
            this.comboBox1.Location = new System.Drawing.Point(56, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Lựa chọn";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxDetail
            // 
            this.comboBoxDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDetail.FormattingEnabled = true;
            this.comboBoxDetail.Location = new System.Drawing.Point(211, 51);
            this.comboBoxDetail.Name = "comboBoxDetail";
            this.comboBoxDetail.Size = new System.Drawing.Size(140, 28);
            this.comboBoxDetail.TabIndex = 2;
            this.comboBoxDetail.SelectedIndexChanged += new System.EventHandler(this.comboBoxDetail_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lọc";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textbox1
            // 
            this.textbox1.AcceptsReturn = false;
            this.textbox1.AcceptsTab = false;
            this.textbox1.AnimationSpeed = 200;
            this.textbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textbox1.BackColor = System.Drawing.Color.Transparent;
            this.textbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textbox1.BackgroundImage")));
            this.textbox1.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.textbox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textbox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.textbox1.BorderColorIdle = System.Drawing.Color.Silver;
            this.textbox1.BorderRadius = 1;
            this.textbox1.BorderThickness = 1;
            this.textbox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox1.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textbox1.DefaultText = "";
            this.textbox1.FillColor = System.Drawing.Color.White;
            this.textbox1.HideSelection = true;
            this.textbox1.IconLeft = null;
            this.textbox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox1.IconPadding = 10;
            this.textbox1.IconRight = null;
            this.textbox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox1.Lines = new string[0];
            this.textbox1.Location = new System.Drawing.Point(392, 44);
            this.textbox1.MaxLength = 32767;
            this.textbox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.textbox1.Modified = false;
            this.textbox1.Multiline = false;
            this.textbox1.Name = "textbox1";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textbox1.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textbox1.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textbox1.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textbox1.OnIdleState = stateProperties4;
            this.textbox1.Padding = new System.Windows.Forms.Padding(3);
            this.textbox1.PasswordChar = '\0';
            this.textbox1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.textbox1.PlaceholderText = "Tìm kiếm theo tên bài báo";
            this.textbox1.ReadOnly = false;
            this.textbox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox1.SelectedText = "";
            this.textbox1.SelectionLength = 0;
            this.textbox1.SelectionStart = 0;
            this.textbox1.ShortcutsEnabled = true;
            this.textbox1.Size = new System.Drawing.Size(260, 37);
            this.textbox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.textbox1.TabIndex = 11;
            this.textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox1.TextMarginBottom = 0;
            this.textbox1.TextMarginLeft = 3;
            this.textbox1.TextMarginTop = 0;
            this.textbox1.TextPlaceholder = "Tìm kiếm theo tên bài báo";
            this.textbox1.UseSystemPasswordChar = false;
            this.textbox1.WordWrap = true;
            this.textbox1.TextChanged += new System.EventHandler(this.textbox1_TextChanged_2);
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView1.ColumnHeadersHeight = 40;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(12, 174);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(891, 280);
            this.bunifuDataGridView1.TabIndex = 12;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel1.Location = new System.Drawing.Point(392, 268);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(52, 15);
            this.bunifuLabel1.TabIndex = 13;
            this.bunifuLabel1.Text = "Loading...";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(262, 370);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(334, 10);
            this.progressBar1.TabIndex = 14;
            // 
            // no
            // 
            this.no.AllowParentOverrides = false;
            this.no.AutoEllipsis = false;
            this.no.CursorType = null;
            this.no.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.Location = new System.Drawing.Point(375, 192);
            this.no.Name = "no";
            this.no.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.no.Size = new System.Drawing.Size(81, 25);
            this.no.TabIndex = 15;
            this.no.Text = "No Result";
            this.no.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.no.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // add
            // 
            this.add.AllowAnimations = true;
            this.add.AllowMouseEffects = true;
            this.add.AllowToggling = false;
            this.add.AnimationSpeed = 200;
            this.add.AutoGenerateColors = false;
            this.add.AutoRoundBorders = false;
            this.add.AutoSizeLeftIcon = true;
            this.add.AutoSizeRightIcon = true;
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.BackColor1 = System.Drawing.Color.LimeGreen;
            this.add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add.BackgroundImage")));
            this.add.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.add.ButtonText = "Them";
            this.add.ButtonTextMarginLeft = 0;
            this.add.ColorContrastOnClick = 45;
            this.add.ColorContrastOnHover = 45;
            this.add.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.add.CustomizableEdges = borderEdges1;
            this.add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.add.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.add.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.add.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.IconLeftAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.add.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.add.IconMarginLeft = 11;
            this.add.IconPadding = 10;
            this.add.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.add.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.add.IconSize = 25;
            this.add.IdleBorderColor = System.Drawing.Color.LimeGreen;
            this.add.IdleBorderRadius = 8;
            this.add.IdleBorderThickness = 1;
            this.add.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.add.IdleIconLeftImage = null;
            this.add.IdleIconRightImage = null;
            this.add.IndicateFocus = false;
            this.add.Location = new System.Drawing.Point(711, 44);
            this.add.Name = "add";
            this.add.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.add.OnDisabledState.BorderRadius = 8;
            this.add.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.add.OnDisabledState.BorderThickness = 1;
            this.add.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.add.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.add.OnDisabledState.IconLeftImage = null;
            this.add.OnDisabledState.IconRightImage = null;
            this.add.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.add.onHoverState.BorderRadius = 8;
            this.add.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.add.onHoverState.BorderThickness = 1;
            this.add.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.add.onHoverState.ForeColor = System.Drawing.Color.White;
            this.add.onHoverState.IconLeftImage = null;
            this.add.onHoverState.IconRightImage = null;
            this.add.OnIdleState.BorderColor = System.Drawing.Color.LimeGreen;
            this.add.OnIdleState.BorderRadius = 8;
            this.add.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.add.OnIdleState.BorderThickness = 1;
            this.add.OnIdleState.FillColor = System.Drawing.Color.LimeGreen;
            this.add.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.add.OnIdleState.IconLeftImage = null;
            this.add.OnIdleState.IconRightImage = null;
            this.add.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.add.OnPressedState.BorderRadius = 8;
            this.add.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.add.OnPressedState.BorderThickness = 1;
            this.add.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.add.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.add.OnPressedState.IconLeftImage = null;
            this.add.OnPressedState.IconRightImage = null;
            this.add.Size = new System.Drawing.Size(121, 39);
            this.add.TabIndex = 16;
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.add.TextMarginLeft = 0;
            this.add.TextPadding = new System.Windows.Forms.Padding(0);
            this.add.UseDefaultRadiusAndThickness = true;
            this.add.Click += new System.EventHandler(this.add_Click_1);
            // 
            // New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.add);
            this.Controls.Add(this.no);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuDataGridView1);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDetail);
            this.Controls.Add(this.comboBox1);
            this.Name = "New";
            this.Text = "New";
            this.Load += new System.EventHandler(this.New_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuTextBox textbox1;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Bunifu.UI.WinForms.BunifuLabel no;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton add;
    }
}