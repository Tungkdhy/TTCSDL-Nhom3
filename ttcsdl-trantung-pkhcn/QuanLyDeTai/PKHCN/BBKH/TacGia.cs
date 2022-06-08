using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.PKHCN.BBKH
{
    public partial class TacGia : Form
    {
        private string tg;
        
        public TacGia(string tacgia,string tenbb)
        {
           
            tg = tacgia;
            InitializeComponent();
            getListTG();

            tenBB.Text = "Tên bài báo: " + tenbb;
            MaBB.Text = "Mã bài báo: " + tacgia;
        }
        private void getListTG()
        {
            string query = "pkhcn_get_tacgia '"+tg+"'";
            guna2DataGridView1.DataSource = ConnectDB.Connected.getData(query);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
