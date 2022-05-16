using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.Khoa.QLDT
{
    public partial class ThongTinTV : Form
    {
        private static string MaKhoa = "";
        private static string MaDT = "";
        private static string TenDT = "";
        private static string currentMagv = "";
        private static string State = "";
        private static string vaitro = "";
        private static string currentMCN = "";
        public ThongTinTV(string madt, string tendt, string makhoa)
        {
            MaKhoa = makhoa;
            MaDT = madt;
            TenDT = tendt;
            InitializeComponent();
            fillData_TV();
            getcurrentMaCN();
            setup();
        }
        private void getcurrentMaCN()
        {
            string get_MCN = "proc_khoa_getMCN '" + MaDT + "'";
            currentMCN = ConnectDB.Connected.getData(get_MCN).Rows[0][0].ToString();
        }
        public void setup()
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            cmbMaGV.Enabled = false;
            cmbMaGV.Text = "";
            txtTenGV.Text = "";
        }
        public void fillData_TV()
        {
            txtMaDT.Text = MaDT;
            txtTenDT.Text = TenDT;
            string query = "exec prd_Khoa_XemDSTV_Theo_MaDT '"+MaDT+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            ListTV.DataSource = dt;
        }
        private void FillTenGV()
        {
            string query_getTenGV = "proc_khoa_getTenGV '"+cmbMaGV.Text.Trim()+"'";
            DataTable dt = ConnectDB.Connected.getData(query_getTenGV);
            txtTenGV.Text = dt.Rows[0][0].ToString();

        }
        private void getMaGV_0_TGDT()
        {
            string query_getMaGV_0_TGDT = "proc_khoa_getGVKTGDT '" + MaKhoa + "'";
            DataTable dt = ConnectDB.Connected.getData(query_getMaGV_0_TGDT);
            foreach (DataRow dr in dt.Rows)
            {
                cmbMaGV.Items.Add(dr[0].ToString());
            }
        }

        private void cmbMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTenGV();
            btnLuu.Enabled = true;
            
        }       
        private void btnThem_Click(object sender, EventArgs e)
        {
            State = "add";
            cmbMaGV.Enabled = true;
            getMaGV_0_TGDT();
        }

        private void btnDCN_Click_1(object sender, EventArgs e)
        {
            lbDCN.Visible = true;
            cmbMaGV.Items.Clear();
            State = "dcn";
            cmbMaGV.Enabled = true;
            string query_getMGVTV = "proc_khoa_getMGVTV '" + MaDT + "'";
            DataTable dt = ConnectDB.Connected.getData(query_getMGVTV);
            foreach (DataRow dr in dt.Rows)
            {
                cmbMaGV.Items.Add(dr[0].ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (vaitro == "Chủ nhiệm")
            {
                MessageBox.Show("Không thể xóa chủ nhiệm đề tài");
            }
            else
            {
                State = "xoa";
                string query_XoaTV = "proc_khoa_deleteTV '" + currentMagv + "', '" + MaDT + "'";
                MessageBox.Show(ConnectDB.Connected.ChangeData(query_XoaTV, "Xóa"));
                fillData_TV();
                cmbMaGV.Items.Clear();
                getMaGV_0_TGDT();
            }          
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            try
            {
                switch (State)
                {
                    case "add":
                        string query_themTV = "proc_khoa_insertTV '" + cmbMaGV.Text + "', '" + MaDT + "'";
                        MessageBox.Show(ConnectDB.Connected.ChangeData(query_themTV, "Thêm"));
                        cmbMaGV.Items.Clear();
                        setup();
                        fillData_TV();
                        break;
                    case "dcn":
                        string query_doiCN = "proc_khoa_DoiCN '"+MaDT+"', '"+cmbMaGV.Text.Trim()+"', '"+currentMCN+"'";
                        MessageBox.Show(ConnectDB.Connected.ChangeData(query_doiCN,"Đổi chủ nhiệm"));
                        fillData_TV();
                        setup();
                        break;                  
                }

            }
            catch
            {

            }
        }

        private void ListTV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = ListTV.Rows[index];
                currentMagv = selectedRow.Cells["Mã GV"].Value.ToString();
                vaitro = selectedRow.Cells["Vai trò"].Value.ToString();
                btnXoa.Enabled = true;
            }
            catch
            {

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setup();
        }
    }
}
