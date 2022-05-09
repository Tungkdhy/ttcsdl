﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.Khoa
{
    public partial class Khoa : Form
    {
        public static string MaKhoa = "";
        public Khoa(string makhoa)
        {
            MaKhoa = makhoa;
            InitializeComponent();
            getTenKhoa();
            customiDegsin();
        }

        private void customiDegsin()
        {
            SubMenu.Visible = false;

        }
        private void hideSubMenu()
        {
            if (SubMenu.Visible == true)
            {
                SubMenu.Visible = false;
            }
        }
        private void showSubMenu(Panel Menu)
        {
            if (Menu.Visible == false)
            {
                hideSubMenu();
                Menu.Visible = true;
            }
            else
            {
                Menu.Visible = false;
            }
        }
        private Form activeForm = null;
        private void openChilForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            contentpanel.Controls.Add(childForm);
            contentpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void astMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Visible = false;
                MenuVertical.Width = 70;
                btnQLGV.Text = "";
                btnTK.Text = "";
                btnQLBBKH.Text = "";
                btnSetting.Text = "";
                btnQLDT.Text = "";
                bunifuTransition1.ShowSync(MenuVertical);
            }
            else
            {
                MenuVertical.Visible = false;
                MenuVertical.Width = 250;
                btnQLGV.Text = "       Quản lý giáo viên";
                btnSetting.Text = "       Cài đặt";
                btnQLDT.Text = "       Quản lý đề tài đề tài";
                btnQLBBKH.Text = "       Scientific artical management";
                btnTK.Text = "       Thống kê";
                bunifuTransition1.ShowSync(MenuVertical);
            }
        }

        private void btnQLDT_Click_1(object sender, EventArgs e)
        {
            Form qldt = new QLDT.QuanLyDeTai(MaKhoa);
            openChilForm(qldt);
        }

        private void btnQLGV_Click_1(object sender, EventArgs e)
        {
            Form qlgv = new QuanLyGV(MaKhoa);
            openChilForm(qlgv);
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            Form tk = new TK.ThongKe(MaKhoa);
            openChilForm(tk);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            showSubMenu(SubMenu);
        }

        private void btnQLBBKH_Click(object sender, EventArgs e)
        {
            Form bbkh = new QLBBKH.QLBBKhoaHoc(MaKhoa);
            openChilForm(bbkh);
        }

        private void btnDMK_Click(object sender, EventArgs e)
        {
            openChilForm(new User.Setting.ChangePassword(MaKhoa));
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            Form login = new Login.Login();
            this.Hide();
            login.Show();
        }

        private void Khoa_Load(object sender, EventArgs e)
        {

        }
        public void getTenKhoa()
        {
            string query = "prd_khoa_getTenkhoa '" + MaKhoa + "'";
            DataTable dt = ConnectDB.Connected.getData(query);
            lbTenKhoa.Text = "Khoa " + dt.Rows[0][0].ToString();
        }
    }
}
