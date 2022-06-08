using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.BoMon.QLCNDT
{
    public partial class CNDT : Form
    {
        public static string MaBM = "";
       //  public static List<string> inforCNDT = new List<string>();
        public static string vaitro = "Chủ nhiệm";
        public CNDT(string mabomon)
        {
            MaBM = mabomon;
            InitializeComponent();
            getListDT();

        }

        public void getListDT()
        {
            string query = "bomon_lay_cnDT '"+MaBM+"',N'"+vaitro+"'";
            DataTable dt = ConnectDB.Connected.getData(query);

            ListCNDT.DataSource = dt;
        }

       

        private void ListDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ListCNDT.SelectAll();
            DataObject copydata = ListCNDT.GetClipboardContent();
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

        private void btntimkiem_Click(object sender, EventArgs e)
        {

        }
    }
}
