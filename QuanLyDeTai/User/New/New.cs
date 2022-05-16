using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.User.New
{
    public partial class New : Form
    {
        private static string maGV;
        private static string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public New(string MaGv)
        {
            maGV = MaGv;
            InitializeComponent();
            timer1.Start();
            no.Hide();
            comboBoxDetail.Enabled = false;
        }
        private void getListNew()
        {
            
            string query = "exec getAllBBByMGV '"+maGV+"'";
            bunifuDataGridView1.DataSource = ConnectDB.Connected.getData(query);
        }
        int DropDownWidth(ComboBox myCombo)
        {
            int maxWidth = 0;
            int temp = 0;
            Label label1 = new Label();

            foreach (var obj in myCombo.Items)
            {
                label1.Text = obj.ToString();
                temp = label1.PreferredWidth;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            label1.Dispose();
            return maxWidth;
        }

     

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDetail.Text = "";
            comboBoxDetail.Enabled = true;

            comboBoxDetail.Items.Clear();
            //var categorySearch = "ChuyenNganh";
            
            Console.WriteLine(maGV);
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "";
            if (comboBox1.Text == "ChuyenNganh")
            {
                query = "select ChuyenNganh from BaiBaoKH where MABB in (select MABB from GVVietBB v where v.MGV = '" + maGV + "')";
            }
            
            else
            {
                query = "select TapChi from BaiBaoKH where MABB in (select MABB from GVVietBB v where v.MGV = '" + maGV + "')";
            }//string query = "select MABB, '"+categorySearch+"' from BaiBaoKH where MABB in (select MABB from GVVietBB v where v.MGV = '" + maGV + "')";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            
            try
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                Console.WriteLine(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    comboBoxDetail.Items.Add(dr[0].ToString());
                }
               
            }
            catch
            {
                MessageBox.Show("Ket noi that bai");
            }


        }

        private void comboBoxDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "";
            if(comboBox1.Text == "ChuyenNganh")
            {
                query = "select * from BaiBaoKH where MABB in (select MABB from GVVietBB v where v.MGV = '" + maGV + "') and ChuyenNganh='" + comboBoxDetail.Text + "'";

            }
            else
            {
                query = "select * from BaiBaoKH where MABB in (select MABB from GVVietBB v where v.MGV = '" + maGV + "') and TapChi='" + comboBoxDetail.Text + "'";
            }
          
                bunifuDataGridView1.DataSource = ConnectDB.Connected.getData(query);

  
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string searchValue = textbox1.Text.Trim();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "";
            if (comboBox1.Text == "TapChi")
            {
                query = "select * from BaiBaoKH where MABB in (select MABB from GVVietBB v where v.MGV = '" + maGV + "') and TapChi='" + comboBoxDetail.Text + "'";
                
            }
            else if (comboBox1.Text == "ChuyenNganh")
            {
                query = "select * from BaiBaoKH where MABB in (select MABB from GVVietBB v where v.MGV = '" + maGV + "') and ChuyenNganh='" + comboBoxDetail.Text + "'";

            }
            else
            {
                query = "select * from BaiBaoKH where MABB in(select MABB from GVVietBB v where v.MGV = '" + maGV + "' )";
            }
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            try
            {
                no.Hide();
                DataTable dt = new DataTable();
                da.Fill(dt);
                bunifuDataGridView1.DataSource=dt;
                var re = from row in dt.AsEnumerable()
                         where row[1].ToString().ToLower().Contains(searchValue.ToLower())
                         select row;
               
                    bunifuDataGridView1.DataSource = re.CopyToDataTable();
               }
            catch (Exception ex)
            {
                bunifuDataGridView1.DataSource = null;
                no.Show();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Form create = new CreateNew.CreateNew();
            create.ShowDialog();
            Console.WriteLine("tung");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Hide();
            progressBar1.PerformStep();
            if (progressBar1.Value.ToString() == "100")
            {
                bunifuLabel1.Hide();
                getListNew();
                timer1.Stop();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "select * from BaiBaoKH where MABB in(select MABB from GVVietBB v where v.MGV = '" + maGV + "' ) and (TenBaiBao like '%"+ textbox1 .Text.Trim()+ "%') ";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
            
        }

        private void textbox1_TextChanged_2(object sender, EventArgs e)
        {
            string searchValue = textbox1.Text.Trim();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "";
            if (comboBox1.Text == "TapChi")
            {
                query = "select * from BaiBaoKH where MABB in (select MABB from GVVietBB v where v.MGV = '" + maGV + "') and TapChi='" + comboBoxDetail.Text + "'";

            }
            else if (comboBox1.Text == "ChuyenNganh")
            {
                query = "select * from BaiBaoKH where MABB in (select MABB from GVVietBB v where v.MGV = '" + maGV + "') and ChuyenNganh='" + comboBoxDetail.Text + "'";

            }
            else
            {
                query = "select * from BaiBaoKH where MABB in(select MABB from GVVietBB v where v.MGV = '" + maGV + "' )";
            }
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            try
            {
                no.Hide();
                DataTable dt = new DataTable();
                da.Fill(dt);
               bunifuDataGridView1.DataSource = dt;
                var re = from row in dt.AsEnumerable()
                         where row[1].ToString().ToLower().Contains(searchValue.ToLower())
                         select row;

                bunifuDataGridView1.DataSource = re.CopyToDataTable();
            }
            catch (Exception ex)
            {
                bunifuDataGridView1.DataSource = null;
                no.Show();
            }
        }

        private void add_Click_1(object sender, EventArgs e)
        {
            Form create = new CreateNew.CreateNew();
            create.ShowDialog();
            Console.WriteLine("tung");
        }
    }
}
