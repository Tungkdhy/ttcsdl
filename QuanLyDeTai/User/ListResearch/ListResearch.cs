using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.User.ListResearch
{
    public partial class ListResearch : Form
    {
        public static string maGV;
     
        private static string maDT;
     
        public ListResearch(string MaGV)
        {
            maGV = MaGV;
            InitializeComponent();
            Loading.Start();
            btnUpdate.Enabled = false;
            update.Enabled = false;
         
        }
        private void ListResearch_Load(object sender, EventArgs e)
        {
            
        }
        private void getList()
        {
            string query = "exec getAllDTByMGV '" + maGV + "'";
            bunifuDataGridView1.DataSource = ConnectDB.Connected.getData(query);

        } 
        private void Loading_Tick(object sender, EventArgs e)
        {
            progressBar1.Hide();
            progressBar1.PerformStep();
            
            if (progressBar1.Value.ToString() == "100")
            {
                label1.Hide();
                getList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "exec updateProcess '" + maDT + "','" + update.Text + "'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query,"Cập nhập"));
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = bunifuDataGridView1.Rows[e.RowIndex];
                maDT = Convert.ToString(row.Cells["MADT"].Value);
                update.Text = Convert.ToString(row.Cells["TienDo"].Value);
                update.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private void update_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = bunifuDataGridView1.Rows[e.RowIndex];
            maDT = Convert.ToString(row.Cells["MADT"].Value);
            update.Text = Convert.ToString(row.Cells["TienDo"].Value);
            update.Enabled = true;
            btnUpdate.Enabled = true;
        }
    }
}
