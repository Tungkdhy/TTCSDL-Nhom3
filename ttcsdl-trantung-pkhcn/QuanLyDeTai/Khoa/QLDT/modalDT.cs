using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTai.Khoa.QLDT
{
    public partial class modalDT : Form
    {
        public static List<string> inforDT = new List<string>();
        public static string State = "";
        public static string MaKhoa = "";
        public static string error = "1";
        private static string MACN = "";
        private static string MAGV1 = "";
        private static string MAGV2 = "";
        private static string MAGV3 = "";
        private static string MAGV4 = "";
        public modalDT(List<string> dataDT, string state, string makhoa)
        {
            MaKhoa = makhoa;
            State = state.Trim();
            inforDT = dataDT;
            InitializeComponent();
            if (dataDT.Any())
            {
                getdataInforDT();
            }
            getMaGV_0_TGDT();
            setup(state);
        }
        private string  FillTenGV(string MaGV)
        {
            string query_getTenGV = "proc_khoa_getTenGV '" + MaGV + "'";
            DataTable dt = ConnectDB.Connected.getData(query_getTenGV);
            return dt.Rows[0][0].ToString();
        }
        public void setup(string state)
        {
            if (state == "update")
            {
                lbModalQLDT.Text = "Sửa đề tài";
                txtMADT.Enabled = false;
                txtCap.Enabled = false;
                txtChuyenNganh.Enabled = false;                
                txtNgayNT.Enabled = false;
                txtTrangThai.Enabled = false;
                txtKetQua.Enabled = false;
                txtTenBM.Enabled = false;
                cmbSelectTenBM.Visible = false;
                panelThemTV.Visible = false;
                this.Size = new Size(810, 760);
                panelThemDTTittle.Dock = DockStyle.Top;
                panelThemDT.Dock = DockStyle.Fill;
            }
            else if (state == "add")
            {
                string query_get_slggvktgdt = "proc_khoa_getSoLuongGVKTGDT '" + MaKhoa + "'";
                int slg = int.Parse(ConnectDB.Connected.getData(query_get_slggvktgdt).Rows[0][0].ToString());
                switch (slg)
                {
                    case 1:
                        cmbSLTV.Items.Clear();
                        add_sltb(1);
                        
                        break;
                    case 2:
                        cmbSLTV.Items.Clear();
                        add_sltb(2);
                        break;
                    case 3:
                        cmbSLTV.Items.Clear();
                        add_sltb(3);
                        break;
                    case 4:
                        cmbSLTV.Items.Clear();
                        add_sltb(4);
                        break;
                    default:
                        cmbSLTV.Items.Clear();
                        add_sltb(5);
                        break;
                }
                string query = "select distinct(BOMON.TenBM) from BOMON where BOMON.MAKHOA = '" + MaKhoa + "'";
                DataTable dt = ConnectDB.Connected.getData(query);
                foreach (DataRow dr in dt.Rows)
                {
                    cmbSelectTenBM.Items.Add(dr[0].ToString());
                }
                string next_year = DateTime.Now.AddYears(1).Year.ToString();
                txtMADT.Enabled = false;
                txtMADT.Text = inforDT[0];
                txtTenDT.Text = "";
                txtChuyenNganh.Text = "";
                txtCap.Text = "";
                txtTienDo.Text = "0";
                txtKetQua.Text = "Chưa xếp loại";                
                txtNgayNT.Text = "4/5/"+next_year ;
                txtTrangThai.Text = "Chờ phê duyệt";
                txtLoaiSP.Text = "";
                txtKetQua.Enabled = false;
                txtNgayNT.Enabled = false;
                txtTenBM.Visible = false;
                txtTrangThai.Enabled = false;
                txtTienDo.Enabled = false;
                cmbMCN.Enabled = false;
                cmbMGV1.Enabled = false;
                cmbMGV2.Enabled = false;
                cmbMGV3.Enabled = false;
                cmbMGV4.Enabled = false;
            }
        }
        public void getdataInforDT()
        {
            txtMADT.Text = inforDT[0];
            txtTenDT.Text = inforDT[1];
            txtChuyenNganh.Text = inforDT[2];
            txtCap.Text = inforDT[3];            
            txtNgayNT.Text = inforDT[5].Split()[0];
            txtTrangThai.Text = inforDT[6];
            txtLoaiSP.Text = inforDT[7];
            txtTenBM.Text = inforDT[8];
            txtTienDo.Text = inforDT[9];
            txtKetQua.Text = inforDT[10];
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (State == "update")
                {
                    MessageBox.Show(State);
                    string query = "proc_khoa_updateDT N'"+txtTenDT.Text.Trim()+"', N'"+txtLoaiSP.Text.Trim()+"', '"+txtMADT.Text.Trim()+"'";
                    MessageBox.Show(ConnectDB.Connected.ChangeData(query, "Sửa"));
                    this.Hide();
                }
                if (State == "add")
                {                    
                    string message_tv = "";
                    check_duplicate_magv();                    
                    if (error == "1")
                    {                        
                        string query_them_dt = "proc_khoa_insertDT '" + txtMADT.Text.Trim() + "', N'" + txtTenDT.Text.Trim() + "',N'" + txtChuyenNganh.Text.Trim() + "',N'" + txtCap.Text.Trim() + "', '" + txtNgayNT.Text + "', N'" + txtTrangThai.Text.Trim() + "', N'" + txtLoaiSP.Text.Trim() + "', N'"+cmbSelectTenBM.Text.Trim()+ "', '"+txtTienDo.Text.Trim()+"', N'"+txtKetQua.Text.Trim()+"'";                       
                        MessageBox.Show(ConnectDB.Connected.ChangeData(query_them_dt, "Thêm đề tài thành công"));
                        string insert_CN = "";
                        string insert_TV1 = "";
                        string insert_TV2 = "";
                        string insert_TV3 = "";
                        string insert_TV4 = "";
                        List<string> query_insert = new List<string>();

                        switch (cmbSLTV.Text.Trim())
                        {
                            case "1":
                                insert_CN = "proc_khoa_insertCNDT '" + cmbMCN.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                query_insert.Add(insert_CN);

                                break;
                            case "2":
                                insert_CN = "proc_khoa_insertCNDT '" + cmbMCN.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                insert_TV1 = "proc_khoa_insertTV '" + cmbMGV1.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                query_insert.Add(insert_CN);
                                query_insert.Add(insert_TV1);
                                break;
                            case "3":
                                insert_CN = "proc_khoa_insertCNDT '" + cmbMCN.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                insert_TV1 = "proc_khoa_insertTV '" + cmbMGV1.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                insert_TV2 = "proc_khoa_insertTV '" + cmbMGV2.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                query_insert.Add(insert_CN);
                                query_insert.Add(insert_TV1);
                                query_insert.Add(insert_TV2);
                                break;
                            case "4":
                                insert_CN = "proc_khoa_insertCNDT '" + cmbMCN.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                insert_TV1 = "proc_khoa_insertTV '" + cmbMGV1.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                insert_TV2 = "proc_khoa_insertTV '" + cmbMGV2.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                insert_TV3 = "proc_khoa_insertTV '" + cmbMGV3.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                query_insert.Add(insert_CN);
                                query_insert.Add(insert_TV1);
                                query_insert.Add(insert_TV2);
                                query_insert.Add(insert_TV3);
                                break;
                            case "5":
                                insert_CN = "proc_khoa_insertCNDT '" + cmbMCN.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                insert_TV1 = "proc_khoa_insertTV '" + cmbMGV1.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                insert_TV2 = "proc_khoa_insertTV '" + cmbMGV2.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                insert_TV3 = "proc_khoa_insertTV '" + cmbMGV3.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                insert_TV4 = "proc_khoa_insertTV '" + cmbMGV4.Text.Trim() + "', '" + txtMADT.Text.Trim() + "'";
                                query_insert.Add(insert_CN);
                                query_insert.Add(insert_TV1);
                                query_insert.Add(insert_TV2);
                                query_insert.Add(insert_TV3);
                                query_insert.Add(insert_TV4);
                                break;
                        }
                        query_insert.ForEach(delegate (string single_query)
                        {                            
                            message_tv = ConnectDB.Connected.ChangeData(single_query, "Thêm thành viên thành công");
                        });
                        MessageBox.Show(message_tv);                        
                        this.Hide();                        
                    }
                    else
                    {
                        MessageBox.Show(error);
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

        private void cmbSLTV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMCN.Items.Clear();
            cmbMGV1.Items.Clear();
            cmbMGV2.Items.Clear();
            cmbMGV3.Items.Clear();
            cmbMGV4.Items.Clear();
            getMaGV_0_TGDT();
            switch (cmbSLTV.Text.Trim())
            {
                case "1":
                    cmbMCN.Enabled = true;
                    cmbMGV1.Text = "";
                    cmbMGV2.Text = "";
                    cmbMGV3.Text = "";
                    cmbMGV4.Text = "";
                    txtTenGV1.Text = "";
                    txtTenGV2.Text = "";
                    txtTenGV3.Text = "";
                    txtTenGV4.Text = "";
                    cmbMGV1.Enabled = false;
                    cmbMGV2.Enabled = false;
                    cmbMGV3.Enabled = false;
                    cmbMGV4.Enabled = false;                  
                    break;
                case "2":
                    cmbMCN.Enabled = true;
                    cmbMGV1.Enabled = true;
                    cmbMGV2.Text = "";
                    cmbMGV3.Text = "";
                    cmbMGV4.Text = "";
                    txtTenGV2.Text = "";
                    txtTenGV3.Text = "";
                    txtTenGV4.Text = "";
                    cmbMGV2.Enabled = false;
                    cmbMGV3.Enabled = false;
                    cmbMGV4.Enabled = false;
                    break;
                case "3":
                    cmbMCN.Enabled = true;
                    cmbMGV1.Enabled = true;
                    cmbMGV2.Enabled = true;
                    cmbMGV3.Text = "";
                    cmbMGV4.Text = "";
                    txtTenGV3.Text = "";
                    txtTenGV4.Text = "";
                    cmbMGV3.Enabled = false;
                    cmbMGV4.Enabled = false;
                    break;
                case "4":
                    cmbMCN.Enabled = true;
                    cmbMGV1.Enabled = true;
                    cmbMGV2.Enabled = true;
                    cmbMGV3.Enabled = true;
                    cmbMGV4.Text = "";
                    txtTenGV4.Text = "";
                    cmbMGV4.Enabled = false;
                    break;
                case "5":
                    cmbMCN.Enabled = true;
                    cmbMGV1.Enabled = true;
                    cmbMGV2.Enabled = true;
                    cmbMGV3.Enabled = true;
                    cmbMGV4.Enabled = true;
                    break;
            }
            
        }
        
        private void getMaGV_0_TGDT()
        {
            string query_getMaGV_0_TGDT = "proc_khoa_getGVKTGDT '" + MaKhoa + "'";
            DataTable dt = ConnectDB.Connected.getData(query_getMaGV_0_TGDT);
            foreach (DataRow dr in dt.Rows)
            {
                cmbMCN.Items.Add(dr[0].ToString());
                cmbMGV1.Items.Add(dr[0].ToString());
                cmbMGV2.Items.Add(dr[0].ToString());
                cmbMGV3.Items.Add(dr[0].ToString());
                cmbMGV4.Items.Add(dr[0].ToString());
            }
        }

        private void cmbMCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            txttenCN.Text=FillTenGV(cmbMCN.Text.Trim());
            MACN = cmbMCN.Text.Trim();            
        }

        private void cmbMGV1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenGV1.Text = FillTenGV(cmbMGV1.Text.Trim());
            MAGV1 = cmbMGV1.Text.Trim();               
        }

        private void cmbMGV2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenGV2.Text = FillTenGV(cmbMGV2.Text.Trim());
            MAGV2 = cmbMGV2.Text.Trim();            
        }

        private void cmbMGV3_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenGV3.Text = FillTenGV(cmbMGV3.Text.Trim());
            MAGV3 = cmbMGV3.Text.Trim();            
        }

        private void cmbMGV4_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenGV4.Text = FillTenGV(cmbMGV4.Text.Trim());
            MAGV4 = cmbMGV4.Text.Trim();            
        }
        private void check_duplicate_magv()
        {
            if (MACN == MAGV1 || MACN == MAGV2 || MACN == MAGV3 || MACN == MAGV4)
            {
                error = "duplicate mgv";
            }else if (MAGV1 == MACN || MAGV1 == MAGV2 || MAGV1 == MAGV3 || MAGV1 == MAGV4)
            {
                error = "duplicate mgv";
            }
            else if (MAGV2 == MACN || MAGV1 == MAGV2 || MAGV2 == MAGV3 || MAGV2 == MAGV4)
            {
                error = "duplicate mgv";
            }
            else if (MAGV3 == MACN || MAGV3 == MAGV2 || MAGV1 == MAGV3 || MAGV3 == MAGV4)
            {
                error = "duplicate mgv";
            }
            else if (MAGV4 == MACN || MAGV4 == MAGV2 || MAGV4 == MAGV3 || MAGV1 == MAGV4)
            {
                error = "duplicate mgv";
            }
            else
            {
                error = "1";
            }
        }       
        private void add_sltb(int slg)
        {
            for (int i=1; i<= slg; i++)
            {
                cmbSLTV.Items.Add(i);
            }
        }
    }
}
