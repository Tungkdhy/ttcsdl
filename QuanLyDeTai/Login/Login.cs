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

namespace QuanLyDeTai.Login
{
    public partial class Login : Form

    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public Login()
        {
            InitializeComponent();
            
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
            /*SqlConnection conn = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QUANLY;Integrated Security=True");
            string userName = UserName.Text;
            string password = Password.Text;
            conn.Open();
            string query = "select * from NGUOIDUNG where UserName = '" + userName + "' and Passwords = '" + password + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            try
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string MaKhoa = dt.Rows[0][3].ToString().Trim();
                    string MaBM = dt.Rows[0][4].ToString().Trim();
                    string MP = dt.Rows[0][5].ToString().Trim();
                    string maGV = dt.Rows[0][6].ToString().Trim();

                    if (maGV!="")
                    {
                        Form Gv = new User.User(maGV);
                        MessageBox.Show("Đăng nhập thành công");
                        Gv.Show();
                        this.Hide();
                    }
                    if (MaKhoa != "")
                    {
                        Form MK = new Admin.Admin();
                        MessageBox.Show("Đăng nhập thành công");
                        MK.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("dang nhap that bai");
                }


            }
            catch
            {
                MessageBox.Show("dang nhap that bai");
            }*/
         
        //}


        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string userName = UserName.Text;
            string password = Password.Text;
            conn.Open();
            string query = "select * from DANGNHAP where UserName = '" + userName + "' and Passwords = '" + password + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            try
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string MaKhoa = dt.Rows[0][3].ToString().Trim();
                    string MaBM = dt.Rows[0][4].ToString().Trim();
                    string MP = dt.Rows[0][5].ToString().Trim();
                    string maGV = dt.Rows[0][6].ToString().Trim();
                    
                    if (maGV != "")
                    {
                        Form Gv = new User.User(maGV);
                        MessageBox.Show("Đăng nhập thành công");
                        Gv.Show();
                        this.Hide();
                    }
                    if (MaKhoa != "")
                    {
                        Form Khoa = new Khoa.Khoa(MaKhoa);
                        MessageBox.Show("Đăng nhập thành công");
                        Khoa.Show();
                        this.Hide();
                    }
                    if (MP!="")
                    {
                        Form PKHCN = new PKHCN.PKHCN();
                        MessageBox.Show("Đăng nhập thành công");
                        PKHCN.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("dang nhap that bai");
                }


            }
            catch
            {
                MessageBox.Show("dang nhap that bai");
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
