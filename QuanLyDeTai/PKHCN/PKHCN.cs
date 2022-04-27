using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.PKHCN
{
    public partial class PKHCN : Form
    {
        public PKHCN(string MP)
        {
            InitializeComponent();
            customiDegsin();
        }
        private void customiDegsin()
        {
            SubMenu.Visible = false;
            TkSubMenu.Visible = false;
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
            if (Menu.Visible == false)
            {
                hideSubMenu();
                Menu.Visible = true;
            }
            else
            {
                Menu.Visible = false;
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
                btnTK.Text = "";
                btnHd.Text = "";
                btnKhoa.Text = "";
                btnSetting.Text = "";
                btnQdt.Text = "";
            }
            else
            {
                MenuVertical.Width = 250;
<<<<<<< HEAD
                btnTK.Text = "      Thêm tài khoản";
                btnHd.Text = "                Hội đồng nghiệm thu";
                btnKhoa.Text = "         Danh sách khoa";
                btnSetting.Text = "                  Cài đặt";
                btnQdt.Text = "          Danh sách đề tài";
                bunifuTransition1.ShowSync(MenuVertical);
=======
                btnAddTK.Text = "   Thêm tài khoản";
                btnHd.Text = "             Hội đồng nghiệm thu";
                btnKhoa.Text = "      Danh sách khoa";
                btnSetting.Text = "                 Cài đặt";
                btnQdt.Text = "       Danh sách đề tài";
>>>>>>> 89a08604afcc705e384dc006571b64e01c3bef7c
            }
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
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnQdt_Click(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            showSubMenu(SubMenu);
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            showSubMenu(TkSubMenu);
<<<<<<< HEAD
          
=======
>>>>>>> 89a08604afcc705e384dc006571b64e01c3bef7c
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }
<<<<<<< HEAD

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            openChilForm(new DSKhoa.DSK());
        }

        private void btnAddTK_Click(object sender, EventArgs e)
        {
            
            openChilForm(new ThongKe.ThongKe());
        }

        private void btnHd_Click(object sender, EventArgs e)
        {
            openChilForm(new HD.HD());
        }
=======
>>>>>>> 89a08604afcc705e384dc006571b64e01c3bef7c
    }
}
