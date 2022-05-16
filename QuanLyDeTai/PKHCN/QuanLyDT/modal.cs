using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.PKHCN.QuanLyDT
{
    public partial class modal : Form
    {
        public static List<string> ListData;
        public static string State;
        public modal(List<string> inforDT,string state)
        {
            State = state;
            InitializeComponent();
            ListData = inforDT;
            MDT.Enabled = false;
            getDataInfo();
            if (state == "Edit")
            {
                getDataInfo();
                MDT.Enabled = false;
                MP.Enabled = false;
                MBM.Enabled = false;
            }

        }
        private void getDataInfo()
        {
            MDT.Text = ListData[0];
            TenDT.Text = ListData[1];
            CN.Text = ListData[2];
            Cap.Text = ListData[3];
            KQ.Text = ListData[4];
            NgayBD.Text = ListData[5].Split()[0];
            NgayNT.Text = ListData[6].Split()[0];
            TT.Text = ListData[7];
            LSP.Text = ListData[8];
            MBM.Text = ListData[9];
        }
        private void HT_Click(object sender, EventArgs e)
        {
            string query = "";
            if(State == "Edit")
            {
                query = "exec updateResearch N'" + TenDT.Text + "',N'" + CN.Text + "',N'" + Cap.Text + "',N'" + KQ.Text + "','" + NgayBD.Text + "','" + NgayNT.Text + "',N'" + LSP.Text + "','" + TienDo.Text + "',N'" + TT.Text + "','" + MDT.Text + "'";
                MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Sửa"));
                this.Close();
            }
            if(State == "Add")
            {
                query = "exec addResearch '"+MDT.Text+ "','" + MP.Text + "','" + MBM.Text + "', N'" + TenDT.Text + "',N'" + CN.Text + "',N'" + Cap.Text + "',N'" + KQ.Text + "','" + NgayBD.Text + "','" + NgayNT.Text + "',N'" + LSP.Text + "','" + TienDo.Text + "',N'" + TT.Text + "'";
                MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Thêm"));
                this.Close();
            }
            
        }
    }
}
