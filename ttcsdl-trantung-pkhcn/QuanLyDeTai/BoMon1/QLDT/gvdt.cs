using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.BoMon.QLDT
{
    public partial class gvdt : Form
    {
        public static List<string> ttgvdt = new List<string>();
        public gvdt(List<string> inforgvdt)
        {
            ttgvdt = inforgvdt;
            InitializeComponent();
            if (ttgvdt.Any())
            {
                getdatagv();
            }
            setdatagv();
            getlistgvdt();

        }
        public void getdatagv()
        {
            txtMADT.Text = ttgvdt[0];
            txtTenDT.Text = ttgvdt[1];
        }
        public void setdatagv()
        {
            txtMADT.Enabled = false;
            txtTenDT.Enabled = false;
        }
        public void getlistgvdt()
        {
            string query = "select GV.MAGV, GV.TenGV, GV.NS, GV.GioiTinh,GV.CapBac,GV.ChucVu,GV.MABM,BOMON.MAKHOA, GVTGDT.Vaitro from GV, GVTGDT, BOMON where GV.MAGV = GVTGDT.MAGV and GV.MABM = BOMON.MABM and GVTGDT.MADT = '"+txtMADT.Text+"' ";
            DataTable dt = ConnectDB.Connected.getData(query);
            dgv_gvdt.DataSource = dt;
        }

        private void dgv_gvdt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
