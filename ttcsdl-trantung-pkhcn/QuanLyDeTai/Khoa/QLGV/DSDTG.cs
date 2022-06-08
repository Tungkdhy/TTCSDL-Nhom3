using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.Khoa2.QLGV
{
    public partial class DSDTG : Form
    {
        private string MAGV;
        private string TenGV;
        public DSDTG(string magv,string tenGV)
        {
            MAGV = magv;
            TenGV = tenGV;
            InitializeComponent();
            getListDT();
        }
        private void getListDT()
        {
            string query = "khoa_getDTbyMGV '"+MAGV+"'";
            dgv_dsdt.DataSource = ConnectDB.Connected.getData(query);
        }
        private void DSDTG_Load(object sender, EventArgs e)
        {

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }
    }
}
