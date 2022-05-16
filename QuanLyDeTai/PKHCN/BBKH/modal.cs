using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.PKHCN.BBKH
{
    public partial class modal : Form
    {
        private string State;
        private List<string> infoBb;
        public modal(List<string> infoBB,string state)
        {
            InitializeComponent();
            State = state;
            infoBb = infoBB;
            getListMGV();
            getInfoBB();
            CN.Enabled = false;
            selectDT.Enabled = false;
            
        }
        private void getListMGV()
        {
            selectMGV.Items.Clear();
            string query = "exec getMGV";
            DataTable ListMGV = ConnectDB.Connected.getData(query);
            foreach (DataRow Row in ListMGV.Rows)
            {
                selectMGV.Items.Add(Row[0]);
            }
            
        } 
        private void getInfoBB()
        {
            if (State == "edit")
            {
                MBB.Text = infoBb[0];
                TenBB.Text = infoBb[1];
                selectDT.Text = infoBb[2];
                CN.Text = infoBb[3];
                NgayDang.Text = infoBb[4];
                TapChi.Text = infoBb[5];
                selectMGV.Text = infoBb[6];
                
            }
        }
        private void HT_Click(object sender, EventArgs e)
        {
            string Mabb = MBB.Text;
            string tenBB = TenBB.Text;
            string cn = CN.Text;
            string nd = NgayDang.Text;
            string tapchi = TapChi.Text;
            string mgv = selectMGV.Text;
            string vt = Vaitro.Text;
            string madt = selectDT.Text;

            if (State == "add")
            {
                string query = "exec prd_pkhcn_themBB '"+Mabb+"',N'"+tenBB+"',N'"+cn+"','"+nd+"',N'"+tapchi+"','"+madt+"','"+mgv+"',N'"+vt+"'";
                MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Thêm"));
                this.Close();
            }
            if (State == "edit")
            {
                string query = "exec prd_pkhcn_suaBB '"+Mabb+ "',N'"+tenBB+"','"+cn+"','"+nd+"','"+tapchi+"','"+madt+"','"+mgv+"'";
                MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Sửa"));
                this.Close();
            }
        }

        private void selectMGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectDT.Items.Clear();
            string MaGV = selectMGV.Text;
            string query = "exec getMDTByMAGV '"+MaGV+"'";
            DataTable ListDTGV = ConnectDB.Connected.getData(query);
            foreach(DataRow Row in ListDTGV.Rows)
            {
                selectDT.Items.Add(Row[0]);
            }
            selectDT.Enabled = true;
        }

        private void selectDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Madt = selectDT.Text;
            string query = "exec getCNByMADT '" + Madt + "'";
            DataTable ChuyenNganh = ConnectDB.Connected.getData(query);
            foreach(DataRow Row in ChuyenNganh.Rows)
            {
                CN.Text = Row[0].ToString();
            }
        }
    }
}
