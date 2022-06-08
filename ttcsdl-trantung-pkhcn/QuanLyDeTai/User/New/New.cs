using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuanLyDeTai.User.New
{
    public partial class New : Form
    {
        private static string maGV;
        private static string link_current;
        private string maBB;
        private static string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public New(string MaGv)
        {
            maGV = MaGv;
            InitializeComponent();
            getListNew();
            panel_BB_footer.Visible = false;   

            
        }
        private void getListNew()
        {
            
            string query = "exec getAllBBByMGV '"+maGV+"'";
            bunifuDataGridView1.DataSource = ConnectDB.Connected.getData(query);
        }
        
     

      

        private void Add_Click(object sender, EventArgs e)
        {
           
        }

        

      

       

        private void add_Click_1(object sender, EventArgs e)
        {
            panel_BB_footer.Visible=false;
            Form create = new PKHCN.BBKH.modal(maGV);
            create.ShowDialog();
            getListNew();
        }



        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = bunifuDataGridView1.Rows[e.RowIndex];
                maBB = Convert.ToString(row.Cells[0].Value);
                delete.Enabled = true;
                link_current = Convert.ToString(row.Cells["Link"].Value);
                panel_BB_footer.Visible = true;
            }
            catch
            {

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string query = "prd_pkhcn_xoaBB '"+maBB+"'";
            MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Xóa"));
            getListNew();
            delete.Enabled = false;
            panel_BB_footer.Visible = false;

        }

        private void New_Load(object sender, EventArgs e)
        {

        }

        private void btn_xemBB_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(link_current);
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
