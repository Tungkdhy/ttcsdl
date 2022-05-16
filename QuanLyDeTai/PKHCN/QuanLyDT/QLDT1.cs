using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.PKHCN.QuanLyDT
{
   

    public partial class QLDT1 : Form
    {
        public static List<string> inforDT = new List<string>();
        public QLDT1()
        {
            InitializeComponent();
            getListReasearch();
            panelFilter.Visible = false;
            getMaGV();
            getYear();
        }
        private void getListReasearch()
        {
            string query = "exec getAllResearch ";
            listDT.DataSource = ConnectDB.Connected.getData(query);
        }

        private void add_Click(object sender, EventArgs e)
        {

        }
        private void getMaGV()
        {
            selectMa.Items.Clear();
            string query = "pkhcn_getAllMGV";
            DataTable dt = ConnectDB.Connected.getData(query);
            foreach(DataRow dr in dt.Rows)
            {
                selectMa.Items.Add(dr[0]);
            }
        }
        private void getYear()
        {
            selectYear.Items.Clear();
            string query = "getYearDT";
            DataTable dt = ConnectDB.Connected.getData(query);
            foreach (DataRow dr in dt.Rows)
            {
                selectYear.Items.Add(dr[0]);
            }
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            string state = "Edit";
            Form modal = new modal(inforDT,state);
            modal.ShowDialog();
            getListReasearch();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = "exec deleteResearch '" +inforDT[0]+ "'";
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa đề tài có mã:" + inforDT[0].Trim() + "", "Are you sure for", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show(ConnectDB.Connected.ChangeData(query, "xóa"));
            }
            else
            {

            }

            getListReasearch();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = listDT.Rows[index];
            string MADT = selectedRow.Cells["MADT"].Value.ToString();
            string TenDT = selectedRow.Cells["TenDT"].Value.ToString();
            string ChuyenNganh = selectedRow.Cells["ChuyenNganh"].Value.ToString().Split()[0];
            string Cap = selectedRow.Cells["Cap"].Value.ToString();
            string KQ = selectedRow.Cells["KQ"].Value.ToString();
            string NgayBD = selectedRow.Cells["NgayBD"].Value.ToString();
            string NgayNT = selectedRow.Cells["NgayNT"].Value.ToString();
            string TrangThai = selectedRow.Cells["TrangThai"].Value.ToString();
            string LoaiSP = selectedRow.Cells["LoaiSP"].Value.ToString();
            string TenBM = selectedRow.Cells["MABM"].Value.ToString();
            string TienDo = selectedRow.Cells["TienDo"].Value.ToString();
            string[] dataGT = { MADT, TenDT, ChuyenNganh, Cap, KQ, NgayBD, NgayNT, TrangThai, LoaiSP, TenBM, TienDo };
            inforDT.Clear();
            inforDT.AddRange(dataGT);
        }

        private void add_Click_1(object sender, EventArgs e)
        {
            string state = "Add";
            string query = "declare @nextMadt nvarchar(10) \n exec @nextMadt = TuTangMaDT \n select @nextMadt";
            string MaDT = ConnectDB.Connected.getData(query).Rows[0][0].ToString();
            List<string> empty = new List<string>() {MaDT,"","","","", "", "", "", "", "", ""};

            Form modal = new modal(empty,state);
            modal.ShowDialog();
            getListReasearch();

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string query = "exec searchResearchByName N'"+search.Text+"%'";
            listDT.DataSource = ConnectDB.Connected.getData(query);
        }

        private void filter_Click(object sender, EventArgs e)
        {
            if(panelFilter.Visible == true)
            {
                panelFilter.Visible = false;
                getListReasearch();
            }
            else
            {
                panelFilter.Visible = true;
                TT.SelectedItem = null;
                selectMa.SelectedItem = null;
                selectYear.SelectedItem = null;
                getListReasearch();
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string tt = TT.Text;
            string ma = selectMa.Text;
            string nam = selectYear.Text;
            string query = ""; 
            if(nam=="" && ma =="" && tt != "")
            {
                query = "exec filterResearchTT N'" + tt + "'";
            }
            if (nam == "" && ma != "" && tt == "")
            {
                query = "getAllDTByMagv '"+ma+"'";

            }
            if (nam != "" && ma == "" && tt == "")
            {
                query = "getAllDTbyNam '"+nam+"'";

            }
            if (nam == "" && ma != "" && tt != "")
            {
                query = "exec fillterDTbyMAGVvsTT '"+ma+"',N'" + tt + "'";

            }
            if (nam != "" && ma != "" && tt == "")
            {
                query = "fillterDTbyMAGVvsYear '"+ma+"','"+nam+"'";

            }
            if (nam == "" && ma == "" && tt != "")
            {
                query = "fillterDTbyYearvsTT '"+nam+"',N'"+tt+"'";

            }
            if (nam != "" && ma != "" && tt != "")
            {
                query = "fillterALL '"+ma+"','"+nam+"',N'"+tt+"'";

            }
            listDT.DataSource = ConnectDB.Connected.getData(query);
        }

     
    }
}
