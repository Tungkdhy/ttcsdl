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
        public static string MaKhoa = "";
        public static string MaDT = "";
        public static string TenDT = "";
        public static string currentMagv = "";
        public ThongTinTV(string madt, string tendt, string makhoa)
        {
            MaKhoa = makhoa;
            MaDT = madt;
            TenDT = tendt;
            InitializeComponent();
            fillData_TV();
            getMaGV_0_TGDT();
        }

        public void fillData_TV()
        {
            txtMaDT.Text = MaDT;
            txtTenDT.Text = TenDT;
            string query = "exec prd_Khoa_XemDSTV_Theo_MaDT '"+MaDT+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            listTV.DataSource = dt;
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
        private void listTV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void cmbMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTenGV();
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
           
            string query_themTV = "proc_khoa_insertTV '"+cmbMaGV.Text+"', '"+txtMaDT.Text+"'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query_themTV,"Thêm"));
            cmbMaGV.Items.Clear();
            cmbMaGV.Text = "";
            getMaGV_0_TGDT();
            fillData_TV();
            txtTenGV.Text = "";

        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            string query_XoaTV = "proc_khoa_deleteTV '"+currentMagv+"', '"+txtMaDT.Text+"'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query_XoaTV, "Xóa"));
            fillData_TV();
            cmbMaGV.Items.Clear();
            getMaGV_0_TGDT();
        }

        private void listTV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = listTV.Rows[index];
                currentMagv = selectedRow.Cells["Mã GV"].Value.ToString();
                MessageBox.Show(currentMagv);
            }
            catch
            {

            }
        }
    }
}
