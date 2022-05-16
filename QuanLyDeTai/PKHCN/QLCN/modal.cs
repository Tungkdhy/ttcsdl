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
    public partial class modal : Form
    {
        private string MaDT;
        private string tenDT;
        private string MAGV;
        private string Mak;
        private string MATV;
        public modal( string madt,string tendt,string ma,string MAKHOA)
        {
            InitializeComponent();
            MaDT = madt;
            MAGV = ma;
            tenDT = tendt;
            Mak = MAKHOA;
            AddTV.Enabled = false;
            getTV();
            getListGV();
        }
        private void getTV()
        {
            MADT.Text = MaDT;
            TenDT.Text = tenDT;
            MACN.Text = MAGV;
            string query = "pkhcn_view_listTV '"+MaDT+"'";
            guna2DataGridView1.DataSource = ConnectDB.Connected.getData(query);
        }
        private void getListGV()
        {
            listGV.Items.Clear();
            string query = "getGVKTGDTBYMK '"+Mak+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            foreach(DataRow dr in dt.Rows)
            {
                listGV.Items.Add(dr[0].ToString());
            }
        }

      

    

        private void AddTV_Click(object sender, EventArgs e)
        {
            string query = "addTV '"+listGV.Text+"','"+MaDT+"'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Thêm"));
            listGV.SelectedItem = null;
            getTV();
            getListGV();
        }

        

        private void listGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddTV.Enabled = true;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = "pkhcn_xoa_tv_TGDT '" + MATV + "','" + MaDT + "'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Xóa"));
            getListGV();
            getTV();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = guna2DataGridView1.Rows[index];
            MATV = selectedRow.Cells["MAGV"].Value.ToString();

        }
    }
}
