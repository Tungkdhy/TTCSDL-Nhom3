using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.PKHCN.QuanLyDT
{
    public partial class modal : Form
    {
        public static string MaDT;
        public static string State;
        public modal(string MADT,string state)
        {
            State = state;
            InitializeComponent();
            MaDT = MADT;
            MDT.Enabled = false;
            if (state == "Edit")
            {
                getDataInfo();
                MDT.Enabled = false;
                MBM.Enabled = false;
            }

        }
        private void getDataInfo()
        {
            string query = "pkhcn_getDtbyMDT '"+MaDT+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            MDT.Text = dt.Rows[0][0].ToString().Trim();
            CN.Text = dt.Rows[0][1].ToString().Trim();
            Cap.Text=dt.Rows[0][2].ToString().Trim();
            NgayBD.Text = dt.Rows[0][3].ToString().Trim().Split(' ')[0];
            NgayNT.Text=dt.Rows[0][4].ToString().Trim().Split(' ')[0];
            TT.Text = dt.Rows[0][5].ToString().Trim();
            LSP.Text = dt.Rows[0][6].ToString().Trim();
            MBM.Text = dt.Rows[0][7].ToString().Trim();
            
            TienDo.Text = dt.Rows[0][8].ToString().Trim();
            TenDT.Text = dt.Rows[0][11].ToString().Trim();
            KQ.Text = dt.Rows[0][10].ToString().Trim();



        }
        private void HT_Click(object sender, EventArgs e)
        {
            string query = "";
            if(State == "Edit")
            {
                query = "exec updateResearch N'" + TenDT.Text + "',N'" + CN.Text + "',N'" + Cap.Text + "',N'" + KQ.Text + "','" + NgayBD.Text + "','" + NgayNT.Text + "',N'" + LSP.Text + "','" + TienDo.Text + "',N'" + TT.Text + "','" + MDT.Text + "'";
                MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Sửa"));
                this.Close();
            }
            
        }

        private void TienDo_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
