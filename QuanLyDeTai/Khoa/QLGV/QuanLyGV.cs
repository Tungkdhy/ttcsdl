//using DevExpress.XtraEditors;
using System;
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
    public partial class QuanLyGV : Form
    {
        public static List<string> inforGV = new List<string>();
        public static string state = "";
        public static string MaKhoa = "";
        public QuanLyGV(string maKhoa)
        {
            MaKhoa = maKhoa;
            InitializeComponent();
            getListGV();
        }


        public void getListGV()
        {
            string query = "select * from GV where MAKHOA = '" + MaKhoa + "'";
            DataTable dt = ConnectDB.Connected.getData(query);

            ListGV.DataSource = dt;


        }




        private void btnSua_Click(object sender, EventArgs e)
        {
            state = "update";
            Form function = new QLGV.function(inforGV, state);
            function.ShowDialog();
            getListGV();
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "exec prd_khoa_deleteGV '" + inforGV[0] + "'";
            DialogResult dr = MessageBox.Show("Delete " + inforGV[1].Trim() + "", "Are you sure for", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show(ConnectDB.Connected.ChangeData(query, "xóa"));
            }
            else
            {

            }

            getListGV();
        }

        private void ListGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            bunifuTransition1.ShowSync(panel1);
            int index = e.RowIndex;
            DataGridViewRow selectedRow = ListGV.Rows[index];
            string MAGV = selectedRow.Cells["MAGV"].Value.ToString();
            string TenGV = selectedRow.Cells["TenGV"].Value.ToString();
            string NS = selectedRow.Cells["NS"].Value.ToString().Split()[0];
            string GioiTinh = selectedRow.Cells["GioiTinh"].Value.ToString();
            string CapBac = selectedRow.Cells["CapBac"].Value.ToString();
            string ChucVu = selectedRow.Cells["ChucVu"].Value.ToString();
            string DTL = selectedRow.Cells["DTL"].Value.ToString();
            string MABM = selectedRow.Cells["MABM"].Value.ToString();
            string[] dataGV = { MAGV, TenGV, NS, GioiTinh, CapBac, ChucVu, DTL, MABM };
            inforGV.Clear();
            inforGV.AddRange(dataGV);
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            List<string> empty = new List<string>() { };
            state = "add";
            Form function = new QLGV.function(empty, state);
            function.ShowDialog();
            getListGV();
        }

    }
}