using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.PKHCN.BBKH
{
    public partial class BBKH : Form
    {
        public static List<string> inforBB = new List<string>();
        public BBKH()
        {
            InitializeComponent();
            getListBB();
        }

        private void getListBB()
        {
            string query = "exec getAllBB";
            listBB.DataSource = ConnectDB.Connected.getData(query);
        }
        private void addBB_Click(object sender, EventArgs e)
        {
            string state = "add";
            List<string> empty = new List<string>() { };
            Form add = new modal(empty,state);
            add.ShowDialog();
            getListBB();
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = listBB.Rows[index];
            string MABB = selectedRow.Cells["Mã bài báo"].Value.ToString();
            string TenBB = selectedRow.Cells["Tên bài báo"].Value.ToString();
            string CN = selectedRow.Cells["Chuyên ngành"].Value.ToString();
            string NgayDang = selectedRow.Cells["Ngày đăng"].Value.ToString().Split()[0];
            string TapChi = selectedRow.Cells["Tạp chí"].Value.ToString();
            string MaDT = selectedRow.Cells["Mã dề tài"].Value.ToString();
            string MAGV = selectedRow.Cells["Mã giáo viên"].Value.ToString();
            string[] dataGT = { MABB,TenBB, MaDT, CN,NgayDang,TapChi,MAGV};
            inforBB.Clear();
            inforBB.AddRange(dataGT);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = "exec prd_pkhcn_xoaBB '" + inforBB[0] + "'";
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa đề tài có mã:" + inforBB[0].Trim() + "", "Are you sure for", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show(ConnectDB.Connected.ChangeData(query, "xóa"));
            }
            else
            {

            }

            getListBB();
        }

        private void editBB_Click(object sender, EventArgs e)
        {
            string state = "edit";
            Form edit = new modal(inforBB, state);
            edit.ShowDialog();
            getListBB();
        }


    }

}
