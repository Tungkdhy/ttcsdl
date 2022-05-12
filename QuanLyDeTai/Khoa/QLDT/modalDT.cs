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
        public static string error = "1";
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
            getMaGV_0_TGDT();
            setup(state);
        }
        private string  FillTenGV(string MaGV)
        {
            string query_getTenGV = "proc_khoa_getTenGV '" + MaGV + "'";
            DataTable dt = ConnectDB.Connected.getData(query_getTenGV);
            return dt.Rows[0][0].ToString();
        }
        public void setup(string state)
        {
            if (state == "update")
            {
                lbModalQLDT.Text = "Sửa đề tài";
                txtMADT.Enabled = false;
                txtTenBM.Enabled = false;
                cmbSelectTenBM.Visible = false;
                panelThemTV.Visible = false;
                this.Size = new Size(810, 760);
                panelThemDTTittle.Dock = DockStyle.Top;
                panelThemDT.Dock = DockStyle.Fill;
            }
            else if (state == "add")
            {
                string query = "select distinct(BOMON.TenBM) from BOMON where BOMON.MAKHOA = '" + MaKhoa + "'";
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
                txtKetQua.Text = "";
                txtNgayBD.Text = "";
                txtNgayNT.Text = "";
                txtTrangThai.Text = "Chờ phê duyệt";
                txtLoaiSP.Text = "";
                txtTenBM.Visible = false;
                txtTrangThai.Enabled = false;
                txtTienDo.Enabled = false;
                cmbMCN.Enabled = false;
                cmbMGV1.Enabled = false;
                cmbMGV2.Enabled = false;
                cmbMGV3.Enabled = false;
                cmbMGV4.Enabled = false;
            }
        }
        public void getdataInforDT()
        {
            txtMADT.Text = inforDT[0];
            txtTenDT.Text = inforDT[1];
            txtChuyenNganh.Text = inforDT[2];
            txtCap.Text = inforDT[3];
            txtNgayBD.Text = inforDT[4].Split()[0];
            txtNgayNT.Text = inforDT[5].Split()[0];
            txtTrangThai.Text = inforDT[6];
            txtLoaiSP.Text = inforDT[7];
            txtTenBM.Text = inforDT[8];
            txtTienDo.Text = inforDT[9];
            txtKetQua.Text = inforDT[10];
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
                        "N'" + txtKetQua.Text + "','" + txtNgayBD.Text + "', N'" + txtNgayNT.Text + "', N'" + txtTrangThai.Text + "', N'" + txtLoaiSP.Text + "' ,'" + txtMADT.Text + "'";

                    MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Sửa"));
                    this.Hide();
                }
                if (State == "add")
                {
                    
                    string message_tv = "";
                    //check_magv();
                    if (error == "1")
                    {                        
                        string query_them_dt = "proc_khoa_insertDT '" + txtMADT.Text.Trim() + "', N'" + txtTenDT.Text.Trim() + "',N'" + txtChuyenNganh.Text.Trim() + "',N'" + txtCap.Text.Trim() + "', '" + txtNgayBD.Text + "', '" + txtNgayNT.Text + "', N'" + txtTrangThai.Text.Trim() + "', N'" + txtLoaiSP.Text.Trim() + "', N'"+cmbSelectTenBM.Text.Trim()+ "', '"+txtTienDo.Text.Trim()+"', N'"+txtKetQua.Text.Trim()+"'";                       
                        MessageBox.Show(ConnectDB.Connected.ChangeData(query_them_dt, "Thêm đề tài thành công"));
                        string insert_CN = "";
                        string insert_TV1 = "";
                        string insert_TV2 = "";
                        string insert_TV3 = "";
                        string insert_TV4 = "";
                        List<string> query_insert = new List<string>();

                        switch (cmbSLTV.Text.Trim())
                        {
                            case "1":
                                insert_CN = "proc_khoa_insertCNDT '" + cmbMCN.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                query_insert.Add(insert_CN);

                                break;
                            case "2":
                                insert_CN = "proc_khoa_insertCNDT '" + cmbMCN.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                insert_TV1 = "proc_khoa_insertTV '" + cmbMGV1.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                query_insert.Add(insert_CN);
                                query_insert.Add(insert_TV1);
                                break;
                            case "3":
                                insert_CN = "proc_khoa_insertCNDT '" + cmbMCN.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                insert_TV1 = "proc_khoa_insertTV '" + cmbMGV1.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                insert_TV2 = "proc_khoa_insertTV '" + cmbMGV2.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                query_insert.Add(insert_CN);
                                query_insert.Add(insert_TV1);
                                query_insert.Add(insert_TV2);
                                break;
                            case "4":
                                insert_CN = "proc_khoa_insertCNDT '" + cmbMCN.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                insert_TV1 = "proc_khoa_insertTV '" + cmbMGV1.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                insert_TV2 = "proc_khoa_insertTV '" + cmbMGV2.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                insert_TV3 = "proc_khoa_insertTV '" + cmbMGV3.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                query_insert.Add(insert_CN);
                                query_insert.Add(insert_TV1);
                                query_insert.Add(insert_TV2);
                                query_insert.Add(insert_TV3);
                                break;
                            case "5":
                                insert_CN = "proc_khoa_insertCNDT '" + cmbMCN.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                insert_TV1 = "proc_khoa_insertTV '" + cmbMGV1.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                insert_TV2 = "proc_khoa_insertTV '" + cmbMGV2.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                insert_TV3 = "proc_khoa_insertTV '" + cmbMGV3.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                insert_TV4 = "proc_khoa_insertTV '" + cmbMGV4.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                query_insert.Add(insert_CN);
                                query_insert.Add(insert_TV1);
                                query_insert.Add(insert_TV2);
                                query_insert.Add(insert_TV3);
                                query_insert.Add(insert_TV4);
                                break;
                        }
                        query_insert.ForEach(delegate (string single_query)
                        {                            
                            message_tv = ConnectDB.Connected.ChangeData(single_query, "Thêm thành viên thành công");
                        });
                        MessageBox.Show(message_tv);                        
                        this.Hide();                        
                    }
                    else
                    {
                        MessageBox.Show(error);
                    }                   
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

        private void cmbSLTV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMCN.Items.Clear();
            cmbMGV1.Items.Clear();
            cmbMGV2.Items.Clear();
            cmbMGV3.Items.Clear();
            cmbMGV4.Items.Clear();
            getMaGV_0_TGDT();
            switch (cmbSLTV.Text.Trim())
            {
                case "1":
                    cmbMCN.Enabled = true;
                    cmbMGV1.Text = "";
                    cmbMGV2.Text = "";
                    cmbMGV3.Text = "";
                    cmbMGV4.Text = "";
                    txtTenGV1.Text = "";
                    txtTenGV2.Text = "";
                    txtTenGV3.Text = "";
                    txtTenGV4.Text = "";
                    cmbMGV1.Enabled = false;
                    cmbMGV2.Enabled = false;
                    cmbMGV3.Enabled = false;
                    cmbMGV4.Enabled = false;
                    

                    break;
                case "2":
                    cmbMCN.Enabled = true;
                    cmbMGV1.Enabled = true;
                    cmbMGV2.Text = "";
                    cmbMGV3.Text = "";
                    cmbMGV4.Text = "";
                    txtTenGV2.Text = "";
                    txtTenGV3.Text = "";
                    txtTenGV4.Text = "";
                    cmbMGV2.Enabled = false;
                    cmbMGV3.Enabled = false;
                    cmbMGV4.Enabled = false;
                    break;
                case "3":
                    cmbMCN.Enabled = true;
                    cmbMGV1.Enabled = true;
                    cmbMGV2.Enabled = true;
                    cmbMGV3.Text = "";
                    cmbMGV4.Text = "";
                    txtTenGV3.Text = "";
                    txtTenGV4.Text = "";
                    cmbMGV3.Enabled = false;
                    cmbMGV4.Enabled = false;
                    break;
                case "4":
                    cmbMCN.Enabled = true;
                    cmbMGV1.Enabled = true;
                    cmbMGV2.Enabled = true;
                    cmbMGV3.Enabled = true;
                    cmbMGV4.Text = "";
                    txtTenGV4.Text = "";
                    cmbMGV4.Enabled = false;
                    break;
                case "5":
                    cmbMCN.Enabled = true;
                    cmbMGV1.Enabled = true;
                    cmbMGV2.Enabled = true;
                    cmbMGV3.Enabled = true;
                    cmbMGV4.Enabled = true;
                    break;
            }
            
        }
        
        private void getMaGV_0_TGDT()
        {
            string query_getMaGV_0_TGDT = "proc_khoa_getGVKTGDT '" + MaKhoa + "'";
            DataTable dt = ConnectDB.Connected.getData(query_getMaGV_0_TGDT);
            foreach (DataRow dr in dt.Rows)
            {
                cmbMCN.Items.Add(dr[0].ToString());
                cmbMGV1.Items.Add(dr[0].ToString());
                cmbMGV2.Items.Add(dr[0].ToString());
                cmbMGV3.Items.Add(dr[0].ToString());
                cmbMGV4.Items.Add(dr[0].ToString());
            }
        }

        private void cmbMCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            txttenCN.Text=FillTenGV(cmbMCN.Text.Trim());
            //cmbMGV1.Items.Remove(cmbMCN.SelectedItem);
            //cmbMGV2.Items.Remove(cmbMCN.SelectedItem);
            //cmbMGV3.Items.Remove(cmbMCN.SelectedItem);
            //cmbMGV4.Items.Remove(cmbMCN.SelectedItem);
        }

        private void cmbMGV1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenGV1.Text = FillTenGV(cmbMGV1.Text.Trim());
            //cmbMCN.Items.Remove(cmbMGV1.SelectedItem);
            //cmbMGV2.Items.Remove(cmbMGV1.SelectedItem);
            //cmbMGV3.Items.Remove(cmbMGV1.SelectedItem);
            //cmbMGV4.Items.Remove(cmbMGV1.SelectedItem);     
        }

        private void cmbMGV2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenGV2.Text = FillTenGV(cmbMGV2.Text.Trim());
            //cmbMCN.Items.Remove(cmbMGV1.SelectedItem);
            //cmbMGV1.Items.Remove(cmbMGV2.SelectedItem);
            //cmbMGV3.Items.Remove(cmbMGV2.SelectedItem);
            //cmbMGV4.Items.Remove(cmbMGV2.SelectedItem);
        }

        private void cmbMGV3_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenGV3.Text = FillTenGV(cmbMGV3.Text.Trim());
            //cmbMCN.Items.Remove(cmbMGV3.SelectedItem);
            //cmbMGV1.Items.Remove(cmbMGV3.SelectedItem);
            //cmbMGV2.Items.Remove(cmbMGV3.SelectedItem);
            //cmbMGV4.Items.Remove(cmbMGV3.SelectedItem);
        }

        private void cmbMGV4_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenGV4.Text = FillTenGV(cmbMGV4.Text.Trim());
            //cmbMCN.Items.Remove(cmbMGV4.SelectedItem);
            //cmbMGV1.Items.Remove(cmbMGV4.SelectedItem);
            //cmbMGV3.Items.Remove(cmbMGV4.SelectedItem);
            //cmbMGV2.Items.Remove(cmbMGV4.SelectedItem);
        }
        private void check_magv()
        {
            if (cmbMGV1.Text == cmbMCN.Text || cmbMGV1.Text == cmbMGV2.Text || cmbMGV1.Text == cmbMGV3.Text || cmbMGV1.Text == cmbMGV4.Text)
            {
                error = "Trùng mã giáo viên";
            }else if (cmbMGV2.Text == cmbMCN.Text || cmbMGV2.Text == cmbMGV3.Text || cmbMGV2.Text == cmbMGV4.Text)
            {
                error = "Trùng mã giáo viên";
            }
            else if (cmbMGV3.Text == cmbMCN.Text || cmbMGV3.Text == cmbMGV4.Text)
            {
                error = "Trùng mã giáo viên";
            }
            else
            {
                error = "1";
            }

        }
        
    }
}
