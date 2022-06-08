using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.BoMon.QLGV
{
    public partial class dsdt : Form
    {
        public static List<string> listdt = new List<string>();
        public dsdt(List<string> dsdetai)
        {

            listdt = dsdetai;
            InitializeComponent();
            if (listdt.Any())
            {
                getdataDT();
            }
            //getdataDT();
            setup();
            getlistdt();
            
        }
        public void getdataDT()
        {
            txtMAGV.Text = listdt[0];
            txtName.Text = listdt[1];
            
        }
        public void setup()
        {
            txtMAGV.Enabled = false;
            txtName.Enabled = false;
        }
        public void getlistdt()
        {
            string query = "select dt.MADT, dt.TenDT, dt.Cap, dt.ChuyenNganh, dt.TrangThai, gvdt.Vaitro from GVTGDT as gvdt,DeTaiNCKH as dt where gvdt.MADT = dt.MADT and gvdt.MAGV = '"+txtMAGV.Text +"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            dgv_dsdt.DataSource = dt;

        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }
    }
}
