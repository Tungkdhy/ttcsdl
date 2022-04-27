using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.Khoa
{
    public partial class Khoa : Form
    {
        public static string MaKhoa = "";
        public Khoa(string makhoa)
        {
            MaKhoa = makhoa;
            InitializeComponent();
        }

        
        private Form activeForm = null;
        private void openChilForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            cotentpanel.Controls.Add(childForm);
            cotentpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public string getTenKhoa(string makhoa)
        {
            
            string query = "select TenKhoa from KHOA where MAKHOA = '"+makhoa+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            string tenkhoa = dt.Rows[0][0].ToString();
            return tenkhoa;
        }

        private void btnQLGV_Click(object sender, EventArgs e)
        {
            Form qlgv = new QuanLyGV(MaKhoa);
            openChilForm(qlgv);
            
        }

        private void btnQLDT_Click(object sender, EventArgs e)
        {
            Form qldt = new QLDT.QuanLyDeTai(MaKhoa);
            openChilForm(qldt);
        }

        private void btnQLKP_Click(object sender, EventArgs e)
        {
            Form thongke = new TK.ThongKe();
            openChilForm(thongke);
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            Labeltenkhoa.Text = getTenKhoa(MaKhoa);
        }
    }
}
