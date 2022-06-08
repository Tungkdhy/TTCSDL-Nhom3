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
    public partial class ThemDT : Form
    {
        public ThemDT()
        {
            InitializeComponent();
            
            MADT.Text = get_nextMDT();
            getAllKhoa();

        }
        private void getGVKTGDT()
        {
            GV1.Items.Clear();
            GV2.Items.Clear();
            GV3.Items.Clear();
            GV4.Items.Clear();
            GV5.Items.Clear();
            string query = "proc_khoa_getGVKTGDT '"+MK.Text.Split('-')[0]+"'";
            DataTable dt = ConnectDB.Connected.getData(query);
            foreach (DataRow dr in dt.Rows)
            {
                GV1.Items.Add(dr[0].ToString().Trim() + "-" + dr[2].ToString());
                GV2.Items.Add(dr[0].ToString().Trim() + "-" + dr[2].ToString());
                GV3.Items.Add(dr[0].ToString().Trim() + "-" + dr[2].ToString());
                GV4.Items.Add(dr[0].ToString().Trim() + "-" + dr[2].ToString());
                GV5.Items.Add(dr[0].ToString().Trim() + "-" + dr[2].ToString());


            }
        }
        private void getAllKhoa()
        {
            MK.Items.Clear();
            string query = "pkhcn_getAllMaKhoa";
            
            DataTable dt = ConnectDB.Connected.getData(query);
            foreach(DataRow dr in dt.Rows)
            {
                MK.Items.Add(dr[0].ToString().Trim()+"-"+dr[1].ToString());
            }
        }
        private bool check_duplicate_magv()
        {
            if (GV5.Text == GV1.Text || GV5.Text == GV1.Text || GV5.Text == GV1.Text || GV5.Text == GV1.Text && GV1.Text != "" && GV2.Text != "" && GV3.Text != "" && GV4.Text != "" && GV5.Text !="")
            {
                return true;
            }
            else if (GV1.Text == GV2.Text || GV1.Text == GV3.Text || GV1.Text == GV4.Text && GV1.Text != "" && GV2.Text != "" && GV3.Text != "" && GV4.Text != "")
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
        private string get_nextMDT()
        {
            string query_get_next_mGV = "declare @nextMadt nvarchar(10) \n exec @nextMadt = TuTangMaDT \n select @nextMadt";
            string next_MADT = ConnectDB.Connected.getData(query_get_next_mGV).Rows[0][0].ToString();
            return next_MADT;
        }
        private void ThemDT_Load(object sender, EventArgs e)
        {

        }
        private string getMBM()
        {
            string query = "select MABM from GV where MAGV = '" + GV1.Text.Split('-')[0] + "'";
            return ConnectDB.Connected.getData(query).Rows[0][0].ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!check_duplicate_magv())
            {
                string query = "GV_them_dt N'" + MADT.Text + "',N'" + Tendt.Text + "',N'" + CN.Text + "',N'" + Cap.Text + "','" + NGT.Text + "',N'" + SP.Text + "','" + getMBM() + "'" +
                    ",'" + SL.Text + "','" + GV1.Text.Split('-')[0] + "','" + GV2.Text.Split('-')[0] + "','" + GV3.Text.Split('-')[0] + "','" + GV4.Text.Split('-')[0] + "','"+GV5.Text.Split('-')[0]+"'";
                MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Thêm"));
            }
            else
            {
                MessageBox.Show("Có thành viên trong đề tài trùng nhau");
            }
        }

        private void SL_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(MK.Text != "")
            {
                getGVKTGDT();
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
                    labelGV5.Visible = false;
                    GV5.Visible = false;

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
                    labelGV5.Visible = false;
                    GV5.Visible = false;
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
                    labelGV5.Visible = false;
                    GV5.Visible = false;
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
                    labelGV5.Visible = false;
                    GV5.Visible = false;
                }
                if (SL.Text == "5")
                {
                    lalelGV1.Visible = true;
                    GV1.Visible = true;
                    labelGV2.Visible = true;
                    labelGV3.Visible = true;
                    GV2.Visible = true;
                    GV3.Visible = true;
                    labelGV4.Visible = true;
                    GV4.Visible = true;
                    labelGV5.Visible = true;
                    GV5.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã khoa");
            }
        }

        private void Khoa_Click(object sender, EventArgs e)
        {

        }
    }
}
