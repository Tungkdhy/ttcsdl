using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyDeTai.User.AddResearch
{
    public partial class AddReseach : Form
    {
        public static string maGV;
        public AddReseach(string MaGV)
        {
            maGV = MaGV;
            InitializeComponent();
        }
       
        private void DK_Click(object sender, EventArgs e)
        {
      
            string query = "checkGVTGDT '" + maGV + "'";
            DataTable dt = ConnectDB.Connected.getData(query);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng ký không thành công.Vì bạn đang tham gia đề tài");
            }
            else
            {
                //string query = "exec addDTNCGV '" + MDT.Text + "', '" + Ten.Text + "', '" + CN.Text + "', '" + cap.Text + "', '" + SQTL.Text + "', '" + NBD.Text + "','" + NGT.Text + "','" + SP.Text + "','" + MP.Text + "','" + BM.Text + "' ";
                //string actions = "Thêm";
                //MessageBox.Show(ConnectDB.Connected.ChangeData(query, actions));
            }

        }

        private void AddReseach_Load(object sender, EventArgs e)
        {

        }
    }
}
