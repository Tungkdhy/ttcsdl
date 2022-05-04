using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.Khoa.QLBBKH
{
    public partial class QLBBKhoaHoc : Form
    {
        public static string MaKhoa = "";
        public QLBBKhoaHoc(string makhoa)
        {
            MaKhoa = makhoa;
            InitializeComponent();
            getListBBKH();
        }
        private void getListBBKH()
        {
            string query = "exec pro_Khoa_getAllScientificArtical '"+MaKhoa+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            ListBBKH.DataSource = dt;
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            string query = "";

            if (cmbChuyenNganh.Text == "" && cmbTapChi.Text == "")
            {
                query = "exec pro_Khoa_getAllScientificArtical '" + MaKhoa + "'";

            }
            else if (cmbChuyenNganh.Text != "" && cmbTapChi.Text == "")
            {
                query = "select MABB as 'Mã bài báo', TenBaiBao as 'Tên bài báo', BaiBaoKH.ChuyenNganh as 'Chuyên ngành', BaiBaoKH.NgayDang as 'Ngày đăng', BaiBaoKH.TapChi as 'Tạp chí', BaiBaoKH.MDT as 'Mã đề tài' from BaiBaoKH " +
                    "join DeTaiNCKH on BaiBaoKH.MDT = DeTaiNCKH.MADT where DeTaiNCKH.MABM in " +
                    "(select BOMON.MABM from BOMON left join KHOA on BOMON.MAKHOA = KHOA.MAKHOA where KHOA.MAKHOA= '"+MaKhoa+"') and BaiBaoKH.ChuyenNganh = N'"+cmbChuyenNganh.Text+"'";
            }
            else if (cmbChuyenNganh.Text == "" && cmbTapChi.Text != "")
            {
                query = "select MABB as 'Mã bài báo', TenBaiBao as 'Tên bài báo', BaiBaoKH.ChuyenNganh as 'Chuyên ngành', BaiBaoKH.NgayDang as 'Ngày đăng', BaiBaoKH.TapChi as 'Tạp chí', BaiBaoKH.MDT as 'Mã đề tài' from BaiBaoKH " +
                    "join DeTaiNCKH on BaiBaoKH.MDT = DeTaiNCKH.MADT where DeTaiNCKH.MABM in " +
                    "(select BOMON.MABM from BOMON left join KHOA on BOMON.MAKHOA = KHOA.MAKHOA where KHOA.MAKHOA= '"+MaKhoa+"') and BaiBaoKH.TapChi = N'" + cmbTapChi.Text + "'";
            }
            else
            {
                query = "select MABB as 'Mã bài báo', TenBaiBao as 'Tên bài báo', BaiBaoKH.ChuyenNganh as 'Chuyên ngành', BaiBaoKH.NgayDang as 'Ngày đăng', BaiBaoKH.TapChi as 'Tạp chí', BaiBaoKH.MDT as 'Mã đề tài' from BaiBaoKH " +
                    "join DeTaiNCKH on BaiBaoKH.MDT = DeTaiNCKH.MADT where DeTaiNCKH.MABM in " +
                    "(select BOMON.MABM from BOMON left join KHOA on BOMON.MAKHOA = KHOA.MAKHOA where KHOA.MAKHOA= '"+MaKhoa+"') and BaiBaoKH.ChuyenNganh = N'" + cmbChuyenNganh.Text + "' and BaiBaoKH.TapChi = N'"+cmbTapChi.Text+"'";
            }
            DataTable dt = ConnectDB.Connected.getData(query);
            ListBBKH.DataSource = dt;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            cmbChuyenNganh.Items.Clear();
            cmbTapChi.Items.Clear();
            
            string query_get_cn = "exec proc_Khoa_getChuyenNganhBBKH '"+MaKhoa+"'";
            DataTable dt1 = ConnectDB.Connected.getData(query_get_cn);
            foreach (DataRow dr in dt1.Rows)
            {
                cmbChuyenNganh.Items.Add(dr[0].ToString());
            }
            string query_get_tc = "exec proc_Khoa_getTapChiBBKH '"+MaKhoa+"'";
            DataTable dt2 = ConnectDB.Connected.getData(query_get_tc);
            foreach (DataRow dr in dt2.Rows)
            {
                cmbTapChi.Items.Add(dr[0].ToString());
            }
            
            panelLoc.Visible = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            panelLoc.Visible = false;
        }

        private void searchArt_TextChanged(object sender, EventArgs e)
        {
            string query = "";
            string searchArt = txtsearchArt.Text;
            if (cmbChuyenNganh.Text == "" && cmbTapChi.Text == "")
            {
                query = "exec pro_Khoa_getAllScientificArtical '" + MaKhoa + "'";

            }
            else if (cmbChuyenNganh.Text != "" && cmbTapChi.Text == "")
            {
                query = "select MABB as 'Mã bài báo', TenBaiBao as 'Tên bài báo', BaiBaoKH.ChuyenNganh as 'Chuyên ngành', BaiBaoKH.NgayDang as 'Ngày đăng', BaiBaoKH.TapChi as 'Tạp chí', BaiBaoKH.MDT as 'Mã đề tài' from BaiBaoKH " +
                    "join DeTaiNCKH on BaiBaoKH.MDT = DeTaiNCKH.MADT where DeTaiNCKH.MABM in " +
                    "(select BOMON.MABM from BOMON left join KHOA on BOMON.MAKHOA = KHOA.MAKHOA where KHOA.MAKHOA= '" + MaKhoa + "') and BaiBaoKH.ChuyenNganh = N'" + cmbChuyenNganh.Text + "'";
            }
            else if (cmbChuyenNganh.Text == "" && cmbTapChi.Text != "")
            {
                query = "select MABB as 'Mã bài báo', TenBaiBao as 'Tên bài báo', BaiBaoKH.ChuyenNganh as 'Chuyên ngành', BaiBaoKH.NgayDang as 'Ngày đăng', BaiBaoKH.TapChi as 'Tạp chí', BaiBaoKH.MDT as 'Mã đề tài' from BaiBaoKH " +
                    "join DeTaiNCKH on BaiBaoKH.MDT = DeTaiNCKH.MADT where DeTaiNCKH.MABM in " +
                    "(select BOMON.MABM from BOMON left join KHOA on BOMON.MAKHOA = KHOA.MAKHOA where KHOA.MAKHOA= '" + MaKhoa + "') and BaiBaoKH.TapChi = N'" + cmbTapChi.Text + "'";
            }
            else
            {
                query = "select MABB as 'Mã bài báo', TenBaiBao as 'Tên bài báo', BaiBaoKH.ChuyenNganh as 'Chuyên ngành', BaiBaoKH.NgayDang as 'Ngày đăng', BaiBaoKH.TapChi as 'Tạp chí', BaiBaoKH.MDT as 'Mã đề tài' from BaiBaoKH " +
                    "join DeTaiNCKH on BaiBaoKH.MDT = DeTaiNCKH.MADT where DeTaiNCKH.MABM in " +
                    "(select BOMON.MABM from BOMON left join KHOA on BOMON.MAKHOA = KHOA.MAKHOA where KHOA.MAKHOA= '" + MaKhoa + "') and BaiBaoKH.ChuyenNganh = N'" + cmbChuyenNganh.Text + "' and BaiBaoKH.TapChi = N'" + cmbTapChi.Text + "'";
            }
            try
            {
                DataTable dt = ConnectDB.Connected.getData(query);
                ListBBKH.DataSource = dt;
                var re = from row in dt.AsEnumerable()
                         where row[1].ToString().ToLower().Contains(searchArt.ToLower())
                         select row;
                ListBBKH.DataSource = re.CopyToDataTable();
            }
            catch
            {

            }
        }
    }
}
