using System;
using System.Collections.Generic;
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
        public ListResearch(string MaGV)
        {
            maGV = MaGV;
            InitializeComponent();
            Loading.Start();
            //getList();
        }
        private void ListResearch_Load(object sender, EventArgs e)
        {
            getList();
        }
        private void getList()
        {
           
            SqlConnection conn = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QUANLY;Integrated Security=True");
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

        }
    }
}
