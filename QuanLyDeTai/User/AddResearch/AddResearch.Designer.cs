namespace QuanLyDeTai.User.AddResearch
{
    partial class AddResearch
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
            this.label4 = new System.Windows.Forms.Label();
            this.Luong = new System.Windows.Forms.TextBox();
            this.Change = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ten = new System.Windows.Forms.TextBox();
            this.Tuoi = new System.Windows.Forms.TextBox();
            this.MaNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 36);
            this.label4.TabIndex = 23;
            this.label4.Text = "Thêm đề tài";
            // 
            // Luong
            // 
            this.Luong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Luong.Location = new System.Drawing.Point(319, 456);
            this.Luong.Multiline = true;
            this.Luong.Name = "Luong";
            this.Luong.Size = new System.Drawing.Size(303, 39);
            this.Luong.TabIndex = 16;
            this.Luong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Change
            // 
            this.Change.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.Change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Change.FlatAppearance.BorderSize = 0;
            this.Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change.ForeColor = System.Drawing.SystemColors.Control;
            this.Change.Location = new System.Drawing.Point(319, 510);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(137, 46);
            this.Change.TabIndex = 22;
            this.Change.Text = "Đổi mật khẩu";
            this.Change.UseVisualStyleBackColor = false;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(178, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(178, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(185, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // Ten
            // 
            this.Ten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ten.Location = new System.Drawing.Point(319, 290);
            this.Ten.Multiline = true;
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(303, 41);
            this.Ten.TabIndex = 18;
            // 
            // Tuoi
            // 
            this.Tuoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tuoi.BackColor = System.Drawing.SystemColors.Window;
            this.Tuoi.Location = new System.Drawing.Point(319, 373);
            this.Tuoi.Multiline = true;
            this.Tuoi.Name = "Tuoi";
            this.Tuoi.Size = new System.Drawing.Size(303, 38);
            this.Tuoi.TabIndex = 17;
            // 
            // MaNV
            // 
            this.MaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaNV.Location = new System.Drawing.Point(319, 191);
            this.MaNV.Multiline = true;
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(303, 39);
            this.MaNV.TabIndex = 24;
            this.MaNV.TextChanged += new System.EventHandler(this.MaNV_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(185, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Mật khẩu cũ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AddResearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 646);
            this.Controls.Add(this.MaNV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Luong);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ten);
            this.Controls.Add(this.Tuoi);
            this.Name = "AddResearch";
            this.Text = "AddResearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Luong;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ten;
        private System.Windows.Forms.TextBox Tuoi;
        private System.Windows.Forms.TextBox MaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}