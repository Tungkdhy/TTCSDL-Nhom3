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
   
    public partial class modal : Form
    {
        private string MaHD;
        private string MaMK;
        private string MATV;
        public modal(string mahd,string makhoa)
        {
            InitializeComponent();
            MaHD = mahd;
            MaMK = makhoa;
            getDSTVHD();
            getNameKhoa();
            getListMAGV();
            TenKhoa.Enabled = false;
            MHD.Enabled = false;
            MHD.Text = mahd;
        }
        private void getDSTVHD()
        {
            string query = "pkhcn_getTVBYMHD '"+MaHD+"'";
            listTV.DataSource = ConnectDB.Connected.getData(query);

        }
        private void getListMAGV()
        {
            listMAGV.Items.Clear();
            string query = "getGVKTGDTBYMK '" + MaMK+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[1].ToString().Trim()!="Chủ nhiệm khoa" && dr[1].ToString().Trim() != "Chủ nhiệm")
                {

                    listMAGV.Items.Add(dr[0].ToString());
                }
            }
            
        }
        private void getNameKhoa()
        {
            string query = "pkhcn_lay_ten_khoa '" + MaMK + "'";
            DataTable dt = ConnectDB.Connected.getData(query);
            TenKhoa.Text = dt.Rows[0][0].ToString();
        }
        private void getNameGV()
        {
            string query = "pkhcn_lay_ten_gv '"+listMAGV.Text+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            name.Text = dt.Rows[0][0].ToString();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string query = "prd_pkhcn_themGV_vaoHD '"+MaHD+"','"+listMAGV.Text+"','"+Vaitro.Text+"'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Thêm"));
            getDSTVHD();
            Vaitro.Text = "";
            listMAGV.SelectedItem = null;
            getListMAGV();
        }

        private void listMAGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listMAGV.Text != "")
            {
                getNameGV();

            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string query = "prd_pkhcn_xoaGV_khoiHD '" + MaHD + "','" + MATV + "'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Xóa"));
            getDSTVHD() ;
            getListMAGV();
        }

        private void listTV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = listTV.Rows[index];
            if(selectedRow.Cells["Vai trò"].Value.ToString()=="Chủ tịch")
            {
                MessageBox.Show("Không thể xóa chủ tịch của hội đồng");
            }
            MATV = selectedRow.Cells["Mã giáo viên"].Value.ToString();
        }
    }
}
