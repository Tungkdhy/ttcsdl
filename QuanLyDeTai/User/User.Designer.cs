namespace QuanLyDeTai.User
{
    partial class User
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dangky = new System.Windows.Forms.Button();
            this.SubMenu = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Button();
            this.ChangePassword = new System.Windows.Forms.Button();
            this.Setting = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Infor = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SubMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.Dangky);
            this.panel1.Controls.Add(this.SubMenu);
            this.panel1.Controls.Add(this.Setting);
            this.panel1.Controls.Add(this.New);
            this.panel1.Controls.Add(this.Infor);
            this.panel1.Controls.Add(this.List);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 788);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Dangky
            // 
            this.Dangky.FlatAppearance.BorderSize = 0;
            this.Dangky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dangky.ForeColor = System.Drawing.SystemColors.Control;
            this.Dangky.Location = new System.Drawing.Point(2, 276);
            this.Dangky.Name = "Dangky";
            this.Dangky.Size = new System.Drawing.Size(200, 48);
            this.Dangky.TabIndex = 5;
            this.Dangky.Text = "Đăng ký đề tài";
            this.Dangky.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dangky.UseVisualStyleBackColor = true;
            this.Dangky.Click += new System.EventHandler(this.Dangky_Click);
            // 
            // SubMenu
            // 
            this.SubMenu.BackColor = System.Drawing.Color.DarkGreen;
            this.SubMenu.Controls.Add(this.LogOut);
            this.SubMenu.Controls.Add(this.ChangePassword);
            this.SubMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.SubMenu.Location = new System.Drawing.Point(5, 376);
            this.SubMenu.Name = "SubMenu";
            this.SubMenu.Size = new System.Drawing.Size(200, 80);
            this.SubMenu.TabIndex = 2;
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.DarkGreen;
            this.LogOut.FlatAppearance.BorderSize = 0;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Location = new System.Drawing.Point(0, 40);
            this.LogOut.Name = "LogOut";
            this.LogOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LogOut.Size = new System.Drawing.Size(200, 40);
            this.LogOut.TabIndex = 1;
            this.LogOut.Text = "Đăng xuất";
            this.LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // ChangePassword
            // 
            this.ChangePassword.BackColor = System.Drawing.Color.DarkGreen;
            this.ChangePassword.FlatAppearance.BorderSize = 0;
            this.ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePassword.Location = new System.Drawing.Point(0, 0);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ChangePassword.Size = new System.Drawing.Size(200, 40);
            this.ChangePassword.TabIndex = 0;
            this.ChangePassword.Text = "Đổi mật khẩu";
            this.ChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangePassword.UseVisualStyleBackColor = false;
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // Setting
            // 
            this.Setting.BackColor = System.Drawing.Color.Green;
            this.Setting.FlatAppearance.BorderSize = 0;
            this.Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Setting.ForeColor = System.Drawing.Color.Gainsboro;
            this.Setting.Location = new System.Drawing.Point(3, 328);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(200, 48);
            this.Setting.TabIndex = 1;
            this.Setting.Text = "Cài đặt";
            this.Setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Setting.UseVisualStyleBackColor = false;
            this.Setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // New
            // 
            this.New.BackColor = System.Drawing.Color.Green;
            this.New.FlatAppearance.BorderSize = 0;
            this.New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New.ForeColor = System.Drawing.SystemColors.Control;
            this.New.Location = new System.Drawing.Point(5, 222);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(200, 48);
            this.New.TabIndex = 3;
            this.New.Text = "Bài báo khoa học";
            this.New.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.New.UseVisualStyleBackColor = false;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Infor
            // 
            this.Infor.FlatAppearance.BorderSize = 0;
            this.Infor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Infor.ForeColor = System.Drawing.SystemColors.Control;
            this.Infor.Location = new System.Drawing.Point(2, 114);
            this.Infor.Name = "Infor";
            this.Infor.Size = new System.Drawing.Size(200, 48);
            this.Infor.TabIndex = 3;
            this.Infor.Text = "Thông tin nhân viên";
            this.Infor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Infor.UseVisualStyleBackColor = true;
            this.Infor.Click += new System.EventHandler(this.Infor_Click);
            // 
            // List
            // 
            this.List.BackColor = System.Drawing.Color.Green;
            this.List.FlatAppearance.BorderSize = 0;
            this.List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.List.ForeColor = System.Drawing.SystemColors.Control;
            this.List.Location = new System.Drawing.Point(2, 168);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(200, 48);
            this.List.TabIndex = 4;
            this.List.Text = "Danh sách đề tài tham gia";
            this.List.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.List.UseVisualStyleBackColor = false;
            this.List.Click += new System.EventHandler(this.List_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 85);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::QuanLyDeTai.Properties.Resources.tải_xuống;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleGreen;
            this.panel4.Controls.Add(this.header);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(208, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1151, 86);
            this.panel4.TabIndex = 1;
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(263, 30);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(684, 31);
            this.header.TabIndex = 0;
            this.header.Text = "Chương trình quản lý đề tài Học viện Kỹ thuật Quân sự";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.LightGreen;
            this.panelChildForm.Controls.Add(this.panel3);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(208, 86);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1151, 702);
            this.panelChildForm.TabIndex = 2;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 629);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1151, 73);
            this.panel3.TabIndex = 0;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1359, 788);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "User";
            this.Text = "User";
            this.panel1.ResumeLayout(false);
            this.SubMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SubMenu;
        private System.Windows.Forms.Button Setting;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button List;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button ChangePassword;
        private System.Windows.Forms.Button Infor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button Dangky;
    }
}