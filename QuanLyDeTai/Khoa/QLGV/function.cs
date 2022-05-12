using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyDeTai.Khoa.QLGV
{
    public partial class function : Form
    {
        
        public static List<string> inforGV = new List<string>();
        public static string State = "";
        public static string MaKhoa = "";
        public function(List<string> dataGV, string state, string makhoa)
        {
            MaKhoa = makhoa;
            State = state.Trim();
            inforGV = dataGV;
            InitializeComponent();
            if (dataGV.Any())
            {
                getdataInforGV();
            }
            
            setup(state);
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        public void getdataInforGV()
        {
            
            txtMAGV.Text = inforGV[0];
            txtName.Text = inforGV[1];
            txtNS.Text = inforGV[2];
            txtGT.Text = inforGV[3];
            txtCapBac.Text = inforGV[4];
            txtChucVu.Text = inforGV[5];
            txtDTL.Text = inforGV[6];
            txtTenBM.Text = inforGV[7];
        }
        public void setup(string state)
        {
            if (state == "update")
            {
                cmbSelectTenBM.Visible = false;
                lbFuncQLGV.Text = "Sửa giáo viên";
                txtMAGV.Enabled = false;
                txtName.Enabled = false;
                txtCapBac.Focus();
            }
            else if (state == "add")
            {
                string query = "select distinct(BOMON.TenBM) from BOMON where BOMON.MAKHOA = '" + MaKhoa + "'";
                DataTable dt = ConnectDB.Connected.getData(query);
                foreach (DataRow dr in dt.Rows)
                {
                    cmbSelectTenBM.Items.Add(dr[0].ToString());
                }
                txtTenBM.Visible = false;
                txtMAGV.Enabled = false;
                txtName.Enabled = true;
                txtName.Text = "";
                txtNS.Text = "";
                txtGT.Text = "";
                txtCapBac.Text = "";
                txtChucVu.Text = "";
                txtDTL.Text = "";
                
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(State);
            try
            {
                if (State == "update")
                {
                    string query = "proc_khoa_updateGV '" + txtNS.Text.Trim() + "',N'"+txtGT.Text.Trim()+"', N'"+txtCapBac.Text.Trim()+"',N'"+txtChucVu.Text.Trim()+"', '"+txtDTL.Text.Trim()+"',N'"+txtTenBM.Text.Trim()+"', '"+txtMAGV.Text.Trim()+"'";

                    MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Sửa"));
                    this.Hide();
                }
                if (State == "add")
                {

                    string query = "prd_khoa_insertGV '"+txtMAGV.Text+"', N'"+txtName.Text+"', '"+txtNS.Text+"',N'"+txtGT.Text+"'," +
                        "N'"+txtCapBac.Text+"', N'"+txtChucVu.Text+"', '"+txtDTL.Text+"', N'"+cmbSelectTenBM.Text+"'";
                    MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Thêm"));
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Fail");

            }
                
          
            }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
 }
