using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.PKHCN.QuanLyKinhPhi
{
    public partial class QLKP : Form
    {
        public QLKP()
        {
            InitializeComponent();
            getDTKP();
            getTenKhoa();
        }

        private void getTenKhoa()
        {
            string query = "pkhcn_getTenKhoa";
            DataTable dt = ConnectDB.Connected.getData(query);
            foreach (DataRow dr in dt.Rows)
            {
                TenKhoa.Items.Add(dr[0].ToString());
            }
        }
        private void getDTKP()
        {
            string query = "pkhcn_kinh_phi";
            listDTKP.DataSource = ConnectDB.Connected.getData(query);
            listDTKP.Columns[1].Width = 350;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string query = "pkhcn_cap_kp ";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Cấp"));
            getDTKP();
        }

        private void TenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "pkhcn_lay_kp_mk N'" + TenKhoa.Text + "'";
            listDTKP.DataSource = ConnectDB.Connected.getData(query);
        }

        private void baocao_Click(object sender, EventArgs e)
        {
            
            Form xinKp = new Baocao();
            xinKp.ShowDialog();
        }
    }
}
