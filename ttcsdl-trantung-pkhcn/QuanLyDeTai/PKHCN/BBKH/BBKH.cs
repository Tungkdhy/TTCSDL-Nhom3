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

namespace QuanLyDeTai.PKHCN.BBKH
{
    public partial class BBKH : Form
    {
        private string MaBB;
        private string tenBB;
        private string current_link;
        public static List<string> inforBB = new List<string>();
        public BBKH()
        {
            InitializeComponent();
            getListBB();
            getTenKhoa();
            getYear();
            getTC();
            getCN();
            btn_XemBB.Enabled = false;
            xemTV.Enabled = false;
        }

        private void getListBB()
        {
            string query = "exec getAllBB";
            listBB.DataSource = ConnectDB.Connected.getData(query);
        }
        private void getTenKhoa()
        {
            selectKhoa.Items.Clear();
            string query = "pkhcn_getTenKhoa";
            DataTable dt = ConnectDB.Connected.getData(query);
            foreach (DataRow dr in dt.Rows)
            {
                selectKhoa.Items.Add(dr[0].ToString());
            }
        }
        private void getTC()
        {
            selecTC.Items.Clear();
            string query = "pkhcn_get_tc";
            DataTable dt = ConnectDB.Connected.getData(query);
            foreach (DataRow dr in dt.Rows)
            {
                selecTC.Items.Add(dr[0].ToString());
            }
        }
        private void getCN()
        {
            selectCN.Items.Clear();
            string query = "pkhcn_get_chuyennganh";
            DataTable dt = ConnectDB.Connected.getData(query);
            foreach (DataRow dr in dt.Rows)
            {
                selectCN.Items.Add(dr[0].ToString());
            }
        }
        private void getYear()
        {
            selectNam.Items.Clear();
            string query = "pkhcn_get_year_bb";
            DataTable dt = ConnectDB.Connected.getData(query);
            foreach(DataRow dr in dt.Rows)
            {
                selectNam.Items.Add(dr[0].ToString());
            }
        }
        private void addBB_Click(object sender, EventArgs e)
        {
         
           
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = listBB.Rows[index];
                MaBB = selectedRow.Cells["Mã bài báo"].Value.ToString();
                tenBB = selectedRow.Cells["Tên bài báo"].Value.ToString();
                string MABB = selectedRow.Cells["Mã bài báo"].Value.ToString();
                string TenBB = selectedRow.Cells["Tên bài báo"].Value.ToString();
                string CN = selectedRow.Cells["Chuyên ngành"].Value.ToString();
                string NgayDang = selectedRow.Cells["Ngày đăng"].Value.ToString().Split()[0];
                string TapChi = selectedRow.Cells["Tạp chí"].Value.ToString();
                string MaDT = selectedRow.Cells["Mã dề tài"].Value.ToString();
                current_link = selectedRow.Cells["Link"].Value.ToString();
                MessageBox.Show(current_link);
                string[] dataGT = { MABB, TenBB, MaDT, CN, NgayDang, TapChi };
                inforBB.Clear();
                
                inforBB.AddRange(dataGT);
                btn_XemBB.Enabled = true;
                xemTV.Enabled = true;
                panel_BB_footer.Visible = true;
            }
            catch
            {

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = "exec prd_pkhcn_xoaBB '" + inforBB[0] + "'";
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa đề tài có mã:" + inforBB[0].Trim() + "", "Are you sure for", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show(ConnectDB.Connected.ChangeData(query, "xóa"));
            }
            else
            {

            }

            getListBB();
        }

        private void editBB_Click(object sender, EventArgs e)
        {
          
        }

        private void showFillter_Click(object sender, EventArgs e)
        {
            if (panel3.Visible)
            {
                panel3.Visible = false;
                getListBB();
            }
            else
            {
                panel3.Visible = true;
            }
        }

        private void fillter_Click(object sender, EventArgs e)
        {
            string query = "pkhcn_fillterBB N'" + selectKhoa.Text + "',N'" + selecTC.Text + "',N'" + selectCN.Text + "','"+selectNam.Text+"'";
            listBB.DataSource = ConnectDB.Connected.getData(query);
        }

        private void xemTV_Click(object sender, EventArgs e)
        {
            Form tacgia = new TacGia(MaBB,tenBB);
            tacgia.ShowDialog();
        }

        private void Xem_Click(object sender, EventArgs e)
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

        private void listBB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
