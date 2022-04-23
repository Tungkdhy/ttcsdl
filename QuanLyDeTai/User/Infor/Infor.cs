﻿using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.User.Infor
{
    public partial class Infor : Form
    {
        public static string maGV;
        public Infor(string MaGv)
        {
            maGV = MaGv;
            InitializeComponent();
            getInfor();
            enable();
        }
        private void getInfor()
        {
            string query = "select * from GV where MaGv='"+maGV+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            hoten.Text = dt.Rows[0][1].ToString().Trim();
            gioitinh.Text = dt.Rows[0][3].ToString().Trim();
            ngaysinh.Text = dt.Rows[0][2].ToString().Split(' ')[0];
            MaBM.Text = dt.Rows[0][7].ToString().Trim();
            MaKhoa.Text = dt.Rows[0][8].ToString().Trim();
            Capbac.Text = dt.Rows[0][4].ToString().Trim();
            chucvu.Text = dt.Rows[0][5].ToString().Trim();

      
            
        }
        private void enable()
        {
            hoten.Enabled = false;
            gioitinh.Enabled=false;
            ngaysinh.Enabled=false;
            chucvu.Enabled=false;
            Capbac.Enabled=false;
            MaBM.Enabled=false;
            MaKhoa.Enabled=false;
            Save.Enabled=false;
            huy.Enabled=false;
        }
        
        private void Infor_Load(object sender, EventArgs e)
        {

        }
  

        private void Edit_Click_1(object sender, EventArgs e)
        {
            chucvu.Enabled = true;
            Capbac.Enabled = true;
            MaBM.Enabled = true;
            Save.Enabled = true;
            huy.Enabled = true;
            chucvu.Focus();
        }

        private void Save_Click_1(object sender, EventArgs e)
        {
         

            string query = "update GV set Capbac =N'" + Capbac.Text + "', Chucvu=N'" + chucvu.Text + "', MABM = '" + MaBM.Text + "' where MaGv='" + maGV + "'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Sửa"));
            enable();
        }

        private void huy_Click_1(object sender, EventArgs e)
        {
            getInfor();
            enable();
        }
    }
}
