using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuanLyDeTai.BoMon.ThongKe
{
    public partial class THONGKE : Form
    {
        public static string MaBM = "";
        public static string curent_url_BB = "";
        public static string current_MaBB = "";
        public THONGKE(string mabomon)
        {
            MaBM = mabomon;
            InitializeComponent();
            getBB();
            setup();
        }
        private void setup()
        {
            cmbLocBB.SelectedItem = cmbLocBB.Items[0];
            cmbLocBB.Text = "Tất cả";
        }
        private void getBB()
        {
            string query = "proc_bomon_getBBKH '"+MaBM+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            ListBB.DataSource = dt;
        }

        private void cmbLocBB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLocBB.SelectedItem.ToString() == "Tất cả")
            {
                getBB();
            }else
            {
                string query = "proc_Bomon_getBB_Loc N'"+cmbLocBB.SelectedItem.ToString()+"', '"+MaBM+"'";
                ListBB.DataSource = ConnectDB.Connected.getData(query);
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(curent_url_BB);
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void ListBB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = ListBB.Rows[index];
                curent_url_BB = selectedRow.Cells["Link"].Value.ToString();
                current_MaBB = selectedRow.Cells["MABB"].Value.ToString();
                string xacminh = selectedRow.Cells["XacNhan"].Value.ToString();
                if (xacminh == "Đã xác minh")
                {
                    btnXM.Visible = false;
                }
                else
                {
                    btnXM.Visible = true;
                }
                bunifuTransition1.ShowSync(footerpanel);                        
            }
            catch
            {

            }

        }

        private void btnXM_Click(object sender, EventArgs e)
        {
            string query = "proc_Bomon_xmbb '" + current_MaBB + "'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query,"Xác minh"));
            getBB();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
