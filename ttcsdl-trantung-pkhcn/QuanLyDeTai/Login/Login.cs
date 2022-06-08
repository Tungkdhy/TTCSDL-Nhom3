using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyDeTai.Login
{
    public partial class Login : Form

    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        private string MaGV;
        private string Quyen;
        public Login()
        {
            InitializeComponent();
            
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
            /*SqlConnection conn = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QUANLY;Integrated Security=True");
            string userName = UserName.Text;
            string password = Password.Text;
            conn.Open();
            string query = "select * from NGUOIDUNG where UserName = '" + userName + "' and Passwords = '" + password + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            try
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string MaKhoa = dt.Rows[0][3].ToString().Trim();
                    string MaBM = dt.Rows[0][4].ToString().Trim();
                    string MP = dt.Rows[0][5].ToString().Trim();
                    string maGV = dt.Rows[0][6].ToString().Trim();

                    if (maGV!="")
                    {
                        Form Gv = new User.User(maGV);
                        MessageBox.Show("Đăng nhập thành công");
                        Gv.Show();
                        this.Hide();
                    }
                    if (MaKhoa != "")
                    {
                        Form MK = new Admin.Admin();
                        MessageBox.Show("Đăng nhập thành công");
                        MK.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("dang nhap that bai");
                }


            }
            catch
            {
                MessageBox.Show("dang nhap that bai");
            }*/
         
        //}


        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = UserName.Text;
            string password = Password.Text;
            string query = "NDDangNhap '" + userName + "','" + password + "'";
            DataTable dt = ConnectDB.Connected.getData(query);
            if (dt.Rows.Count > 0)
            {
                MaGV = dt.Rows[0][0].ToString();
                Quyen = dt.Rows[0][1].ToString();
                if (Quyen == "Giáo viên")
                {
                    Form User = new User.User(MaGV);
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    User.Show();
                }
                if (Quyen == "Admin")
                {
                    Form admin = new PKHCN.PKHCN(userName);
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    admin.Show();
                }
                if(Quyen=="Bộ môn")
                {
                    string query1 = "getMABM '"+MaGV+"'";
                    DataTable dt1 = ConnectDB.Connected.getData(query1);
                    string MABM = dt1.Rows[0][0].ToString();
                    Form bm = new BoMon.BoMon(MABM,MaGV,userName);
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    bm.Show();

                }
                if (Quyen == "Khoa")
                {
                    string query1 = "getMAKhOA '" + MaGV + "'";
                    DataTable dt1 = ConnectDB.Connected.getData(query1);
                    string MAKHOA = dt1.Rows[0][0].ToString();
                    Form khoa = new Khoa.Khoa(MAKHOA,MaGV);
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    khoa.Show();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản mật khẩu không chính xác");
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Password.PasswordChar = '\0';
            }
            else
            {
                Password.PasswordChar = '*'; 
            }
        }

        private void container_Click(object sender, EventArgs e)
        {

        }
    }
}
