using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.PKHCN.HDNT
{
    public partial class ListDT : Form
    {
        private string mahd;
        private string mk;
        public ListDT(string MaHD,string MaKhoa)
        {
            InitializeComponent();
            mahd = MaHD;
            mk = MaKhoa;
            getListDTHD();
            getTenKhoa();
            MHD.Text = MaHD;
            MHD.Enabled = false;
            TenKhoa.Enabled = false;
            getDTKHD();
            TDT.Enabled = false;
        }
        private void getListDTHD()
        {
            string query = "prd_pkhcn_danhsachDT_cuaHD '" + mahd + "'";
            DSDT.DataSource = ConnectDB.Connected.getData(query);
        }
        private void getTenKhoa()
        {
            string query = "pkhcn_lay_ten_khoa '" + mk + "'";
            DataTable dt = ConnectDB.Connected.getData(query);
            TenKhoa.Text = dt.Rows[0][0].ToString();
        }
        private void getDTKHD()
        {
            string query = "getDTKHD";
            DataTable dt = ConnectDB.Connected.getData(query);
            foreach(DataRow dr in dt.Rows)
            {
                selectMDT.Items.Add(dr[0].ToString());
            }
        }

        private void selectMDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "getTenDTbyMADT '"+selectMDT.Text+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            TDT.Text = dt.Rows[0][0].ToString();
        }
    }
}
