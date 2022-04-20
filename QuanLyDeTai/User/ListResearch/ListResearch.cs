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

      
      
        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QUANLY;Integrated Security=True");

            string query = "update NhanVien set Ten ='" + txtName.Text + "' , MaNV ='" + txtID.Text + " ',Luong='" + txt.Text + "', Tuoi='18'";
           
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Update done");
            }
            catch
            {
                MessageBox.Show("Update faild");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged_1(object sender, EventArgs e)
        {

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
    }
}
