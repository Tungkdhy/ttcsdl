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

namespace QuanLyDeTai.User.Infor
{
    public partial class Infor : Form
    {
        public static string maGV;
        public Infor(string MaGv)
        {
            maGV = MaGv;
            InitializeComponent();
            getInfor();
            enable();
        }
        private void getInfor()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QUANLY;Integrated Security=True");
            conn.Open();
            string query = "select * from GV where MaGv='"+maGV+"'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            try
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                hoten.Text = dt.Rows[0][1].ToString().Trim();
                gioitinh.Text = dt.Rows[0][3].ToString().Trim();
                ngaysinh.Text = dt.Rows[0][2].ToString().Split(' ')[0];
                MaBM.Text = dt.Rows[0][7].ToString().Trim();
                Makhoa.Text = dt.Rows[0][8].ToString().Trim();
                Capbac.Text = dt.Rows[0][4].ToString().Trim();
                chucvu.Text = dt.Rows[0][5].ToString().Trim();

            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }
        private void enable()
        {
            hoten.Enabled = false;
            gioitinh.Enabled=false;
            ngaysinh.Enabled=false;
            chucvu.Enabled=false;
            Capbac.Enabled=false;
            MaBM.Enabled=false;
            Makhoa.Enabled=false;
            Save.Enabled=false;
            Huy.Enabled=false;
        }
        
        private void Infor_Load(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            chucvu.Enabled = true;
            Capbac.Enabled = true;
            MaBM.Enabled = true;
            Save.Enabled = true;
            Huy.Enabled = true;
            chucvu.Focus();
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            getInfor();
            enable();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QUANLY;Integrated Security=True");
            conn.Open();
            
            string query = "update GV set Capbac =N'" + Capbac.Text + "', Chucvu=N'"+chucvu.Text+"', MABM = '"+MaBM.Text+"' where MaGv='"+maGV+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sửa thành công");
                getInfor();
                enable();
            }
            catch
            {
                MessageBox.Show("Faild");
            }
        }
    }
}
