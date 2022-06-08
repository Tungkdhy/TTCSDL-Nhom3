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
    public partial class TK : Form
    {
        public TK()
        {
            InitializeComponent();
            getYearDT();            
            TKAllDT();
        }
        private void getYearDT()
        {
            yearDT.Items.Clear();
            yearDT.Items.Add("All");
            string query = "getYearDT";
            DataTable year = ConnectDB.Connected.getData(query);
            foreach(DataRow row in year.Rows)
            {
                yearDT.Items.Add(row[0]);

            }
        }
        
        private void TKAllDT()
        {
            string query = "pro_pnckh_thongke_slgdt_khoa";
            DataTable dt = ConnectDB.Connected.getData(query);
            Tkdt.DataSource = dt;
            chartDT.DataSource = dt;
            chartDT.Series["Series1"].XValueMember = "Tên khoa";
            chartDT.Series["Series1"].YValueMembers = "Số lượng đề tài";
            chartDT.Titles.Add("TKDT");
            yearDT.Text = "All";
        }
        
        private void yearDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartDT.Titles.Clear();
            if (yearDT.Text == "All")
            {
                string query = "pro_pnckh_thongke_slgdt_khoa";
                DataTable dt = ConnectDB.Connected.getData(query);
                Tkdt.DataSource = dt;
                chartDT.DataSource = dt;
                chartDT.Series["Series1"].XValueMember = "Tên khoa";
                chartDT.Series["Series1"].YValueMembers = "Số lượng đề tài";
                chartDT.Titles.Add("Số lượng đề tài của các khoa");

            }
            else
            {
                string query = "pro_pnckh_thongke_slgdt_khoa_theo_nam '"+ yearDT.Text + "'";
                DataTable dt = ConnectDB.Connected.getData(query);
                Tkdt.DataSource = dt;
                chartDT.DataSource = dt;
                chartDT.Series["Series1"].XValueMember = "Tên khoa";
                chartDT.Series["Series1"].YValueMembers = "Số lượng đề tài";
                chartDT.Titles.Add("Số lượng đề tài của các khoa năm"+" "+yearDT.Text);
            }
        }

        private void yearBB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
