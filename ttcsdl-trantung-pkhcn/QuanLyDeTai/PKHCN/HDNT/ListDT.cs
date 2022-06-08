using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.PKHCN.HDNT
{
    public partial class ListDT : Form
    {
        private string mahd;
        private string mk; 
        private string mdt;
        public ListDT(string MaHD,string MaKhoa)
        {
            InitializeComponent();
            mahd = MaHD;
            mk = MaKhoa;
            getListDTHD();
            getTenKhoa();
            MHD.Text = MaHD;
            MHD.Enabled = false;
            TenKhoa.Enabled = false;
            getDTKHD();
            TDT.Enabled = false;
            edit.Enabled = false;
        }
        private void getListDTHD()
        {
            string query = "prd_pkhcn_danhsachDT_cuaHD '" + mahd + "'";
            DSDT.DataSource = ConnectDB.Connected.getData(query);
        }
        private void getTenKhoa()
        {
            string query = "pkhcn_lay_ten_khoa '" + mk + "'";
            DataTable dt = ConnectDB.Connected.getData(query);
            TenKhoa.Text = dt.Rows[0][0].ToString();
        }
        private void getDTKHD()
        {
            string query = "getDTKHD '"+mk+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            foreach(DataRow dr in dt.Rows)
            {
                selectMDT.Items.Add(dr[0].ToString());
            }
        }

        private void selectMDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "getTenDTbyMADT '"+selectMDT.Text+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            TDT.Text = dt.Rows[0][0].ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {

            string query = "pkhcn_get_cap_dt '" + selectMDT.Text + "'";
            string Cap = ConnectDB.Connected.getData(query).Rows[0][0].ToString();
            string query2 = " pkhcn_lay_dthd_ht '"+mahd+"'";
            DataTable dt = ConnectDB.Connected.getData(query2);
            if (dt.Rows.Count == 0)
            {

                if(Cap !="Học viện")
                {
                    MessageBox.Show("Bạn chỉ phép thêm đề tài cấp học viện vào hội đồng");
                }
                else
                {
                    string query1 = "pkhcn_them_dt_hoidong '"+selectMDT.Text+"','"+mahd+"'";
                    MessageBox.Show(ConnectDB.Connected.ChangeData(query1,"Thêm"));
                    getListDTHD();
                }
            }
            else
            {
                MessageBox.Show("Hội đồng đã có 1 đề tài");
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            string query = "prd_pkhcn_xoaDT_khoiHD '"+mahd+"','"+mdt+"'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Xóa"));
            getListDTHD();
        }

        private void DSDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = DSDT.Rows[index];
                mdt = selectedRow.Cells["Mã đề tài"].Value.ToString();
                edit.Enabled = true;
                XL.Visible = true;
                guna2Button1.Visible = true;
                guna2HtmlLabel6.Visible = true;
            }
            catch
            {

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string query = "pkhcn_nt_dt N'"+XL.Text+"',N'"+mdt+"'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Nghiệm thu"));
            XL.Visible = false;
            guna2Button1.Visible = false;
            guna2HtmlLabel6.Visible = false;
        }
    }
}
