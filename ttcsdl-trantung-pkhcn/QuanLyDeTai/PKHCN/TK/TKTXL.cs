using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.PKHCN.TK
{
    public partial class TKTXL : Form
    {
        public TKTXL()
        {
            InitializeComponent();
            getYearDT();
            getTenKhoa();
            TKAllDT();
        }
        private void TKAllDT()
        {
            TK.Titles.Clear();
            string query = "prd_pkhcn_thongkeKQDTALL";
            DataTable dt = ConnectDB.Connected.getData(query);
            TKXL.DataSource = dt;
            TK.DataSource = dt;
            TK.Series["Series1"].XValueMember = "Kết quả";
            TK.Series["Series1"].YValueMembers = "Số lượng";
            TK.Titles.Add("TKXL");
            Nam.Text = "All";
            tenKhoa.Text = "All";
        }
        private void getYearDT()
        {
            Nam.Items.Clear();
            Nam.Items.Add("All");
            string query = "getYearDT";
            DataTable year = ConnectDB.Connected.getData(query);
            foreach (DataRow row in year.Rows)
            {
                Nam.Items.Add(row[0]);

            }
        }
        private void getTenKhoa()
        {
            tenKhoa.Items.Clear();
            tenKhoa.Items.Add("All");
            string query = "pkhcn_getTenKhoa";
            DataTable year = ConnectDB.Connected.getData(query);
            foreach (DataRow row in year.Rows)
            {
                tenKhoa.Items.Add(row[0]);

            }
        }
        private void Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Nam.Text=="All" && tenKhoa.Text != "All")
            {
                TK.Titles.Clear();
                string query = "prd_pkhcn_thongkeKQDTK N'" + tenKhoa.Text + "'";
                DataTable dt = ConnectDB.Connected.getData(query);
                TKXL.DataSource = dt;
                TK.DataSource = dt;
                TK.Series["Series1"].XValueMember = "Kết quả";
                TK.Series["Series1"].YValueMembers = "Số lượng";
                TK.Titles.Add("TKXL");
            }
            if (tenKhoa.Text == "All" && Nam.Text == "All")
            {
                TKAllDT();
            }
            if (tenKhoa.Text == "All" && Nam.Text != "All")
            {
                TK.Titles.Clear();
                string query = "prd_pkhcn_thongkeKQDT '"+Nam.Text+"'";
                DataTable dt = ConnectDB.Connected.getData(query);
                TKXL.DataSource = dt;
                TK.DataSource = dt;
                TK.Series["Series1"].XValueMember = "Kết quả";
                TK.Series["Series1"].YValueMembers = "Số lượng";
                TK.Titles.Add("TKXL");
              
            }
            else if(Nam.Text != "All")
            {
                TK.Titles.Clear();
                string query = "prd_pkhcn_thongkeKQDTKhoa '" + Nam.Text + "',N'"+tenKhoa.Text+"'";
                DataTable dt = ConnectDB.Connected.getData(query);
                TKXL.DataSource = dt;
                TK.DataSource = dt;
                TK.Series["Series1"].XValueMember = "Kết quả";
                TK.Series["Series1"].YValueMembers = "Số lượng";
                TK.Titles.Add("TKXL");
                
            }
        }

        private void tenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Nam.Text != "All" && tenKhoa.Text == "All")
            {
                TK.Titles.Clear();
                string query = "prd_pkhcn_thongkeKQDT '" + Nam.Text + "'";
                DataTable dt = ConnectDB.Connected.getData(query);
                TKXL.DataSource = dt;
                TK.DataSource = dt;
                TK.Series["Series1"].XValueMember = "Kết quả";
                TK.Series["Series1"].YValueMembers = "Số lượng";
                TK.Titles.Add("TKXL");
            }
            if(tenKhoa.Text =="All" && Nam.Text == "All")
            {
                TKAllDT();
            }
            if (Nam.Text == "All" && tenKhoa.Text !="All")
            {
                TK.Titles.Clear();
                string query = "prd_pkhcn_thongkeKQDTK N'" + tenKhoa.Text + "'";
                DataTable dt = ConnectDB.Connected.getData(query);
                TKXL.DataSource = dt;
                TK.DataSource = dt;
                TK.Series["Series1"].XValueMember = "Kết quả";
                TK.Series["Series1"].YValueMembers = "Số lượng";
                TK.Titles.Add("TKXL");

            }
            else if (tenKhoa.Text != "All")
            {
                TK.Titles.Clear();
                string query = "prd_pkhcn_thongkeKQDTKhoa '" + Nam.Text + "',N'" + tenKhoa.Text + "'";
                DataTable dt = ConnectDB.Connected.getData(query);
                TKXL.DataSource = dt;
                TK.DataSource = dt;
                TK.Series["Series1"].XValueMember = "Kết quả";
                TK.Series["Series1"].YValueMembers = "Số lượng";
                TK.Titles.Add("TKXL");

            }
        }

        private void xuatKQ_Click(object sender, EventArgs e)
        {
            string nam = Nam.Text;
            string TenKhoa = tenKhoa.Text;
            //Form bc = new XuatKQ(nam,TenKhoa);
            //bc.ShowDialog();
        }
    }
}
