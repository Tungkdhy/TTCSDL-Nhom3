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
    public partial class DT : Form
    {
        public static string MaBM = "";
        public static List<string> ttdt = new List<string>();
        public DT(string mabomon)
        {
            MaBM = mabomon;
            InitializeComponent();
            getListDT();
            bunifuPanel4.Hide();
            
        }

        public void getListDT()
        {
            string query = "bomon_lay_dsdt '" + MaBM +"'";
            DataTable dt = ConnectDB.Connected.getData(query);

            ListDT.DataSource = dt;
        }
        private void DT_Load(object sender, EventArgs e)
        {

        }

        private void ListDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bunifuPanel4.Show();
            int index = e.RowIndex;
            DataGridViewRow selectedRow = ListDT.Rows[index];
            string MADT = selectedRow.Cells["MADT"].Value.ToString();
            string TenDT = selectedRow.Cells["TenDT"].Value.ToString();
            string ChuyenNganh = selectedRow.Cells["ChuyenNganh"].Value.ToString().Split()[0];
            string Cap = selectedRow.Cells["Cap"].Value.ToString();
            string Kq = selectedRow.Cells["KetQua"].Value.ToString();
            string NgayBD = selectedRow.Cells["NgayBD"].Value.ToString();
            string NgayNT = selectedRow.Cells["NgayNT"].Value.ToString();
            string TrangThai = selectedRow.Cells["TrangThai"].Value.ToString();
            string LoaiSP = selectedRow.Cells["LoaiSP"].Value.ToString();
           // string TenBM = selectedRow.Cells["TenBM"].Value.ToString();
            string TienDo = selectedRow.Cells["TienDo"].Value.ToString();
            string[] dataDT = { MADT, TenDT, ChuyenNganh, Cap, Kq, NgayBD, NgayNT, TrangThai, LoaiSP,  TienDo };
            ttdt.Clear();
            ttdt.AddRange(dataDT);
        }
        private void cmbCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "";
            query = "bomon_lay_dtdt_theocap '" + MaBM + "', N'" + cmbCap.Text + "')";

            if ( cmbTrangThai.Text != "")
            {
                query = "bomon_lay_dtdt_cap_tt '" + MaBM + "', N'" + cmbCap.Text + "',N'" + cmbTrangThai.Text.Trim() + "')";
            }
            
            DataTable dt = ConnectDB.Connected.getData(query);
            ListDT.DataSource = dt;

        }

        private void cmbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "";
            query = "bomon_lay_dtdt_tt'" + MaBM + "', N'" + cmbTrangThai.Text.Trim() + "')";

            if (cmbTrangThai.Text != "")
            {
                query = "bomon_lay_dtdt_cap_tt '" + MaBM + "', N'" + cmbCap.Text + "',N'" + cmbTrangThai.Text.Trim() + "'";

            }

            DataTable dt = ConnectDB.Connected.getData(query);
            ListDT.DataSource = dt;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            cmbCap.Items.Clear();
            string query1 = "select distinct(Cap) from DeTaiNCKH where DeTaiNCKH.MABM   = '" + MaBM + "'";
            DataTable dt1 = ConnectDB.Connected.getData(query1);
            foreach (DataRow dr in dt1.Rows)
            {
                cmbCap.Items.Add(dr[0].ToString());
            }
            string query2 = "select distinct(TrangThai) from DeTaiNCKH where DeTaiNCKH.MABM  =  '" + MaBM+ "'";
            DataTable dt2 = ConnectDB.Connected.getData(query2);
            foreach (DataRow dr in dt2.Rows)
            {
                cmbTrangThai.Items.Add(dr[0].ToString());
            }
            panelLoc.Visible = true;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string query = "bomon_tk_dt '"+MaBM+"',N'"+tb_tk.Text+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            ListDT.DataSource = dt;
        }

        private void tb_tk_TextChanged(object sender, EventArgs e)
        {
            string query = "bomon_tk_dt '" + MaBM + "',N'" + tb_tk.Text + "'";
            DataTable dt = ConnectDB.Connected.getData(query);
            ListDT.DataSource = dt;
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ListDT.SelectAll();
            DataObject copydata = ListDT.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object misedata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(misedata);
            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();
            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Form gvdt = new QLDT.gvdt(ttdt);
            gvdt.ShowDialog();
            
        }

        private void bunifuPanel4_Click(object sender, EventArgs e)
        {

        }

        private void ListDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bunifuPanel4.Show();
                int index = e.RowIndex;
                DataGridViewRow selectedRow = ListDT.Rows[index];
                string MADT = selectedRow.Cells["MADT"].Value.ToString();
                string TenDT = selectedRow.Cells["TenDT"].Value.ToString();
                string ChuyenNganh = selectedRow.Cells["ChuyenNganh"].Value.ToString().Split()[0];
                string Cap = selectedRow.Cells["Cap"].Value.ToString();
                string Kq = selectedRow.Cells["KetQua"].Value.ToString();
                string NgayBD = selectedRow.Cells["NgayBD"].Value.ToString();
                string NgayNT = selectedRow.Cells["NgayNT"].Value.ToString();
                string TrangThai = selectedRow.Cells["TrangThai"].Value.ToString();
                string LoaiSP = selectedRow.Cells["LoaiSP"].Value.ToString();
                // string TenBM = selectedRow.Cells["TenBM"].Value.ToString();
                string TienDo = selectedRow.Cells["TienDo"].Value.ToString();
                string[] dataDT = { MADT, TenDT, ChuyenNganh, Cap, Kq, NgayBD, NgayNT, TrangThai, LoaiSP, TienDo };
                ttdt.Clear();
                ttdt.AddRange(dataDT);
            }
            catch
            {

            }
            
        }
    }
}
