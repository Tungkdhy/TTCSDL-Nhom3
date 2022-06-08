using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.PKHCN.QLCN
{
    public partial class QLCN : Form
    {
        private string MADT;
        private string MAGV;
        private string tenDT;
        private string MaKhoa;
        string state;
        public QLCN()
        {
            InitializeComponent();
            getCNResearch();
            getGVKTGDT();
            btnReturn.Visible = false;
            BB.Enabled = false;
            DTTG.Enabled = false;
         
        }
        private void getCNResearch()
        {
        
            string query = "pkhcn_lay_gvTGDT";
            listCN.DataSource = ConnectDB.Connected.getData(query);
        }        
        private void getGVKTGDT()
        {
            ListGV.Items.Clear();
            string query = "pkhcn_lay_mk_tenK";
            DataTable listMGV = ConnectDB.Connected.getData(query);
            foreach (DataRow row in listMGV.Rows)
            {
                ListGV.Items.Add(row[0].ToString().Trim() +'-'+row[1].ToString());
            }
        }
  
        private void Test_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = "pkhcn_delete_cn '" + MADT + "'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Xóa"));

            getCNResearch();
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = listCN.Rows[index];
                MAGV = selectedRow.Cells[0].Value.ToString().Trim();
  
                BB.Enabled=true;
                DTTG.Enabled=true;
            }
            catch
            {
              
                BB.Enabled = false;
                DTTG.Enabled = false;
            }
        }

        private void detail_Click(object sender, EventArgs e)
        {
           
            
        }

        private void BB_Click(object sender, EventArgs e)
        {
            string query = "getAllBBByMGV '" + MAGV + "'";
            DataTable data = ConnectDB.Connected.getData(query);
            if (data.Rows.Count > 0)
            {
                state = "BB";
                Form tv = new modal(MAGV, state);
                tv.ShowDialog();

            }
            else
            {
                MessageBox.Show("Giáo viên chưa có bài báo");
            }

            
        }

        private void DTTG_Click(object sender, EventArgs e)
        {
            string query = "getAllDTByMagv '" + MAGV + "'";
            DataTable dt = ConnectDB.Connected.getData(query);
            if (dt.Rows.Count > 0)
            {
                state = "DT";
                Form tv = new modal(MAGV, state);
                tv.ShowDialog();

            }
            else
            {
                MessageBox.Show("Giáo viên chưa tham gia đề tài");
            }
            
        }

        private void ListGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (state == "GV")
            {

            string MAKHOA = ListGV.Text.Split('-')[0];
            string TenKhoa = ListGV.Text.Split('-')[1];
            string query = "prd_pkhcn_getAllStaff '" + MAKHOA + "'";
            DataTable dt = ConnectDB.Connected.getData(query);
            if (dt.Rows.Count > 0)
            {
                listCN.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Khoa " + TenKhoa + " không có thành viên tham gia đề tài");

            }
            }
            else
            {
                string query = "proc_pkhcn_getCNNN '" + ListGV.Text.Split('-')[0] + "'";
                listCN.DataSource = ConnectDB.Connected.getData(query);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            lbGVTGDT.Text = "Giáo viên tham gia đề tài";
            btnReturn.Visible = false;
            state = "GV";
            BB.Enabled = false;
            DTTG.Enabled = false;
            getCNResearch();
        }

        private void btnDSCN_Click(object sender, EventArgs e)
        {
            state = "CN";
            string query = "proc_pkhcn_getCNNN '" + ListGV.Text.Split('-')[0] + "'";
            listCN.DataSource = ConnectDB.Connected.getData(query);
            btnReturn.Visible = true;
            lbGVTGDT.Text = "Danh sách chủ nhiệm";
        }

        private void Khoa_Click(object sender, EventArgs e)
        {

        }
    }
}
