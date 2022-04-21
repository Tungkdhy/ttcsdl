using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyDeTai.User.AddResearch
{
    public partial class AddReseach : Form
    {
        public static string maGV;
        public AddReseach(string MaGV)
        {
            maGV = MaGV;
            InitializeComponent();
        }
       
        private void DK_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QUANLY;Integrated Security=True");
            string query = "exec addDTNCGV '"+MDT.Text+"', '"+Ten.Text+"', '"+CN.Text+"', '"+cap.Text+"', '"+SQTL.Text+"', '"+NBD.Text+"','"+NGT.Text+"','"+SP.Text+ "','" +MP.Text+ "','" +BM.Text+"' ";
            conn.Open();
            Console.WriteLine(query);
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
               
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Faild");
            }

        }
    }
}
