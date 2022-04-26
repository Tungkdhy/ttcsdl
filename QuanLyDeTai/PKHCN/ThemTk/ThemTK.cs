using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.PKHCN.ThemTk
{
    public partial class ThemTK : Form
    {
        public ThemTK()
        {
            InitializeComponent();
            getListTK();
        }
        public void getListTK()
        {
            string query = "select * from NGUOIDUNG";
            listTK.DataSource =  ConnectDB.Connected.getData(query);
        }
        private void add_Click(object sender, EventArgs e)
        {

        }
    }
}
