using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.PKHCN.QLTK
{
    public partial class QLTK : Form
    {
        public static string state = "";
        public QLTK()
        {
            InitializeComponent();
            fillter.Enabled =false;
            Enable();


        }
        public void getListTK()
        {
            string query = "";
            if (state == "Khoa")
            {
                query = "exec getTKK";
                listTK.DataSource = ConnectDB.Connected.getData(query);
            }
            if (state == "Bo mon")
            {
                query = "exec getTKBM";
                listTK.DataSource = ConnectDB.Connected.getData(query);
            }
            if (state == "Phong")
            {
                query = "exec getTKP";
                listTK.DataSource = ConnectDB.Connected.getData(query);
            }
            if (state == "Giao vien")
            {
                query = "exec getTKGV";
                listTK.DataSource = ConnectDB.Connected.getData(query);
            }
        }

        private void TKP_Click(object sender, EventArgs e)
        {
            state = "Phong";
            string query = "exec getTKP";
            DataTable dt =   ConnectDB.Connected.getData(query);
            listTK.DataSource = dt;
            fillter.Enabled = true;
           
        }
        public void Enable()
        {
            ID.Enabled = false;
            Password.Enabled = false;
            username.Enabled = false;
            Ma.Enabled = false;
            addTK.Enabled = false;
            edit.Enabled = false;
            cancel.Enabled = false;
            delete.Enabled = false;
        }
        private void TKK_Click(object sender, EventArgs e)
        {
            state = "Khoa";
            string query = "exec getTKK";
            DataTable dt = ConnectDB.Connected.getData(query);
            listTK.DataSource = dt;
            fillter.Enabled=true;
            ID.Text = "";
            Ma.Text = "";
            Password.Text = "";
            username.Text = "";
            Enable();
        }

        private void TKBM_Click(object sender, EventArgs e)
        {
            state = "Bo mon";
            string query = "exec getTKBM";
            DataTable dt = ConnectDB.Connected.getData(query);
            listTK.DataSource = dt;
            fillter.Enabled = true;
            ID.Text = "";
            Ma.Text = "";
            Password.Text = "";
            username.Text = "";
            Enable();
        }

        private void TKGV_Click(object sender, EventArgs e)
        {
            state = "Giao vien";
            string query = "exec getTKGV";
            DataTable dt = ConnectDB.Connected.getData(query);
            listTK.DataSource = dt;
            fillter.Enabled=true;
            ID.Text = "";
            Ma.Text = "";
            Password.Text = "";
            username.Text = "";
            Enable();
        }

      
        private void fillter_Click(object sender, EventArgs e)
        {
            string query = "";
            if(state == "Khoa")
            {
                query = "exec filter_TKK";
                listTK.DataSource = ConnectDB.Connected.getData(query);
                fillter.Enabled=false;
            }
            if(state =="Bo mon")
            {
                query = "exec filter_TKBM";
                listTK.DataSource = ConnectDB.Connected.getData(query);
                fillter.Enabled = false;
            }
            if (state == "Phong")
            {
                query = "exec filter_TKP";
                listTK.DataSource = ConnectDB.Connected.getData(query);
                fillter.Enabled = false;
            }
            if(state=="Giao vien")
            {
                query = "exec filter_TKGV";
                listTK.DataSource = ConnectDB.Connected.getData(query);
                fillter.Enabled = false;
            }
        }

        private void Cell_click(object sender, DataGridViewCellEventArgs e)
        {
           
            int index = e.RowIndex;
            DataGridViewRow selectedRow = listTK.Rows[index];
            string MA = selectedRow.Cells[1].Value.ToString().Trim();
            string id = selectedRow.Cells[0].Value.ToString().Trim();
            string UserName = selectedRow.Cells[2].Value.ToString().Trim();
            string password = selectedRow.Cells[3].Value.ToString().Trim();
            Ma.Text = MA;
            Ma.Enabled = false;
            ID.Text = id;
            ID.Enabled = false;
            username.Text = UserName;
            Password.Text = password;
            Password.Enabled = true;
            username.Enabled = true;
            cancel.Enabled = true;
            
            if(password=="" && UserName == ""){
                addTK.Enabled = true;
                edit.Enabled =false;
                delete.Enabled = false;
            }
            else
            {
                edit.Enabled = true;
                delete.Enabled = true;
                addTK.Enabled = false;
            }
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = "exec delete_TK '" + username.Text + "'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Xóa"));
            getListTK();
            ID.Text = "";
            Ma.Text = "";
            Password.Text = "";
            username.Text = "";
            Enable();
        }
        public bool checkUser()
        {
            string query = "exec getAllUserName";
            DataTable dt = ConnectDB.Connected.getData(query);
            foreach (DataRow dr in dt.Rows)
            {
               
               if(username.Text == dr[0].ToString().Trim())
                {
                    return false;
                }
            }
            return true;
        }
        private void addTK_Click(object sender, EventArgs e)
        {
            string query = "";
            if (checkUser()==true)
            {
                if (Password.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu");
                }
                else
                {
                    query = "exec addUser '" + username.Text + "','" + Password.Text + "','" + ID.Text + "'";
                    MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Thêm"));
                    getListTK();
                    ID.Text = "";
                    Ma.Text = "";
                    Password.Text = "";
                    username.Text = "";
                    Enable();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại");
            }

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            ID.Text = "";
            Ma.Text = "";
            Password.Text = "";
            username.Text = "";
            Enable();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            string query = "exec addUser '"+username.Text+"','"+Password.Text+"','"+ID.Text+"'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Cập nhập"));
            getListTK();
        }
    }
}
