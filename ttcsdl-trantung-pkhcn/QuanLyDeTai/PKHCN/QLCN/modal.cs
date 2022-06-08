using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.PKHCN.QLCN
{
    public partial class modal : Form
    {
        private string MaGV;
        private string State;
        public modal( string magv,string state)
        {
            InitializeComponent();
            MaGV = magv;
            State = state;
            if(state == "DT")
            {

            getALLDT();
            }
            else
            {
                getAllBB();
            }


        }
        private void getALLDT()
        {
            string query = "getAllDTByMagv '"+MaGV+"'";
            DataTable dt = ConnectDB.Connected.getData(query);          
            guna2DataGridView1.DataSource = dt;

           
            
        }
        private void listGV_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void AddTV_Click(object sender, EventArgs e)
        {

        }
        private void getAllBB()
        {
            string query = "getAllBBByMGV '"+MaGV+"'";
            DataTable data = ConnectDB.Connected.getData(query);
            guna2DataGridView1.DataSource = data;
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
