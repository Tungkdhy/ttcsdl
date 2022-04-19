namespace QuanLyDeTai.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.DangNhap = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DangNhap
            // 
            this.DangNhap.BackColor = System.Drawing.Color.Tomato;
            this.DangNhap.FlatAppearance.BorderSize = 0;
            this.DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DangNhap.Location = new System.Drawing.Point(655, 374);
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(104, 45);
            this.DangNhap.TabIndex = 0;
            this.DangNhap.Text = "Đăng nhập";
            this.DangNhap.UseVisualStyleBackColor = false;
            this.DangNhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(655, 193);
            this.UserName.Multiline = true;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(238, 45);
            this.UserName.TabIndex = 1;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(655, 287);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(238, 43);
            this.Password.TabIndex = 2;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuLabel5);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuLabel4);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuPictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LimeGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Lime;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Green;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(357, 656);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 84;
            this.bunifuPictureBox1.Image = global::QuanLyDeTai.Properties.Resources.tải_xuống;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(93, 82);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(169, 169);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuLabel1.Location = new System.Drawing.Point(717, 116);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(103, 45);
            this.bunifuLabel1.TabIndex = 4;
            this.bunifuLabel1.Text = "Sign in";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuLabel2.Location = new System.Drawing.Point(538, 203);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(88, 25);
            this.bunifuLabel2.TabIndex = 5;
            this.bunifuLabel2.Text = "UserName";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuLabel3.Location = new System.Drawing.Point(538, 296);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(80, 25);
            this.bunifuLabel3.TabIndex = 6;
            this.bunifuLabel3.Text = "Password";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuLabel4.Location = new System.Drawing.Point(94, 287);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(168, 30);
            this.bunifuLabel4.TabIndex = 1;
            this.bunifuLabel4.Text = "Phần mền quản lý";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuLabel5.Location = new System.Drawing.Point(30, 337);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(312, 30);
            this.bunifuLabel5.TabIndex = 2;
            this.bunifuLabel5.Text = "Đề tài Học Viện Kỹ thuật Quân sự";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1139, 656);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.DangNhap);
            this.Name = "Login";
            this.Text = "Login";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DangNhap;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
    }
}