using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyDeTai.User.ListResearch
{
    public partial class ListResearch : Form
    {
        public static string maGV;
        private static string maDT;
        private static string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public ListResearch(string MaGV)
        {
            maGV = MaGV;
            InitializeComponent();
            Loading.Start();
            btnUpdate.Enabled = false;
            update.Enabled = false;
            //getList();
        }
        private void ListResearch_Load(object sender, EventArgs e)
        {
            getList();
        }
        private void getList()
        {

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "exec getAllDTByMGV '"+maGV+"'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            try
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                bunifuDataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Ket noi that bai");
            }
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
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "exec updateProcess '"+maDT+"','"+update.Text+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Cập nhập thành công");
                btnUpdate.Enabled = false;
                update.Enabled = false;
                update.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("faild");
            }
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
                DataGridViewRow row = new DataGridViewRow();
                row = bunifuDataGridView1.Rows[e.RowIndex];
                maDT= Convert.ToString(row.Cells["MADT"].Value);
                update.Text = Convert.ToString(row.Cells["TrangThai"].Value);
                update.Enabled = true;
                btnUpdate.Enabled = true;
        }

        private void update_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
