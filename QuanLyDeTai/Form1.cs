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

namespace QuanLyDeTai
{
    public partial class Form1 : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            
        }


       
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "select count(NS) as 'Tong', YEAR(NS) AS Year from GV group by YEAR(NS)";
            SqlDataAdapter d = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            d.Fill(dt);
            MessageBox.Show(dt.Rows[0][1].ToString());
            chart1.DataSource = dt;
            chart1.Series["SoGv"].YValueMembers = "Tong";
            chart1.Series["SoGv"].XValueMember = "Year";
            chart1.Titles.Add("Salary Chart");
            conn.Close();
        }
    }
}
