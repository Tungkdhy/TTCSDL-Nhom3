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
            Enable();
            getListTK();

        }
        public void getListTK()
        {
            string query = " pkhcn_getAllTK ";
            listTK.DataSource = ConnectDB.Connected.getData(query);
        }
        private void getListKhoa()
        {
            TenKhoa.Items.Clear();
            string query = "pkhcn_getTenKhoa";
            DataTable dt = ConnectDB.Connected.getData(query);
            foreach (DataRow dr in dt.Rows)
            {
                TenKhoa.Items.Add(dr[0].ToString());
            }
        }
        private void getTenBMBYMK()
        {
            TenBM.Items.Clear();
            string query = "pkhcn_getTenBm N'"+TenKhoa.Text+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            foreach(DataRow dr in dt.Rows)
            {
                TenBM.Items.Add(dr[0].ToString());
            }
        }
        private void getTenGVByMBM()
        {
            TenGV.Items.Clear();
            string query = "getTenGVbyBM N'"+TenBM.Text+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            foreach(DataRow dr in dt.Rows)
            {
                TenGV.Items.Add(dr[0].ToString().Trim()+ " - "+dr[1].ToString());
            }
        }

        public void Enable()
        {
         
            Password.Enabled = false;
            username.Enabled = false;
            addTK.Enabled = false;
            edit.Enabled = false;
            delete.Enabled = false;
        }
    
        public bool checkUser()
        {
            string query = "pkhcn_getAllUser";
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
        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = listTK.Rows[index];
                string MA = selectedRow.Cells[1].Value.ToString().Trim();
                string UserName = selectedRow.Cells[0].Value.ToString().Trim();
                string password = selectedRow.Cells[1].Value.ToString().Trim();
                TenKhoa.Text = MA;
                TenKhoa.Enabled = false;

                username.Text = UserName;
                Password.Text = password;
                Password.Enabled = true;
                username.Enabled = true;


                if (password == "" && UserName == "")
                {
                    addTK.Enabled = true;
                    edit.Enabled = false;
                    delete.Enabled = false;
                }
                else
                {
                    edit.Enabled = true;
                    delete.Enabled = true;
                    addTK.Enabled = false;
                }
            }
            catch
            {

            }
        }

        private void addTK_Click_1(object sender, EventArgs e)
        {
            
            if (checkUser() == true)
            {
                if (username.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tài khoản");
                }
                if (Password.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu");
                }
                else
                {
                    if(state == "PKHCN")
                    {
                        string query = "pkhcn_add_tk '"+username.Text+"','"+Password.Text+"',null,'4'";
                        MessageBox.Show(query);
                        MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Thêm"));
                        getListTK();
                    }
                    if(state == "Khoa")
                    {
                        MessageBox.Show(TenKhoa.Text);
                        string query = "select MaCN from Khoa where TenKhoa = N'"+TenKhoa.Text+"'";
                        string MAGV = ConnectDB.Connected.getData(query).Rows[0][0].ToString();
                        MessageBox.Show(MAGV);
                        string query1 = "pkhcn_add_tk '"+username.Text+"','"+Password.Text+"','"+MAGV+"','3'";
                        MessageBox.Show(ConnectDB.Connected.ChangeData(query1,"Thêm"));
                        getListTK();
                    }
                    if(state == "Bộ môn")
                    {
                        string query = "select MaCN from BOMON where TenBM = N'" + TenBM.Text + "'";
                        string MAGV = ConnectDB.Connected.getData(query).Rows[0][0].ToString();
                        string query1 = "pkhcn_add_tk '" + username.Text + "','" + Password.Text + "','" + MAGV + "','2'";
                        
                        MessageBox.Show(ConnectDB.Connected.ChangeData(query1, "Thêm"));
                        getListTK();
                    }
                    if (state =="Giáo viên")
                    {
                        string MAGV = TenGV.Text.Split('-')[0].Trim();
                        string query = "pkhcn_add_tk '" + username.Text + "','" + Password.Text + "','"+ MAGV + "','1'";
                        MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Thêm"));
                        getListTK();
                    }
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại");
            }
        }

        private void edit_Click_1(object sender, EventArgs e)
        {
            string query = "pkhcn_sua_tk '"+username.Text+"','"+Password.Text+"'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query,"Sửa"));
            getListTK();
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            string query = "exec pkhcn_xoa_TK '" + username.Text + "'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Xóa"));
            getListTK();
            Password.Text = "";
            username.Text = "";
            Enable();
        }

        private void cancel_Click_1(object sender, EventArgs e)
        {

        }

        private void fillter_Click_1(object sender, EventArgs e)
        {
            string query = "";
            if (state == "Khoa")
            {
                query = "exec filter_TKK";
                listTK.DataSource = ConnectDB.Connected.getData(query);
               
            }
            if (state == "Bo mon")
            {
                query = "exec filter_TKBM";
                listTK.DataSource = ConnectDB.Connected.getData(query);
              
            }
            if (state == "Phong")
            {
                query = "exec filter_TKP";
                listTK.DataSource = ConnectDB.Connected.getData(query);
             
            }
            if (state == "Giao vien")
            {
                query = "exec filter_TKGV";
                listTK.DataSource = ConnectDB.Connected.getData(query);
              
            }
        }

        private void TKGV_Click_1(object sender, EventArgs e)
        {
            state = "Giao vien";
            string query = "exec getTKGV";
            DataTable dt = ConnectDB.Connected.getData(query);
            listTK.DataSource = dt;
          
            TenKhoa.Text = "";
            Password.Text = "";
            username.Text = "";
          
            Password.Enabled = true;
            username.Enabled = true;
            TenKhoa.Enabled = true;
            addTK.Enabled = true;

        }

        private void TKBM_Click_1(object sender, EventArgs e)
        {
            state = "Bo mon";
            string query = "exec getTKBM";
            DataTable dt = ConnectDB.Connected.getData(query);
            listTK.DataSource = dt;
          
           
            TenKhoa.Text = "";
            Password.Text = "";
            username.Text = "";
           
            Password.Enabled = true;
            username.Enabled = true;
            TenKhoa.Enabled = true;
            addTK.Enabled = true;
        }

      

        private void TKK_Click_1(object sender, EventArgs e)
        {
            state = "Khoa";
            string query = "exec getTKK";
            DataTable dt = ConnectDB.Connected.getData(query);
            listTK.DataSource = dt;
          
        
            TenKhoa.Text = "";
            Password.Text = "";
            username.Text = "";
          
            Password.Enabled = true;
            username.Enabled = true;
            TenKhoa.Enabled = true;
            addTK.Enabled = true;
        }

        private void TKP_Click_1(object sender, EventArgs e)
        {
            state = "Phong";
            string query = "exec getTKP";
            DataTable dt = ConnectDB.Connected.getData(query);
            listTK.DataSource = dt;
            
        }

        private void guna2GradientButton1_MouseHover(object sender, EventArgs e)
        {
         
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void select_SelectedIndexChanged(object sender, EventArgs e)
        {
            state = "PKHCN";
            Password.Text = "";
            username.Text = "";
            edit.Enabled = false;
            delete.Enabled = false;
            Password.Enabled = true;
            username.Enabled=true;
            addTK.Enabled=true;
            if(select.Text != "PKHCN")
            {

                getListKhoa();
                if(select.Text == "Khoa")
                {
                    state = "Khoa";
                   TenKhoa.Enabled=true;
                    TenBM.Enabled=false;
                    TenGV.Enabled=false;
                }
                if(select.Text =="Bộ môn")
                {

                    state = "Bộ môn";
                    TenKhoa.Enabled=true;
                    TenGV.Enabled=false;
                    TenBM.Enabled=true;
                }
                if(select.Text=="Giáo viên")
                {
                    state = "Giáo viên";
                    TenKhoa.Enabled = true;
                    TenBM.Enabled = true;
                    TenGV.Enabled=true;
                }
            }
        }

        private void TenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            getTenBMBYMK();
        }

        private void TenBM_SelectedIndexChanged(object sender, EventArgs e)
        {
            getTenGVByMBM();
        }

        private void guna2HtmlLabel16_Click(object sender, EventArgs e)
        {

        }
    }
}
