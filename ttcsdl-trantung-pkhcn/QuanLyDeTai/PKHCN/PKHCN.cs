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
        private string user;
        public PKHCN(string userName)
        {
            user = userName;
            InitializeComponent();
            customiDegsin();
            openChilForm(new QuanLyDT.QLDT1());
        }
        private void customiDegsin()
        {
            SubMenu.Visible = false;
            panel2.Visible = false;
           
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
             
                btnQdt.Text = "";
                
            }
            else
            {
                MenuVertical.Visible = false;
                MenuVertical.Width = 250;
                btnHd.Text = "             Hội đồng nghiệm thu";
                btnAddTK.Text = "   Thêm tài khoản";
                btnKhoa.Text = "      Danh sách khoa";            
                btnQdt.Text = "       Danh sách đề tài";
          
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
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnQdt_Click(object sender, EventArgs e)
        {
            openChilForm(new QuanLyDT.QLDT1() );
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            showSubMenu(SubMenu);
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

        private void btnHd_Click(object sender, EventArgs e)
        {
            openChilForm(new HDNT.HDNT());
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
           openChilForm(new QLCN.QLCN());
        }

        private void btnBB_Click(object sender, EventArgs e)
        {
            openChilForm(new BBKH.BBKH());
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }

        private void KP_Click(object sender, EventArgs e)
        {
            openChilForm(new QuanLyKinhPhi.QLKP()); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChilForm(new TK.TK());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChilForm(new TK.TKTXL());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChilForm(new TK.TKSLBB());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChilForm(new User.Setting.ChangePassword(user));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new Login.Login();
            login.Show();
        }
    }
}
