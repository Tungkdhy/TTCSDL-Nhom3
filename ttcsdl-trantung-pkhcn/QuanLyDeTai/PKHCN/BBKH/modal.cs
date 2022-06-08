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
    public partial class modal : Form
    {
        private string magv;
       
        public modal(string MAGV)
        {
            InitializeComponent();
            magv = MAGV;
            MBB.Enabled = false;
            string mabb = get_nextMBB();
            MessageBox.Show(mabb);
            MBB.Text = mabb;
            getMADTBMAGV();
        }
        private void getMADTBMAGV()
        {
            selectDT.Items.Clear();
            string query = "getAllDTByMagv '"+magv+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            foreach(DataRow dr in dt.Rows)
            {
                selectDT.Items.Add(dr[0]);
            }
        }
        private void getGVKTGDT()
        {
            GV1.Items.Clear();
            GV2.Items.Clear();
            GV3.Items.Clear();
            GV4.Items.Clear();
            
            string query = "gv_getTV_TG '"+selectDT.Text+"','"+magv+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            foreach (DataRow dr in dt.Rows)
            {
                
                GV1.Items.Add(dr[0].ToString().Trim() + "-" + dr[1].ToString());
                GV2.Items.Add(dr[0].ToString().Trim() + "-" + dr[1].ToString());
                GV3.Items.Add(dr[0].ToString().Trim() + "-" + dr[1].ToString());
                GV4.Items.Add(dr[0].ToString().Trim() + "-" + dr[1].ToString());

            }
        }
        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool check_duplicate_magv()
        {
            if (GV1.Text == GV2.Text || GV1.Text == GV3.Text || GV1.Text == GV4.Text && GV1.Text != "" && GV2.Text != "" && GV3.Text != "" && GV4.Text != "")
            {
                return true;
            }
            else if (GV2.Text == GV3.Text || GV2.Text == GV4.Text && GV2.Text != "" && GV3.Text != "" && GV4.Text != "")
            {
                return true;
            }
            else if (GV3.Text == GV4.Text && GV3.Text != "" && GV4.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private string get_nextMBB()
        {
            string query_get_next_mBB = "declare @nextMaBB nvarchar(10) \n exec @nextMaBB = TuTangMaBB \n select @nextMaBB";
            string next_MABB = ConnectDB.Connected.getData(query_get_next_mBB).Rows[0][0].ToString();
            return next_MABB;
        }
        private void HT_Click(object sender, EventArgs e)
        {
            if (check_duplicate_magv())
            {
                string query = "GV_viet_BB '" + MBB.Text + "','" + magv + "',N'" + CN.Text + "'," +
                "N'" + TapCHi.Text + "',N'" + TenBB.Text + "','" + NgayDang.Text + "',N'" + Vaitro.Text + "'," +
                "'" + link.Text + "','" + selectDT.Text + "','" + SL.Text + "','" + GV1.Text.Split('-')[0] + "','" + GV2.Text.Split('-')[0] + "','" + GV3.Text.Split('-')[0] + "','" + GV4.Text.Split('-')[0] + "'";
                MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Thêm"));
                this.Hide();
            }
            else
            {
                MessageBox.Show("Có thành viên trùng nhau");
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           if(selectDT.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã đề tài");

            }
            else
            {
                if (SL.Text == "1")
                {
                    lalelGV1.Visible = true;
                    GV1.Visible = true;
                    labelGV2.Visible = false;
                    labelGV3.Visible = false;
                    GV2.Visible = false;
                    GV3.Visible = false;
                    labelGV4.Visible = false;
                    GV4.Visible = false;
                }
                if (SL.Text == "2")
                {
                    lalelGV1.Visible = true;
                    GV1.Visible = true;
                    labelGV2.Visible = true;
                    labelGV3.Visible = false;
                    GV2.Visible = true;
                    GV3.Visible = false;
                    labelGV4.Visible = false;
                    GV4.Visible = false;
                }
                if (SL.Text == "3")
                {
                    lalelGV1.Visible = true;
                    GV1.Visible = true;
                    labelGV2.Visible = true;
                    labelGV3.Visible = true;
                    GV2.Visible = true;
                    GV3.Visible = true;
                    labelGV4.Visible = false;
                    GV4.Visible = false;
                }
                if (SL.Text == "4")
                {
                    lalelGV1.Visible = true;
                    GV1.Visible = true;
                    labelGV2.Visible = true;
                    labelGV3.Visible = true;
                    GV2.Visible = true;
                    GV3.Visible = true;
                    labelGV4.Visible = true;
                    GV4.Visible = true;
                }
            }
        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void selectDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            getGVKTGDT();
        }
    }
}
