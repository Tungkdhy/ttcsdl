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
    public partial class modalDT : Form
    {
        public static List<string> inforDT = new List<string>();
        public static string State = "";
        public static string MaKhoa = "";
        public modalDT(List<string> dataDT, string state, string makhoa)
        {
            MaKhoa = makhoa;
            State = state.Trim();
            inforDT = dataDT;
            InitializeComponent();
            if (dataDT.Any())
            {
                getdataInforDT();
            }

            setup(state);
        }
        public void setup(string state)
        {
            if (state == "update")
            {
                txtMADT.Enabled = false;
                txtTenBM.Enabled = false;
                cmbSelectTenBM.Visible = false;
            }
            else if (state == "add")
            {
                string query = "select distinct(BOMON.TenBM) from DeTaiNCKH, BOMON where DeTaiNCKH.MABM  = BOMON.MABM and BOMON.MAKHOA = '" + MaKhoa + "'";
                DataTable dt = ConnectDB.Connected.getData(query);
                foreach (DataRow dr in dt.Rows)
                {
                    cmbSelectTenBM.Items.Add(dr[0].ToString());
                }
                txtMADT.Enabled = true;
                txtMADT.Text = "";
                txtTenDT.Text = "";
                txtChuyenNganh.Text = "";
                txtCap.Text = "";
                txtSQDTLap.Text = "";
                txtNgayBD.Text = "";
                txtNgayNT.Text = "";
                txtTrangThai.Text = "";
                txtLoaiSP.Text = "";
                txtTenBM.Visible = false;
                

            }
        }
        public void getdataInforDT()
        {

            txtMADT.Text = inforDT[0];
            txtTenDT.Text = inforDT[1];
            txtChuyenNganh.Text = inforDT[2];
            txtCap.Text = inforDT[3];
            txtSQDTLap.Text = inforDT[4];
            txtNgayBD.Text = inforDT[5].Split()[0];
            txtNgayNT.Text = inforDT[6].Split()[0];
            txtTrangThai.Text = inforDT[7];
            txtLoaiSP.Text = inforDT[8];
            txtTenBM.Text = inforDT[9];
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (State == "update")
                {
                    MessageBox.Show(State);
                    string query = "update DeTaiNCKH set TenDT = N'" + txtTenDT.Text + "', " +
                        "ChuyenNganh = N'" + txtChuyenNganh.Text + "',Cap = N'" + txtCap.Text + "'," +
                        "SQDThanhLap = N'" + txtSQDTLap.Text + "', NgayBD = '" + txtNgayBD.Text + "', " +
                        "NgayNT = N'" + txtNgayNT.Text + "', TrangThai='" + txtTrangThai.Text + "', " +
                        "LoaiSP = N'" + txtLoaiSP.Text + "' where MADT = '" + txtMADT.Text + "'";

                    MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Sửa"));
                    this.Hide();
                }
                if (State == "add")
                {

                    string query = "select MABM from BOMON where TenBM = N'"+cmbSelectTenBM.Text.Trim()+"'";
                    DataTable dt = ConnectDB.Connected.getData(query);
                    string MaBM = dt.Rows[0][0].ToString().Trim();
                    string query1 = "insert into DeTaiNCKH(MADT, TenDT, ChuyenNganh, Cap,SQDThanhLap, NgayBD, NgayNT,TrangThai,LoaiSP ,MABM) " +
                        "values ('" + txtMADT.Text + "', N'" + txtTenDT.Text + "',N'" + txtChuyenNganh.Text + "'," +
                        "N'" + txtCap.Text + "', N'" + txtSQDTLap.Text + "', '" + txtNgayBD.Text + "', '" + txtNgayNT.Text + "', " +
                        "'" + txtTrangThai.Text + "', N'" + txtLoaiSP.Text + "', '" + MaBM + "')";
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
    }
}
