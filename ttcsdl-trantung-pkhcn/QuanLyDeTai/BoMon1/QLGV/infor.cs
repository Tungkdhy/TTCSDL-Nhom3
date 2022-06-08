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
    public partial class infor : Form
    {
        public static List<string> ttgv = new List<string>();
        public static string luachon = "";
        
        public infor(List<string> datagv, string Luachon)
        {
            InitializeComponent();
            ttgv = datagv;
            luachon = Luachon.Trim();
            if (datagv.Any())
            {
                getdataGV();
            }
            setup();

        }
        public void getdataGV()
        {
            txtMAGV.Text = ttgv[0];
            txtName.Text = ttgv[1];
            txtNS.Text = ttgv[2];
            cbGT.Text = ttgv[3];
            txtCapBac.Text = ttgv[4];
            txtChucVu.Text = ttgv[5];
            txtDTL.Text = ttgv[6];
            txtMABM.Text = ttgv[7];
        }
        public void setup()
        {
            if (luachon == "sửa")
            {
                txtMAGV.Enabled = false;
                //txtName.Enabled = false;
                
                
            }
            else if (luachon == "thêm")
            {
                txtMAGV.Text = "";
                txtName.Text = "";
                txtNS.Text = "";
                cbGT.Text = "";
                txtCapBac.Text = "";
                txtChucVu.Text = "";
                txtDTL.Text = "";
                txtMABM.Text = "";
             
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if(luachon == "sửa")
                {
                    string query = " update GV set  TenGV = N'"+txtName.Text+"',NS = '"+txtNS.Text+"'," +
                        "GioiTinh = N'"+cbGT.Text+ "', CapBac = N'"+txtCapBac.Text+"'," +
                        "ChucVu = N'" + txtChucVu.Text + "',DTL = '" + txtDTL.Text + "'," +
                         " MABM = N'" + txtMABM.Text + "'  where MAGV = '" + txtMAGV.Text + "'";
                    MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Sửa"));
                    this.Hide();
                }
                if(luachon == "thêm")
                {
                    string query = "insert into GV(MAGV,TenGV, NS, GioiTinh, CapBac, ChucVu, DTL, MABM, MAKHOA) values ('" + txtMAGV.Text + "', " +
                        "N'" + txtName.Text + "', '" + txtNS.Text + "', '" + cbGT.Text + "', N'" + txtCapBac.Text + "', " +
                        "N'" + txtChucVu.Text + "','" + txtDTL.Text + "', '" + txtMABM.Text + "') ";
                    MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Thêm"));
                    this.Hide();
                }


            }
            catch
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
