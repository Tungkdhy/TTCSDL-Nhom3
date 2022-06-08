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
    public partial class TKSLBB : Form
    {
        public TKSLBB()
        {
            InitializeComponent();
            getYearBB();
            TKAllBB();
        }
        private void getYearBB()
        {
            yearBB.Items.Clear();
            yearBB.Items.Add("All");
            string query = "getYearBB";
            DataTable year = ConnectDB.Connected.getData(query);
            foreach (DataRow row in year.Rows)
            {
                yearBB.Items.Add(row[0]);
            }
        }
        private void TKAllBB()
        {
            string query = "prd_pkhcn_thongkeBBtheoKhoa";
            DataTable dt = ConnectDB.Connected.getData(query);
            tkBB.DataSource = dt;
            chartBB.DataSource = dt;
            chartBB.Series["Series2"].XValueMember = "TenKhoa";
            chartBB.Series["Series2"].YValueMembers = "SLBB";
            chartBB.Titles.Add("TKBB");
            yearBB.Text = "All";

        }
        private void yearBB_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartBB.Titles.Clear();
            if (yearBB.Text == "All")
            {

                string query = "prd_pkhcn_thongkeBBtheoKhoa";
                DataTable dt = ConnectDB.Connected.getData(query);
                tkBB.DataSource = dt;
                chartBB.DataSource = dt;
                chartBB.Series["Series2"].XValueMember = "TenKhoa";
                chartBB.Series["Series2"].YValueMembers = "SLBB";
                chartBB.Titles.Add("Số lượng bài báo các khoa");

            }
            else
            {
                string query = "prd_pkhcn_thongkeBBtheoKhoa_nam " + yearBB.Text + "";
                DataTable dt = ConnectDB.Connected.getData(query);
                tkBB.DataSource = dt;
                chartBB.DataSource = dt;
                chartBB.Series["Series2"].XValueMember = "TenKhoa";
                chartBB.Series["Series2"].YValueMembers = "SLBB";
                chartBB.Titles.Add("Số lượng bài báo của các khoa năm" + " " + yearBB.Text);
            }
        }
    }
}
