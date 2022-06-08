using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.PKHCN.QuanLyDT
{
    public partial class TVTG : Form
    {
        private string maDT;
        public TVTG(string Ma)
        {
            maDT=Ma;
            InitializeComponent();
            getInfoDT();
            getTV();
            
        }
        private void getInfoDT()
        {
            string query = "pkhcn_lay_tt_dt '" + maDT + "'";
            DataTable dt = ConnectDB.Connected.getData(query);
            ma.Text = "Mã đề tài: " + maDT;
            TenDT.Text = "Tên đề tài: " + dt.Rows[0][11];
            CN.Text = "Chuyên ngành: "+dt.Rows[0][1];
            Cap.Text = "Cấp: " + dt.Rows[0][2];
            NBD.Text = "Ngày bắt đầu: "+ dt.Rows[0][3].ToString().Split(' ')[0];
            NNT.Text = "Ngày nghiệm thu: " + dt.Rows[0][4].ToString().Split(' ')[0];
            TT.Text = "Trạng thái: " + dt.Rows[0][5];
            SP.Text = "Sản phẩm: " + dt.Rows[0][6];
            TenBM.Text = "Bô môn: " + dt.Rows[0][7];
            TienDo.Text = "Tiến độ: " + dt.Rows[0][8];
            HD.Text = "Hội đồng: " + dt.Rows[0][9];
            XL.Text = "Xếp loại: " + dt.Rows[0][10];
            KP.Text = "Kinh phí: " + dt.Rows[0][12];
        }
        private void getBaiBao()
        {
            string query = "pkhcn_lay_bb_mdt '" + maDT + "'";
            tv.DataSource = ConnectDB.Connected.getData(query);
        }
       
        private void getTV()
        {
            string query = "getAllGVByMDT '"+maDT+"'";
            tv.DataSource = ConnectDB.Connected.getData(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DS.Text == "Danh sách thành viên")
            {
                getTV();
            }
            else
            {
                getBaiBao();
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SP_Click(object sender, EventArgs e)
        {

        }

        private void TT_Click(object sender, EventArgs e)
        {

        }

        private void tv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void XL_Click(object sender, EventArgs e)
        {

        }

        private void HD_Click(object sender, EventArgs e)
        {

        }

        private void TienDo_Click(object sender, EventArgs e)
        {

        }

        private void TenBM_Click(object sender, EventArgs e)
        {

        }

        private void KP_Click(object sender, EventArgs e)
        {

        }

        private void NNT_Click(object sender, EventArgs e)
        {

        }

        private void NBD_Click(object sender, EventArgs e)
        {

        }

        private void Cap_Click(object sender, EventArgs e)
        {

        }

        private void CN_Click(object sender, EventArgs e)
        {

        }

        private void TenDT_Click(object sender, EventArgs e)
        {

        }

        private void ma_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
