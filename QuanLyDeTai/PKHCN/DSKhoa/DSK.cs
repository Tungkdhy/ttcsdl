using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.PKHCN.DSKhoa
{
    public partial class DSK : Form
    {
        public DSK()
        {
            InitializeComponent();
            getListKhoa();
        }
        void getListKhoa()
        {
            string query = "select * from KHOA";
            DataTable dt = ConnectDB.Connected.getData(query);
            listKhoa.DataSource = dt;
        }
        private void add_Click(object sender, EventArgs e)
        {

        }
    }
}
