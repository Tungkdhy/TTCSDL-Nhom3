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
    public partial class HDNT : Form
    {
        private string MAHD;
        private string MaKhoa;
        public HDNT()
        {
            InitializeComponent();
            getListHD();
            getAllMK();
            TV.Enabled = false;
            DSDT.Enabled = false;
            edit.Enabled = false;
            xoa.Enabled = false;
            
        }
        private void getListHD()
        {
            string query = "exec prd_pkhcn_danhsachHD";
            listHD.DataSource = ConnectDB.Connected.getData(query);
        }
        private void getAllMK()
        {
            string query = "pkhcn_getAllMaKhoa";
            DataTable dt = ConnectDB.Connected.getData(query);
            foreach(DataRow dr in dt.Rows)
            {
                MK.Items.Add(dr[0].ToString());
            }
        }
        private void Cap_TextChanged(object sender, EventArgs e)
        {

        }

        private void TV_Click(object sender, EventArgs e)
        {
            Form ListTV = new modal(MAHD,MaKhoa);
            ListTV.ShowDialog();
        }

        private void listHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = listHD.Rows[index];
                MAHD = selectedRow.Cells[0].Value.ToString().Trim();
                string SQD = selectedRow.Cells[1].Value.ToString().Trim();
                string cap = selectedRow.Cells[2].Value.ToString().Trim();
                MaKhoa = selectedRow.Cells[3].Value.ToString().Trim();
                Ma.Text = MAHD;
                MK.Text = MaKhoa;
                SQDTL.Text = SQD;
                Cap.Text = cap;
                addHD.Enabled = false;
                edit.Enabled = true;
                xoa.Enabled = true;
                TV.Enabled = true;
                DSDT.Enabled = true;
            }
            catch
            {

            }
        }

        private void addHD_Click(object sender, EventArgs e)
        {
            string query = "prd_pkhcn_themHD '" + Ma.Text + "',N'" + SQDTL.Text + "',N'" + Cap.Text + "',N'" + MK.Text + "'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Thêm"));
            getListHD();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string query = "prd_pkhcn_xoaHD '"+ MAHD + "'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Xóa"));
            getListHD();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            string query = "pkhcn_suaHD '"+ MAHD + "',N'"+Cap.Text+"','"+MK.Text+"',N'"+SQDTL.Text+"'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Sửa"));
            getListHD();
        }

        private void DSDT_Click(object sender, EventArgs e)
        {
            Form DT = new ListDT(MAHD,MaKhoa);
            DT.ShowDialog();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
