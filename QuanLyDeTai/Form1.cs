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

namespace QuanLyDeTai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getList();
        }
        private void getList()
        {

            SqlConnection conn = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QUANLY;Integrated Security=True");
            conn.Open();
            string query = "select * from DeTaiNCKH where MADT in(select MADT from GVTGDT TGDT where TGDT.MAGV = 'GV01' )";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            try
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                data.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Ket noi that bai");
            }
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
