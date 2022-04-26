using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.PKHCN.DSDT
{
    public partial class DSDT : Form
    {
        public DSDT()
        {
            InitializeComponent();
            getListDT();
            enabled();
           
        }
        public void enabled()
        {
            delete.Enabled = false;
            edit.Enabled = false;
            cancel.Enabled = false;
            search.Enabled = false;
        }
        public void getListDT()
        {
            string query = "select * from DeTaiNCKH";
            DataTable dt = ConnectDB.Connected.getData(query);
            listDT.DataSource = dt;
            listDT.Columns[0].HeaderText = "MĐT";
            listDT.Columns[1].HeaderText = "Tên đề tài";
            listDT.Columns[1].Width = 250;
            listDT.Columns[2].HeaderText = "Chuyên ngành";
            listDT.Columns[3].HeaderText = "Cấp";
            listDT.Columns[4].HeaderText = "SQDTL";
            listDT.Columns[5].HeaderText = "Ngày bắt đầu";
            listDT.Columns[6].HeaderText = "Ngày kết thúc";
            listDT.Columns[7].HeaderText = "Trạng thái";
            listDT.Columns[8].HeaderText = "Loại sản phẩm";
            listDT.Columns[9].HeaderText = "MP";
            listDT.Columns[10].HeaderText = "MBM";
     



        }

        private void add_Click(object sender, EventArgs e)
        {

        }
    }
}
