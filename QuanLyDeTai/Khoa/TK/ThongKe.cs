using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.Khoa.TK
{
    public partial class ThongKe : Form
    {
        public static string MaKhoa = "";
        public ThongKe(string makhoa)
        {
            MaKhoa = makhoa;
            InitializeComponent();
        }

        private void cmbSelectYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int sum_of_topic = 0;
            chartTKDTBM.Titles.Clear();
            string query_get_per = "exec pro_Khoa_TKPTDTBM_theo_nam '"+cmbSelectYear.Text+"','"+MaKhoa+"'";
           //string query = "select TenBM, count(DeTaiNCKH.MABM) as 'number of topic' from DeTaiNCKH left join BOMON on DeTaiNCKH.MABM = BOMON.MABM where year(DeTaiNCKH.NgayBD) = '" + cmbSelectYear.Text + "' group by  DeTaiNCKH.MABM,BOMON.TenBM";
            DataTable dt = ConnectDB.Connected.getData(query_get_per);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    sum_of_topic += int.Parse(dr[1].ToString());
            //}

            chartTKDTBM.DataSource = dt;
            chartTKDTBM.Series["DTBM"].XValueMember = "TenBM";
            chartTKDTBM.Series["DTBM"].YValueMembers = "number of topic";
            chartTKDTBM.Titles.Add("DTBM");
            chartTKPT.DataSource = dt;
            chartTKPT.Series["TKPT"].XValueMember = "TenBM";
            chartTKPT.Series["TKPT"].YValueMembers = "percentage";
            chartTKPT.Titles.Add("TKPT");
            txtSLDT.Text = dt.Rows[0][3].ToString();
        }
    }
}
