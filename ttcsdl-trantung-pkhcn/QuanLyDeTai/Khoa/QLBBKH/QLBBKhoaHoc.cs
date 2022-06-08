using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuanLyDeTai.Khoa.QLBBKH
{
    public partial class QLBBKhoaHoc : Form
    {
        public static string MaKhoa = "";
        public static string current_link = "";
        public QLBBKhoaHoc(string makhoa)
        {
            MaKhoa = makhoa;
            InitializeComponent();
            getListBBKH();
        }
        private void getListBBKH()
        {
            string query = "exec pro_Khoa_getAllScientificArtical '"+MaKhoa+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            ListBBKH.DataSource = dt;
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            string query = "";

            if (cmbChuyenNganh.Text == "" && cmbTapChi.Text == "")
            {
                query = "exec pro_Khoa_getAllScientificArtical '" + MaKhoa + "'";

            }
            else if (cmbChuyenNganh.Text != "" && cmbTapChi.Text == "")
            {
                query = "exec proc_khoa_getBBtheoCN N'" + cmbChuyenNganh.Text + "', '" + MaKhoa + "'";
            }
            else if (cmbChuyenNganh.Text == "" && cmbTapChi.Text != "")
            {
                query = "exec proc_khoa_getBBtheoTC N'" + cmbTapChi.Text + "', '" + MaKhoa + "'";
            }
            else
            {
                query = "exec proc_khoa_getBBtheoTCCN N'" + cmbTapChi.Text + "',N'" + cmbChuyenNganh.Text + "', '" + MaKhoa + "'";
            }
            DataTable dt = ConnectDB.Connected.getData(query);
            ListBBKH.DataSource = dt;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            cmbChuyenNganh.Items.Clear();
            cmbTapChi.Items.Clear();
            
            string query_get_cn = "exec proc_Khoa_getChuyenNganhBBKH '"+MaKhoa+"'";
            DataTable dt1 = ConnectDB.Connected.getData(query_get_cn);
            foreach (DataRow dr in dt1.Rows)
            {
                cmbChuyenNganh.Items.Add(dr[0].ToString());
            }
            string query_get_tc = "exec proc_Khoa_getTapChiBBKH '"+MaKhoa+"'";
            DataTable dt2 = ConnectDB.Connected.getData(query_get_tc);
            foreach (DataRow dr in dt2.Rows)
            {
                cmbTapChi.Items.Add(dr[0].ToString());
            }
            
            panelLoc.Visible = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            panelLoc.Visible = false;
        }

        private void searchArt_TextChanged(object sender, EventArgs e)
        {
            string query = "";
            string searchArt = txtsearchArt.Text;
            if (cmbChuyenNganh.Text == "" && cmbTapChi.Text == "")
            {
                query = "exec pro_Khoa_getAllScientificArtical '" + MaKhoa + "'";

            }
            else if (cmbChuyenNganh.Text != "" && cmbTapChi.Text == "")
            {
                query = "exec proc_khoa_getBBtheoCN N'"+cmbChuyenNganh.Text+"', '"+MaKhoa+"'";
            }
            else if (cmbChuyenNganh.Text == "" && cmbTapChi.Text != "")
            {
                query = "exec proc_khoa_getBBtheoTC N'" + cmbTapChi.Text + "', '" + MaKhoa + "'";
            }
            else
            {
                query = "exec proc_khoa_getBBtheoTCCN N'"+cmbTapChi.Text+"',N'"+cmbChuyenNganh.Text+"', '"+MaKhoa+"'";
            }
            try
            {
                DataTable dt = ConnectDB.Connected.getData(query);
                ListBBKH.DataSource = dt;
                var re = from row in dt.AsEnumerable()
                         where row[1].ToString().ToLower().Contains(searchArt.ToLower())
                         select row;
                ListBBKH.DataSource = re.CopyToDataTable();
            }
            catch
            {

            }
        }

        private void btn_xemBB_khoa_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(current_link);
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void ListBBKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = ListBBKH.Rows[e.RowIndex];
                current_link = Convert.ToString(row.Cells["Link"].Value);
                panel_BB_footer.Visible = true;
            }
            catch
            {

            }

        }
    }
}
