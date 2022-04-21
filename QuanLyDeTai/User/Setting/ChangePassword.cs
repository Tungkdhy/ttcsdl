using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.User.Setting
{
    public partial class ChangePassword : Form
    {
        private static string maGV;
        private static string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public ChangePassword(string MaGV)
        {
            maGV = MaGV;
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool CheckPassword()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "select Passwords from NGUOIDUNG where MGV ='"+maGV+"'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string pass = dt.Rows[0][0].ToString().Trim();
            conn.Close();
            if (mkc.Text.ToString().Trim() == pass)
            {
                return true;
            }
            return false;
       
        }
        private bool ConfirmPassword(string a,string b)
        {
            if(a== b)
            {
                return true;
            }
            return false;
        }
        private void Change_Click(object sender, EventArgs e)
        {
            if (CheckPassword())
            {
                if (ConfirmPassword(mkm.Text.Trim(), nmkm.Text.Trim()))
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();

                    string query = "update NGUOIDUNG set Passwords ='" + mkm.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thay đổi mật khẩu thành công");
                }
                else
                {
                    MessageBox.Show("Nhap lai mk moi");
                }
            }
            else
            {
                MessageBox.Show("Nhap lai mk cu");
            }
        }

        private void mkc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
