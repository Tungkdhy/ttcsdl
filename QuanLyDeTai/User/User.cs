using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.User
{
    public partial class User : Form
    {
        public static string MaGV; 
        public User(string maGV)
        {   
            MaGV = maGV;
            InitializeComponent();
            customiDegsin();
            
        }
        private void customiDegsin()
        {
            SubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (SubMenu.Visible == true)
            {
                SubMenu.Visible = false;
            }
        }
        private void showSubMenu(Panel Menu)
        {
            if(Menu.Visible == false)
            {
                hideSubMenu();
                Menu.Visible = true;
            }
            else
            {
                Menu.Visible = false;
            }
        }
        
        private void Setting_Click(object sender, EventArgs e)
        {
            showSubMenu(SubMenu);

        }
        private Form activeForm = null;
        private void openChilForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void List_Click(object sender, EventArgs e)
        {

            openChilForm(new ListResearch.ListResearch(MaGV));
            header.Text = "Danh sách đề tài tham gia";
        }

        private void Infor_Click(object sender, EventArgs e)
        {
            openChilForm(new Infor.Infor(MaGV));
            header.Text = "Thông tin giáo viên";
        }
        private void ChangePassword_Click(object sender, EventArgs e)
        {
            openChilForm(new Setting.ChangePassword(MaGV));
            header.Text = "Đổi mật khẩu";
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Form login = new Login.Login();
            this.Hide();
            login.Show();
        }

        private void New_Click(object sender, EventArgs e)
        {
            openChilForm(new New.New(MaGV));
            header.Text = "Danh sách các bài báo";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dangky_Click(object sender, EventArgs e)
        {
            openChilForm(new AddResearch.AddReseach(MaGV));
            header.Text = "Đăng ký đề tài";
        }
    }
}
