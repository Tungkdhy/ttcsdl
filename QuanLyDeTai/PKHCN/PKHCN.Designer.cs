namespace QuanLyDeTai.PKHCN
{
    partial class PKHCN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PKHCN));
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubMenu = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.btnTk = new System.Windows.Forms.Button();
            this.btnAddTK = new System.Windows.Forms.Button();
            this.btnHd = new System.Windows.Forms.Button();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.btnQdt = new System.Windows.Forms.Button();
            this.btnlogoInicio = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide;
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
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(209, 672);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 35);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.btnMenu);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.lblcorreo);
            this.MenuVertical.Controls.Add(this.lbluser);
            this.MenuVertical.Controls.Add(this.pictureBox2);
            this.MenuVertical.Controls.Add(this.lblusuario);
            this.MenuVertical.Controls.Add(this.btnTk);
            this.MenuVertical.Controls.Add(this.btnAddTK);
            this.MenuVertical.Controls.Add(this.btnHd);
            this.MenuVertical.Controls.Add(this.btnKhoa);
            this.MenuVertical.Controls.Add(this.btnQdt);
            this.MenuVertical.Controls.Add(this.btnlogoInicio);
            this.bunifuTransition1.SetDecoration(this.MenuVertical, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 719);
            this.MenuVertical.TabIndex = 3;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SubMenu);
            this.panel1.Controls.Add(this.btnSetting);
            this.bunifuTransition1.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 150);
            this.panel1.TabIndex = 22;
            // 
            // SubMenu
            // 
            this.SubMenu.Controls.Add(this.button7);
            this.SubMenu.Controls.Add(this.button8);
            this.bunifuTransition1.SetDecoration(this.SubMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.SubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenu.Location = new System.Drawing.Point(0, 50);
            this.SubMenu.Name = "SubMenu";
            this.SubMenu.Size = new System.Drawing.Size(250, 100);
            this.SubMenu.TabIndex = 21;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(190)))));
            this.bunifuTransition1.SetDecoration(this.button7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 50);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(250, 50);
            this.button7.TabIndex = 19;
            this.button7.Text = "Đăng xuất";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(190)))));
            this.bunifuTransition1.SetDecoration(this.button8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(250, 50);
            this.button8.TabIndex = 20;
            this.button8.Text = "Đổi mật khẩu";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // btnSetting
            // 
            this.bunifuTransition1.SetDecoration(this.btnSetting, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(250, 50);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Text = "                 Cài đặt";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // lblcorreo
            // 
            this.lblcorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblcorreo.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblcorreo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblcorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorreo.ForeColor = System.Drawing.Color.White;
            this.lblcorreo.Location = new System.Drawing.Point(72, 700);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(53, 17);
            this.lblcorreo.TabIndex = 17;
            this.lblcorreo.Text = "Correo";
            // 
            // lbluser
            // 
            this.lbluser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbluser.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbluser, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbluser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.White;
            this.lbluser.Location = new System.Drawing.Point(72, 682);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(54, 17);
            this.lbluser.TabIndex = 16;
            this.lbluser.Text = "Usuario";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuTransition1.SetDecoration(this.pictureBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureBox2.Image = global::QuanLyDeTai.Properties.Resources.tải_xuống;
            this.pictureBox2.Location = new System.Drawing.Point(1, 649);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // lblusuario
            // 
            this.lblusuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblusuario.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblusuario, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblusuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(72, 665);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(50, 17);
            this.lblusuario.TabIndex = 14;
            this.lblusuario.Text = "Cargo";
            // 
            // btnTk
            // 
            this.bunifuTransition1.SetDecoration(this.btnTk, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnTk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTk.FlatAppearance.BorderSize = 0;
            this.btnTk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTk.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTk.ForeColor = System.Drawing.Color.White;
            this.btnTk.Image = ((System.Drawing.Image)(resources.GetObject("btnTk.Image")));
            this.btnTk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTk.Location = new System.Drawing.Point(0, 320);
            this.btnTk.Name = "btnTk";
            this.btnTk.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTk.Size = new System.Drawing.Size(250, 50);
            this.btnTk.TabIndex = 5;
            this.btnTk.Text = "                 Thống kê";
            this.btnTk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTk.UseVisualStyleBackColor = true;
            this.btnTk.Click += new System.EventHandler(this.btnTk_Click);
            // 
            // btnAddTK
            // 
            this.bunifuTransition1.SetDecoration(this.btnAddTK, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnAddTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddTK.FlatAppearance.BorderSize = 0;
            this.btnAddTK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAddTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTK.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTK.ForeColor = System.Drawing.Color.White;
            this.btnAddTK.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTK.Image")));
            this.btnAddTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTK.Location = new System.Drawing.Point(0, 270);
            this.btnAddTK.Name = "btnAddTK";
            this.btnAddTK.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddTK.Size = new System.Drawing.Size(250, 50);
            this.btnAddTK.TabIndex = 4;
            this.btnAddTK.Text = "     Thêm tài khoản";
            this.btnAddTK.UseVisualStyleBackColor = true;
            this.btnAddTK.Click += new System.EventHandler(this.btnAddTK_Click);
            // 
            // btnHd
            // 
            this.bunifuTransition1.SetDecoration(this.btnHd, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnHd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHd.FlatAppearance.BorderSize = 0;
            this.btnHd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnHd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHd.ForeColor = System.Drawing.Color.White;
            this.btnHd.Image = ((System.Drawing.Image)(resources.GetObject("btnHd.Image")));
            this.btnHd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHd.Location = new System.Drawing.Point(0, 220);
            this.btnHd.Name = "btnHd";
            this.btnHd.Size = new System.Drawing.Size(250, 50);
            this.btnHd.TabIndex = 3;
            this.btnHd.Text = "               Hội đồng nghiệm thu";
            this.btnHd.UseVisualStyleBackColor = true;
            // 
            // btnKhoa
            // 
            this.bunifuTransition1.SetDecoration(this.btnKhoa, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhoa.FlatAppearance.BorderSize = 0;
            this.btnKhoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoa.ForeColor = System.Drawing.Color.White;
            this.btnKhoa.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoa.Image")));
            this.btnKhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoa.Location = new System.Drawing.Point(0, 170);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnKhoa.Size = new System.Drawing.Size(250, 50);
            this.btnKhoa.TabIndex = 2;
            this.btnKhoa.Text = "      Danh sách khoa";
            this.btnKhoa.UseVisualStyleBackColor = true;
            // 
            // btnQdt
            // 
            this.bunifuTransition1.SetDecoration(this.btnQdt, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnQdt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQdt.FlatAppearance.BorderSize = 0;
            this.btnQdt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnQdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQdt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQdt.ForeColor = System.Drawing.Color.White;
            this.btnQdt.Image = ((System.Drawing.Image)(resources.GetObject("btnQdt.Image")));
            this.btnQdt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQdt.Location = new System.Drawing.Point(0, 120);
            this.btnQdt.Name = "btnQdt";
            this.btnQdt.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQdt.Size = new System.Drawing.Size(250, 50);
            this.btnQdt.TabIndex = 1;
            this.btnQdt.Text = "       Danh sách đề tài";
            this.btnQdt.UseVisualStyleBackColor = true;
            this.btnQdt.Click += new System.EventHandler(this.btnQdt_Click);
            // 
            // btnlogoInicio
            // 
            this.btnlogoInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnlogoInicio, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnlogoInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnlogoInicio.Image = global::QuanLyDeTai.Properties.Resources._1;
            this.btnlogoInicio.Location = new System.Drawing.Point(0, 0);
            this.btnlogoInicio.Name = "btnlogoInicio";
            this.btnlogoInicio.Size = new System.Drawing.Size(250, 120);
            this.btnlogoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnlogoInicio.TabIndex = 0;
            this.btnlogoInicio.TabStop = false;
            // 
            // panelChildForm
            // 
            this.bunifuTransition1.SetDecoration(this.panelChildForm, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1180, 719);
            this.panelChildForm.TabIndex = 4;
            // 
            // PKHCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1430, 719);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.MenuVertical);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PKHCN";
            this.Text = "PKHCN";
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.SubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SubMenu;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Button btnTk;
        private System.Windows.Forms.Button btnAddTK;
        private System.Windows.Forms.Button btnHd;
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.Button btnQdt;
        private System.Windows.Forms.PictureBox btnlogoInicio;
        private System.Windows.Forms.Panel panelChildForm;
    }
}