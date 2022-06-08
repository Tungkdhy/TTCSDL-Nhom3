using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.User.ListResearch
{
    public partial class dstvDETAI : Form
    {
        public string mdt;
        public string tedt;
        public dstvDETAI(string madt, string tendt)
        {
            this.mdt = madt;
            this.tedt = tendt;
            InitializeComponent();
            Get_dstvDT();
            tenDT.Text = "Tên đề tài: " + tendt;
            MaDT.Text = "Mã đề tài: " + madt;
        }

        private void DataGridView_dstvdt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Get_dstvDT()
        {
            string query = "prd_Khoa_XemDSTV_Theo_MaDT '" + mdt + "'";
            DataTable dt = ConnectDB.Connected.getData(query);
            DataGridView_dstvdt.DataSource = dt;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
