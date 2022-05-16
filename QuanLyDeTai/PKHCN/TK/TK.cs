using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.PKHCN.TK
{
    public partial class TK : Form
    {
        public TK()
        {
            InitializeComponent();
            getYearDT();
            getYearBB();
            TKAllBB();
            TKAllDT();
        }
        private void getYearDT()
        {
            yearDT.Items.Clear();
            yearDT.Items.Add("All");
            string query = "getYearDT";
            DataTable year = ConnectDB.Connected.getData(query);
            foreach(DataRow row in year.Rows)
            {
                yearDT.Items.Add(row[0]);

            }
        }
        private void getYearBB()
        {
            yearBB.Items.Clear();
            yearBB.Items.Add("All");
            string query = "getYearBB";
            DataTable year = ConnectDB.Connected.getData(query);
            foreach(DataRow row in year.Rows)
            {
                yearBB.Items.Add(row[0]);  
            }
        }
        private void TKAllDT()
        {
            string query = "pro_pnckh_thongke_slgdt_khoa";
            DataTable dt = ConnectDB.Connected.getData(query);
            Tkdt.DataSource = dt;
            chartDT.DataSource = dt;
            chartDT.Series["Series1"].XValueMember = "Tên khoa";
            chartDT.Series["Series1"].YValueMembers = "Số lượng đề tài";
            chartDT.Titles.Add("TKDT");
            yearDT.Text = "All";
        }
        private void TKAllBB()
        {
            string query = "prd_pkhcn_thongkeBBtheoKhoa";
            DataTable dt = ConnectDB.Connected.getData(query);
            tkBB.DataSource = dt;
            chartBB.DataSource = dt;
            chartBB.Series["Series2"].XValueMember = "TenKhoa";
            chartBB.Series["Series2"].YValueMembers = "SLBB";
            chartBB.Titles.Add("TKBB");
            yearBB.Text = "All";

        }
        private void yearDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartDT.Titles.Clear();
            if (yearDT.Text == "All")
            {
                string query = "pro_pnckh_thongke_slgdt_khoa";
                DataTable dt = ConnectDB.Connected.getData(query);
                Tkdt.DataSource = dt;
                chartDT.DataSource = dt;
                chartDT.Series["Series1"].XValueMember = "Tên khoa";
                chartDT.Series["Series1"].YValueMembers = "Số lượng đề tài";
                chartDT.Titles.Add("TKDT");

            }
            else
            {
                string query = "pro_pnckh_thongke_slgdt_khoa_theo_nam '"+ yearDT.Text + "'";
                DataTable dt = ConnectDB.Connected.getData(query);
                Tkdt.DataSource = dt;
                chartDT.DataSource = dt;
                chartDT.Series["Series1"].XValueMember = "Tên khoa";
                chartDT.Series["Series1"].YValueMembers = "Số lượng đề tài";
                chartDT.Titles.Add("TKDT");
            }
        }

        private void yearBB_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartBB.Titles.Clear();
            if(yearBB.Text == "All")
            {

                string query = "prd_pkhcn_thongkeBBtheoKhoa";
                DataTable dt = ConnectDB.Connected.getData(query);
                tkBB.DataSource = dt;
                chartBB.DataSource = dt;
                chartBB.Series["Series2"].XValueMember = "TenKhoa";
                chartBB.Series["Series2"].YValueMembers = "SLBB";
                chartBB.Titles.Add("TKBB");

            }
            else
            {
                string query = "prd_pkhcn_thongkeBBtheoKhoa_nam "+yearBB.Text+"";
                DataTable dt = ConnectDB.Connected.getData(query);
                tkBB.DataSource = dt;
                chartBB.DataSource = dt;
                chartBB.Series["Series2"].XValueMember = "TenKhoa";
                chartBB.Series["Series2"].YValueMembers = "SLBB";
                chartBB.Titles.Add("TKBB");
            }
        }
    }
}
