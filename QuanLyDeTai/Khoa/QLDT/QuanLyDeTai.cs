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
    public partial class QuanLyDeTai : Form
    {
        public static string MaKhoa = "";
        public static List<string> inforDT = new List<string>();
        public static string state = "";
        public QuanLyDeTai(string makhoa)
        {
            MaKhoa = makhoa;
            InitializeComponent();
            getListDT();
        }

        private void QuanLyDeTai_Load(object sender, EventArgs e)
        {

        }
        public void getListDT()
        {
            string query = "exec prd_khoa_getAllResearch '"+MaKhoa+"'";
            DataTable dt = ConnectDB.Connected.getData(query);

            ListDT.DataSource = dt;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            cmbCap.Items.Clear();
            cmbBOMON.Items.Clear();
            cmbTrangThai.Items.Clear();
            string query1 = "select distinct(Cap) from DeTaiNCKH, BOMON where DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '"+MaKhoa+"'";
            DataTable dt1 = ConnectDB.Connected.getData(query1);
            foreach (DataRow dr in dt1.Rows)
            {
                cmbCap.Items.Add(dr[0].ToString());          
            }
            string query2 = "select distinct(BOMON.TenBM) from DeTaiNCKH, BOMON where DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "'";
            DataTable dt2 = ConnectDB.Connected.getData(query2);
            foreach (DataRow dr in dt2.Rows)
            {
                cmbBOMON.Items.Add(dr[0].ToString());
            }
            string query3 = "select distinct(TrangThai) from DeTaiNCKH, BOMON where DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "'";
            DataTable dt3 = ConnectDB.Connected.getData(query3);
            foreach (DataRow dr in dt3.Rows)
            {
                cmbTrangThai.Items.Add(dr[0].ToString());
            }
            panelLoc.Visible = true;
        }
        private void cmbCap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBOMON_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string query = "";
            //query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "' and  BOMON.TenBM = N'" + cmbBOMON.Text + "')";

            //if (cmbCap.Text != "" && cmbTrangThai.Text == "")
            //{
            //    query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "') and (DeTaiNCKH.Cap = N'" + cmbCap.Text + "'and BOMON.TenBM = N'" + cmbBOMON.Text + "')";

            //}
            //else if (cmbCap.Text == "" && cmbTrangThai.Text != "")
            //{
            //    query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "') and (BOMON.TenBM = N'" + cmbBOMON.Text + "' and DeTaiNCKH.TrangThai = N'" + cmbTrangThai.Text.Trim() + "')";
            //}
            //else if (cmbCap.Text != "" && cmbTrangThai.Text != "")
            //{
            //    query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "') and DeTaiNCKH.TrangThai = N'" + cmbTrangThai.Text.Trim() + "' and (BOMON.TenBM = N'" + cmbBOMON.Text + "' and DeTaiNCKH.Cap = N'" + cmbCap.Text + "')";
            //}
            //DataTable dt = ConnectDB.Connected.getData(query);
            //ListDT.DataSource = dt;
        }

        private void cmbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string query = "";
            //query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "' and  DeTaiNCKH.TrangThai = N'" + cmbTrangThai.Text.Trim() + "')";

            //if (cmbCap.Text != "" && cmbBOMON.Text == "")
            //{
            //    query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "') and (DeTaiNCKH.Cap = N'" + cmbCap.Text + "' and DeTaiNCKH.TrangThai = N'" + cmbTrangThai.Text.Trim() + "')";

            //}
            //else if (cmbCap.Text == "" && cmbBOMON.Text != "")
            //{
            //    query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "') and (BOMON.TenBM = N'" + cmbBOMON.Text + "' and DeTaiNCKH.TrangThai = N'" + cmbTrangThai.Text.Trim() + "')";

            //}
            //else if (cmbCap.Text != "" && cmbTrangThai.Text != "")
            //{
            //    query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "') and DeTaiNCKH.TrangThai = N'" + cmbTrangThai.Text.Trim() + "' and (BOMON.TenBM = N'" + cmbBOMON.Text + "' and DeTaiNCKH.Cap = N'" + cmbCap.Text + "')";
            //}
            //DataTable dt = ConnectDB.Connected.getData(query);
            //ListDT.DataSource = dt;
        }

        private void ListDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bunifuTransition1.ShowSync(footerpanel);
            int index = e.RowIndex;
            DataGridViewRow selectedRow = ListDT.Rows[index];
            string MADT = selectedRow.Cells["MADT"].Value.ToString();
            string TenDT = selectedRow.Cells["TenDT"].Value.ToString();
            string ChuyenNganh = selectedRow.Cells["ChuyenNganh"].Value.ToString().Split()[0];
            string Cap = selectedRow.Cells["Cap"].Value.ToString();
            string SQDThanhLap = selectedRow.Cells["SQDThanhLap"].Value.ToString();
            string NgayBD = selectedRow.Cells["NgayBD"].Value.ToString();
            string NgayNT = selectedRow.Cells["NgayNT"].Value.ToString();
            string TrangThai = selectedRow.Cells["TrangThai"].Value.ToString();
            string LoaiSP = selectedRow.Cells["LoaiSP"].Value.ToString();
            string TenBM = selectedRow.Cells["TenBM"].Value.ToString();
            string TienDo = selectedRow.Cells["TienDo"].Value.ToString();
            string[] dataGT = { MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, TenBM, TienDo };
            inforDT.Clear();
            inforDT.AddRange(dataGT);
        }

        private void btnSuaDT_Click(object sender, EventArgs e)
        {
            state = "update";
            Form function = new QLDT.modalDT(inforDT, state,MaKhoa);
            function.ShowDialog();
            getListDT();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            state = "add";
            List<string> empty = new List<string>() { };
            
            Form function = new QLDT.modalDT(empty, state, MaKhoa);
            function.ShowDialog();
            getListDT();
        }

        private void btnXoaDT_Click(object sender, EventArgs e)
        {
            string query = "exec prd_khoa_deleteGV '" + inforDT[0] + "'";
            DialogResult dr = MessageBox.Show("Delete đề tài " + inforDT[1].Trim() + "", "Are you sure for", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show(ConnectDB.Connected.ChangeData(query, "xóa"));
            }
            else
            {

            }

            getListDT();
        }

        private void ListDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            string query = "";
            
            if (cmbCap.Text == "" && cmbBOMON.Text == "" && cmbTrangThai.Text == "")
            {
                query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "'";

            }
            else if (cmbCap.Text == "" && cmbBOMON.Text == "" && cmbTrangThai.Text != "")
            {
                query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "') and  DeTaiNCKH.TrangThai = N'" + cmbTrangThai.Text.Trim() + "'";
            }
            else if (cmbCap.Text == "" && cmbBOMON.Text != "" && cmbTrangThai.Text != "")
            {
                query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "') and (DeTaiNCKH.TrangThai = N'" + cmbTrangThai.Text.Trim() + "' and BOMON.TenBM = N'" + cmbBOMON.Text + "')";
            }
            else if (cmbCap.Text != ""  && cmbBOMON.Text == "" && cmbTrangThai.Text == "")
            {
                query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "' and  DeTaiNCKH.Cap = N'" + cmbCap.Text + "')";
            }
            else if (cmbCap.Text != "" && cmbBOMON.Text != "" && cmbTrangThai.Text == "")
            {
                query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "') and (DeTaiNCKH.Cap = N'" + cmbCap.Text + "'and BOMON.TenBM = N'" + cmbBOMON.Text + "')";
            }
            else if (cmbCap.Text != "" && cmbBOMON.Text == "" && cmbTrangThai.Text != "")
            {
                query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "') and (DeTaiNCKH.Cap = N'" + cmbCap.Text + "' and DeTaiNCKH.TrangThai = N'" + cmbTrangThai.Text.Trim() + "')";
            }
            else
            {
                query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "') and DeTaiNCKH.TrangThai = N'" + cmbTrangThai.Text.Trim() + "' and (BOMON.TenBM = N'" + cmbBOMON.Text + "' and DeTaiNCKH.Cap = N'" + cmbCap.Text + "')";
            }
            DataTable dt = ConnectDB.Connected.getData(query);
            ListDT.DataSource = dt;
        }
        private void cmbTrangThai_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //string query = "";
            //query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "' and  DeTaiNCKH.TrangThai = N'" + cmbTrangThai.Text.Trim() + "')";

            //if (cmbCap.Text != "" && cmbBOMON.Text == "")
            //{
            //    query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "') and (DeTaiNCKH.Cap = N'" + cmbCap.Text + "' and DeTaiNCKH.TrangThai = N'" + cmbTrangThai.Text.Trim() + "')";

            //}
            //else if (cmbCap.Text == "" && cmbBOMON.Text != "")
            //{
            //    query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "') and (BOMON.TenBM = N'" + cmbBOMON.Text + "' and DeTaiNCKH.TrangThai = N'" + cmbTrangThai.Text.Trim() + "')";

            //}
            //else if (cmbCap.Text != "" && cmbTrangThai.Text != "")
            //{
            //    query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "') and DeTaiNCKH.TrangThai = N'" + cmbTrangThai.Text.Trim() + "' and (BOMON.TenBM = N'" + cmbBOMON.Text + "' and DeTaiNCKH.Cap = N'" + cmbCap.Text + "')";
            //}
            //DataTable dt = ConnectDB.Connected.getData(query);
            //ListDT.DataSource = dt;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            panelLoc.Visible = false;
        }

        private void txtsearchTopic_TextChanged(object sender, EventArgs e)
        {
            string query = "";

            if (cmbCap.Text == "" && cmbBOMON.Text == "" && cmbTrangThai.Text == "")
            {
                query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "'";

            }
            else if (cmbCap.Text == "" && cmbBOMON.Text == "" && cmbTrangThai.Text != "")
            {
                query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "') and  DeTaiNCKH.TrangThai = N'" + cmbTrangThai.Text.Trim() + "'";
            }
            else if (cmbCap.Text == "" && cmbBOMON.Text != "" && cmbTrangThai.Text != "")
            {
                query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "') and (DeTaiNCKH.TrangThai = N'" + cmbTrangThai.Text.Trim() + "' and BOMON.TenBM = N'" + cmbBOMON.Text + "')";
            }
            else if (cmbCap.Text != "" && cmbBOMON.Text == "" && cmbTrangThai.Text == "")
            {
                query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "' and  DeTaiNCKH.Cap = N'" + cmbCap.Text + "')";
            }
            else if (cmbCap.Text != "" && cmbBOMON.Text != "" && cmbTrangThai.Text == "")
            {
                query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "') and (DeTaiNCKH.Cap = N'" + cmbCap.Text + "'and BOMON.TenBM = N'" + cmbBOMON.Text + "')";
            }
            else if (cmbCap.Text != "" && cmbBOMON.Text == "" && cmbTrangThai.Text != "")
            {
                query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "') and (DeTaiNCKH.Cap = N'" + cmbCap.Text + "' and DeTaiNCKH.TrangThai = N'" + cmbTrangThai.Text.Trim() + "')";
            }
            else
            {
                query = "select MADT, TenDT, ChuyenNganh, Cap, SQDThanhLap, NgayBD, NgayNT, TrangThai, LoaiSP, BOMON.TenBM, TienDo from DeTaiNCKH, BOMON where (DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "') and DeTaiNCKH.TrangThai = N'" + cmbTrangThai.Text.Trim() + "' and (BOMON.TenBM = N'" + cmbBOMON.Text + "' and DeTaiNCKH.Cap = N'" + cmbCap.Text + "')";
            }
            try
            {
                DataTable dt = ConnectDB.Connected.getData(query);
                ListDT.DataSource = dt;
                var re = from row in dt.AsEnumerable()
                         where row[1].ToString().ToLower().Contains(txtsearchTopic.Text.ToLower())
                         select row;
                ListDT.DataSource = re.CopyToDataTable();
            }
            catch
            {

            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ListDT.SelectAll();
            DataObject copydata = ListDT.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object misedata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(misedata);
            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();
            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {
            getListDT();
            panelLoc.Visible = false;
        }

        private void btnTTTV_Click(object sender, EventArgs e)
        {
            string madt = inforDT[0];
            string tendt = inforDT[1];
            Form tttv = new ThongTinTV(madt, tendt);
            tttv.Show();
        }
    }
}
