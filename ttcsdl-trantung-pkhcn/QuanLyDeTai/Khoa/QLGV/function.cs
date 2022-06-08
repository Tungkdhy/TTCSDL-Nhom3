using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyDeTai.Khoa.QLGV
{
    public partial class function : Form
    {
        
        public static List<string> inforGV = new List<string>();
        public static string State = "";
        public static string MaKhoa = "";
        public function(List<string> dataGV, string state, string makhoa)
        {
            MaKhoa = makhoa;
            State = state.Trim();
            inforGV = dataGV;
            InitializeComponent();
            if (dataGV.Any())
            {
                getdataInforGV();
            }
            
            setup(state);
            
        }       
        public void getdataInforGV()
        {            
            txtMAGV.Text = inforGV[0];
            txtName.Text = inforGV[1];
            txtNS.Text = inforGV[2];
            txtGT.Text = inforGV[3];
            txtCapBac.Text = inforGV[4];
            txtChucVu.Text = inforGV[5];
            txtDTL.Text = inforGV[6];           
            cmbSelectTenBM.Text = inforGV[7];
        }
        public void setup(string state)
        {
            string query = "select distinct(BOMON.TenBM) from BOMON where BOMON.MAKHOA = '" + MaKhoa + "'";
            DataTable dt = ConnectDB.Connected.getData(query);
            foreach (DataRow dr in dt.Rows)
            {
                cmbSelectTenBM.Items.Add(dr[0].ToString());
            }
            if (state == "update")
            {
                                
                lbFuncQLGV.Text = "Sửa giáo viên";
                txtMAGV.Enabled = false;
                txtName.Enabled = false;
                txtCapBac.Focus();
            }
            else if (state == "add")
            {                
                txtMAGV.Enabled = false;
                txtName.Enabled = true;
                txtName.Text = "";
                txtNS.Text = "";
                txtGT.Text = "";
                txtCapBac.Text = "";
                txtChucVu.Text = "";
                txtDTL.Text = "";
                
            }
            else if (state == "xem")
            {
                lbFuncQLGV.Text = "Thông tin giáo viên";
                txtMAGV.Enabled = false;
                txtName.Enabled = false;
                txtName.Enabled = false;
                txtNS.Enabled = false;
                txtGT.Enabled = false;
                txtCapBac.Enabled = false;
                txtChucVu.Enabled = false;
                txtDTL.Enabled = false;
                cmbSelectTenBM.Enabled = false;
                btnLuu.Visible = false;
                btnHuy.Visible = false;
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (State == "update")
                {
                    try
                    {
                        if (check_nsgv(txtNS.Text.Trim()))
                        {
                            string query = "proc_khoa_updateGV '" + txtNS.Text.Trim() + "',N'" + txtGT.Text.Trim() + "', N'" + txtCapBac.Text.Trim() + "',N'" + txtChucVu.Text.Trim() + "', '" + txtDTL.Text.Trim() + "',N'" + cmbSelectTenBM.Text.Trim() + "', '" + txtMAGV.Text.Trim() + "'";
                            MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Sửa"));
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Ngày sinh không hợp lệ");
                            txtNS.Focus();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi xảy ra");
                    }                    
                }
                if (State == "add")
                {
                    try
                    {
                        if (check_nsgv(txtNS.Text.Trim()))
                        {
                            string query = "prd_khoa_insertGV '" + txtMAGV.Text + "', N'" + txtName.Text + "', '" + txtNS.Text + "',N'" + txtGT.Text + "'," +
                                            "N'" + txtCapBac.Text + "', N'" + txtChucVu.Text + "', '" + txtDTL.Text + "', N'" + cmbSelectTenBM.Text + "'";
                            MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Thêm"));
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Ngày sinh không hợp lệ");
                            txtNS.Focus();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi xảy ra");
                    }                                        
                }
            }
            catch
            {
                MessageBox.Show("Fail");
            }                         
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private bool check_nsgv(string ns)
        {
            DateTime NS = DateTime.Parse(ns);
            DateTime NSMin = new DateTime(1997, 12, 12);
            DateTime NSMax = new DateTime(1960, 12, 12);
            if (DateTime.Compare(NSMin,NS) > 0  && DateTime.Compare(NS,NSMax) > 0)
            {
                return true;
            }
            return false;
        }        
    }
 }
