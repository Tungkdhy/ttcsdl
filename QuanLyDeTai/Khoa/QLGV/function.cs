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
        public function(List<string> dataGV, string state)
        {

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
            txtMABM.Text = inforGV[7];
        }
        public void setup(string state)
        {
            if (state == "update")
            {
                lbFuncQLGV.Text = "Sửa giáo viên";
                txtMAGV.Enabled = false;
                txtName.Enabled = false;
                txtCapBac.Focus();
            }
            else if (state == "add")
            {
                txtMAGV.Enabled = false;
                txtName.Enabled = true;
                txtName.Text = "";
                txtNS.Text = "";
                txtGT.Text = "";
                txtCapBac.Text = "";
                txtChucVu.Text = "";
                txtDTL.Text = "";
                txtMABM.Text = "";
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (State == "update")
                {
                    MessageBox.Show(State);
                    string query = "update GV set NS = '" + txtNS.Text + "'," +
                            "GioiTinh = N'" + txtGT.Text + "',CapBac = N'" + txtCapBac.Text + "'," +
                            "ChucVu = N'" + txtChucVu.Text + "',DTL = '" + txtDTL.Text + "'," +
                            " MABM = N'" + txtMABM.Text + "' where MAGV = '" + txtMAGV.Text + "'";

                    MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Sửa"));
                    this.Hide();
                }
                if (State == "add")
                {
                    string query = "insert into GV(MAGV, TenGV, NS, GioiTinh, CapBac, ChucVu, DTL, MABM) values ('"+txtMAGV.Text+"', " +
                        "N'"+txtName.Text+"', '"+txtNS.Text+"', '"+txtGT.Text+"', N'"+txtCapBac.Text+"', " +
                        "N'"+txtChucVu.Text+"','"+txtDTL.Text+"', '"+txtMABM.Text+"')";
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
