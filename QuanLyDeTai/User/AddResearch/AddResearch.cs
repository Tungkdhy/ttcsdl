using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.User.AddResearch
{
    public partial class AddResearch : Form
    {
        public AddResearch()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void MaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void Change_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QUANLY;Integrated Security=True");
            string query = "INSERT INTO NhanVien (Ten,MaNV,Tuoi,Luong) VALUES('ten','TV','18','10000')";
            SqlCommand command = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Records Inserted Successfully");
            }
            catch
            {
                Console.WriteLine("Error Generated. Details: ");
            }
            finally
            {
                conn.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
