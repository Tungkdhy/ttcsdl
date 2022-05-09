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
        public static string MaDT = "";
        public static string TenDT = "";
        public ThongTinTV(string madt, string tendt)
        {
            MaDT = madt;
            TenDT = tendt;
            InitializeComponent();
            fillData();

        }

        public void fillData()
        {
            txtMaDT.Text = MaDT;
            txtTenDT.Text = TenDT;
            string query = "exec prd_Khoa_XemDSTV_Theo_MaDT '"+MaDT+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            listTV.DataSource = dt;
        }

        
    }
}
