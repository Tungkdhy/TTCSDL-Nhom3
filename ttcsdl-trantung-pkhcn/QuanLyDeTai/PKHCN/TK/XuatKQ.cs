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
    public partial class XuatKQ : Form
    {
        private string Nam;
        private string TenKhoa;
        public XuatKQ(string nam,string ten)
        {
            Nam = nam;
            TenKhoa = ten;
            InitializeComponent();
        }

        private void XuatKQ_Load(object sender, EventArgs e)
        {
            string query = "";
            this.xuat.RefreshReport();
        }
    }
}
