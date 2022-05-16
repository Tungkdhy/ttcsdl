using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.PKHCN.QLCN
{
    public partial class QLCN : Form
    {
        private string MADT;
        private string MAGV;
        private string tenDT;
        private string MaKhoa;
        public QLCN()
        {
            InitializeComponent();
            getCNResearch();
            //getGVKTGDT();
            getDTCTG();
            detail.Enabled = false;
        }
        private void getCNResearch()
        {
        
            string query = "exec getAlLCN";
            listCN.DataSource = ConnectDB.Connected.getData(query);
        }
        private void getGVKTGDT()
        {
            ListGV.Items.Clear();
            string query = "getGVKTGDT";
            DataTable listMGV = ConnectDB.Connected.getData(query);
            foreach (DataRow row in listMGV.Rows)
            {
                ListGV.Items.Add(row[0].ToString());
            }
        }
        private void getDTCTG()
        {
            ListDT.Items.Clear();
            string query = "getALLDTKTG";
            DataTable DT = ConnectDB.Connected.getData(query);
            foreach(DataRow row in DT.Rows)
            {
                ListDT.Items.Add(row[0].ToString());
            }
        }
        private void Test_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string query = "pkhcn_add_cn '"+ListDT.Text+"','"+ListGV.Text+"'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Thêm"));
            getCNResearch();
        }

        private void ListDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "getTenDTbyMADT '"+ListDT.Text+"'";
            DataTable Name = ConnectDB.Connected.getData(query);
            foreach(DataRow dr in Name.Rows)
            {
                nameDT.Text = dr[0].ToString();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = "pkhcn_delete_cn '" + MADT + "'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Xóa"));
            getCNResearch();
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = listCN.Rows[index];
            MADT = selectedRow.Cells[5].Value.ToString().Trim();
            tenDT = selectedRow.Cells[6].Value.ToString().Trim();
            MaKhoa = selectedRow.Cells[7].Value.ToString().Trim();
            MAGV = selectedRow.Cells[0].Value.ToString().Trim();
            detail.Enabled = true;
        }

        private void detail_Click(object sender, EventArgs e)
        {
            Form tv = new modal(MADT,tenDT,MAGV,MaKhoa);
            tv.ShowDialog();
            
        }
    }
}
