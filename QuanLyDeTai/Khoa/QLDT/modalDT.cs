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
                lbModalQLDT.Text = "Sửa đề tài";
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
                txtMADT.Enabled = false;
                txtMADT.Text = inforDT[0];
                txtTenDT.Text = "";
                txtChuyenNganh.Text = "";
                txtCap.Text = "";
                txtTienDo.Text = "0";
                txtSQDTLap.Text = "";
                txtNgayBD.Text = "";
                txtNgayNT.Text = "";
                txtTrangThai.Text = "Chờ phê duyệt";
                txtLoaiSP.Text = "";
                txtTenBM.Visible = false;
                txtTrangThai.Enabled = false;
                txtTienDo.Enabled = false;
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
                    string query = "updateDT  N'" + txtTenDT.Text + "', " +
                        " N'" + txtChuyenNganh.Text + "',N'" + txtCap.Text + "'," +
                        "N'" + txtSQDTLap.Text + "','" + txtNgayBD.Text + "', N'" + txtNgayNT.Text + "', '" + txtTrangThai.Text + "', N'" + txtLoaiSP.Text + "' ,'" + txtMADT.Text + "'";

                    MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Sửa"));
                    this.Hide();
                }
                if (State == "add")
                {
                    string query = "select MABM from BOMON where TenBM = N'" + cmbSelectTenBM.Text.Trim() + "'";
                    DataTable dt = ConnectDB.Connected.getData(query);

                    string MaBM = dt.Rows[0][0].ToString().Trim();
                    MessageBox.Show(MaBM);
                    string query_them_dt = "insert into DeTaiNCKH(MADT, TenDT, ChuyenNganh, Cap,SQDThanhLap, NgayBD, NgayNT,TrangThai,LoaiSP ,MABM) " +
                        "values ('" + txtMADT.Text + "', N'" + txtTenDT.Text + "',N'" + txtChuyenNganh.Text + "'," +
                        "N'" + txtCap.Text + "', N'" + txtSQDTLap.Text + "', '" + txtNgayBD.Text + "', '" + txtNgayNT.Text + "', " +
                        "'" + txtTrangThai.Text + "', N'" + txtLoaiSP.Text + "', '" + MaBM + "')";
                    ConnectDB.Connected.ChangeData(query, "Thêm");
                    string insert_CN = "";
                    string insert_TV1 = "";
                    string insert_TV2 = "";
                    string insert_TV3 = "";
                    string insert_TV4 = "";
                    string query_inserttttt = "";
                    List<string> query_insert = new List<string>();
                    switch (cmbSLTV.Text.Trim())
                    {
                        case "1":
                            insert_CN = "proc_khoa_insertCNDT '" + cmbMGV1.Text + "', '" + txtMADT.Text + "'";
                            query_insert.Add(insert_CN);
                            break;
                        case "2":
                            insert_CN = "proc_khoa_insertCNDT '" + cmbMGV1.Text + "', '" + txtMADT.Text + "'";
                            insert_TV1 = "proc_khoa_insertTV '" + cmbMGV1.Text + "', '" + txtMADT.Text + "'";
                            query_insert.Add(insert_CN);
                            query_insert.Add(insert_TV1);
                            break;
                        case "3":
                            insert_CN = "proc_khoa_insertCNDT '" + cmbMGV1.Text + "', '" + txtMADT.Text + "'";
                            insert_TV1 = "proc_khoa_insertTV '" + cmbMGV1.Text + "', '" + txtMADT.Text + "'";
                            insert_TV2 = "proc_khoa_insertTV '" + cmbMGV2.Text + "', '" + txtMADT.Text + "'";
                            query_insert.Add(insert_CN);
                            query_insert.Add(insert_TV1);
                            query_insert.Add(insert_TV2);
                            break;
                        case "4":
                            insert_CN = "proc_khoa_insertCNDT '" + cmbMGV1.Text + "', '" + txtMADT.Text + "'";
                            insert_TV1 = "proc_khoa_insertTV '" + cmbMGV1.Text + "', '" + txtMADT.Text + "'";
                            insert_TV2 = "proc_khoa_insertTV '" + cmbMGV2.Text + "', '" + txtMADT.Text + "'";
                            insert_TV3 = "proc_khoa_insertTV '" + cmbMGV3.Text + "', '" + txtMADT.Text + "'";
                            query_insert.Add(insert_CN);
                            query_insert.Add(insert_TV1);
                            query_insert.Add(insert_TV2);
                            query_insert.Add(insert_TV3);
                            break;
                        case "5":
                            insert_CN = "proc_khoa_insertCNDT '" + cmbMGV1.Text + "', '" + txtMADT.Text + "'";
                            insert_TV1 = "proc_khoa_insertTV '" + cmbMGV1.Text + "', '" + txtMADT.Text + "'";
                            insert_TV2 = "proc_khoa_insertTV '" + cmbMGV2.Text + "', '" + txtMADT.Text + "'";
                            insert_TV3 = "proc_khoa_insertTV '" + cmbMGV3.Text + "', '" + txtMADT.Text + "'";
                            insert_TV4 = "proc_khoa_insertTV '" + cmbMGV4.Text + "', '" + txtMADT.Text + "'";
                            query_insert.Add(insert_CN);
                            query_insert.Add(insert_TV1);
                            query_insert.Add(insert_TV2);
                            query_insert.Add(insert_TV3);
                            query_insert.Add(insert_TV4);
                            break;
                    }
                    query_insert.ForEach(delegate (string single_query)
                    {
                        query_inserttttt = single_query;
                        ConnectDB.Connected.ChangeData(query,"Thêm");
                    });
                    
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

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void lbModalQLDT_Click(object sender, EventArgs e)
        {

        }

        private void cmbSelectTenBM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
