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
                MenuVertical.Visible = false;
                MenuVertical.Width = 70;
                btnHd.Text = "";
                btnAddTK.Text = "";
                btnKhoa.Text = "";
                btnSetting.Text = "";
                btnQdt.Text = "";
                bunifuTransition1.ShowSync(MenuVertical);
            }
            else
            {
                MenuVertical.Visible = false;
                MenuVertical.Width = 250;
                btnHd.Text = "             Hội đồng nghiệm thu";
                btnAddTK.Text = "   Thêm tài khoản";
                btnKhoa.Text = "      Danh sách khoa";
                btnSetting.Text = "                 Cài đặt";
                btnQdt.Text = "       Danh sách đề tài";
                bunifuTransition1.ShowSync(MenuVertical);
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
            openChilForm(new QLTK.QLTK());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            showSubMenu(SubMenu);
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddTK_Click(object sender, EventArgs e)
        {
            openChilForm(new QLTK.QLTK());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new Login.Login();
            login.Show();
        }

        private void panelChildForm_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void lblcorreo_Click(object sender, EventArgs e)
        {

        }

        private void lbluser_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

        private void btnHd_Click(object sender, EventArgs e)
        {

        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {

        }

        private void btnlogoInicio_Click(object sender, EventArgs e)
        {

        }
    }
}
