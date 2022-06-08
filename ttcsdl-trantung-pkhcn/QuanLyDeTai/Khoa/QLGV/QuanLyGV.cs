//using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyDeTai.Khoa
{
    public partial class QuanLyGV : Form
    {
        public static List<string> inforGV = new List<string>();
        public static string state = "";
        public static string MaKhoa = "";
        public QuanLyGV(string maKhoa)
        {
            MaKhoa = maKhoa;
            InitializeComponent();
            getListGV();
        }


        public void getListGV()
        {
            string query = "prd_khoa_getAllStaff '"+MaKhoa+"'";
            DataTable dt = ConnectDB.Connected.getData(query);

            ListGV.DataSource = dt;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            state = "update";
            Form function = new QLGV.function(inforGV, state, MaKhoa);
            function.ShowDialog();
            if(lbQLGV.Text == "Danh sách giáo viên"){
                getListGV();
            }
            else
            {
                string query = "exec prd_khoa_DSchunhiemDT '" + MaKhoa + "'";
                DataTable dt = ConnectDB.Connected.getData(query);
                ListGV.DataSource = dt;
            }
            
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "exec prd_khoa_deleteGV '" + inforGV[0] + "'";
            DialogResult dr = MessageBox.Show("Delete " + inforGV[1].Trim() + "", "Are you sure for", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show(ConnectDB.Connected.ChangeData(query, "xóa"));
            }
            else
            {

            }

            getListGV();
        }

        private void ListGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string query_get_next_mGV = "declare @nextMGV nvarchar(10) \n exec @nextMGV = TuTangMaGV \n select @nextMGV";
            string next_MAGV = ConnectDB.Connected.getData(query_get_next_mGV).Rows[0][0].ToString();
            state = "add";
            List<string> empty = new List<string>() {next_MAGV,"","","","","","",""};
            Form function = new QLGV.function(empty, state, MaKhoa);
            function.ShowDialog();

            if (lbQLGV.Text == "Danh sách giáo viên")
            {
                getListGV();
            }
            else
            {
                string query = "exec prd_khoa_DSchunhiemDT '" + MaKhoa + "'";
                DataTable dt = ConnectDB.Connected.getData(query);
                ListGV.DataSource = dt;
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ListGV.SelectAll();
            DataObject copydata = ListGV.GetClipboardContent();
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

        private void lbQLGV_Click(object sender, EventArgs e)
        {
            if (lbQLGV.Text.Trim() == "Danh sách giáo viên")
            {
                getListGV();
                btnThem.Enabled = true;
            }
            else
            {

            }
                       
        }

        private void btnDSCN_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            lbQLGV.Text = "Danh sách chủ nhiệm";
            btnBack.Visible = true;
            string query = "exec prd_khoa_DSchunhiemDT '"+MaKhoa+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            ListGV.DataSource = dt;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            
        }

        private void txtsearchGV_TextChanged(object sender, EventArgs e)
        {
            string query = "";
            if (lbQLGV.Text == "Danh sách chủ nhiệm")
            {
                query = "prd_khoa_DSchunhiemDT '" + MaKhoa + "'";
            }
            else
            {
                query = "prd_khoa_getAllStaff '" + MaKhoa + "'";
            }
            string searchGV = txtsearchGV.Text;
            try
            {
                DataTable dt = ConnectDB.Connected.getData(query);
                ListGV.DataSource = dt;
                var re = from row in dt.AsEnumerable()
                         where row[1].ToString().ToLower().Contains(searchGV.ToLower())
                         select row;
                ListGV.DataSource = re.CopyToDataTable();
            }
            catch
            {

            }
        }

        private void ListGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bunifuTransition1.ShowSync(panel1);
                int index = e.RowIndex;
                DataGridViewRow selectedRow = ListGV.Rows[index];
                string MAGV = selectedRow.Cells["Mã GV"].Value.ToString();
                string TenGV = selectedRow.Cells["Họ tên"].Value.ToString();
                string NS = selectedRow.Cells["Ngày sinh"].Value.ToString().Split()[0];
                string GioiTinh = selectedRow.Cells["Giới tính"].Value.ToString();
                string CapBac = selectedRow.Cells["Cấp bậc"].Value.ToString();
                string ChucVu = selectedRow.Cells["Chức vụ"].Value.ToString();
                string DTL = selectedRow.Cells["ĐTL"].Value.ToString();
                string MABM = selectedRow.Cells["Tên bộ môn"].Value.ToString();
                string[] dataGV = { MAGV, TenGV, NS, GioiTinh, CapBac, ChucVu, DTL, MABM };
                inforGV.Clear();
                inforGV.AddRange(dataGV);
            }
            catch
            {

            }
        }

        private void btnTTCT_Click(object sender, EventArgs e)
        {
            state = "xem";
            Form function = new QLGV.function(inforGV, state, MaKhoa);
            function.Show();
        }

        private void btnDTTG_Click(object sender, EventArgs e)
        {
            //Form DTTG = new QLGV.DeTaiTG(inforGV[0], inforGV[1]);
            Form test = new Khoa2.QLGV.DSDTG(inforGV[0],inforGV[1]);
            test.ShowDialog();
            
            
            //DTTG.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            getListGV();
            btnBack.Visible = false;
            lbQLGV.Text = "Danh sách giáo viên";
            btnThem.Enabled = true;
        }
    }
}