using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Test2
{
    public partial class NhanVien_Main : Form
    {
        OracleConnection conn = new OracleConnection(Globals.Data_String);
        OracleDataAdapter adapter;
        OracleCommand command;
        public NhanVien_Main()
        {
            InitializeComponent();
        }

        private void NhanVien_Main_Load(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "select * from SUPERADMIN.NhanVien";
            command = new OracleCommand(sql, conn);

            DataTable data = new DataTable();
            adapter = new OracleDataAdapter(command);
            adapter.Fill(data);
            dgv_ThongTinNV.DataSource = data;

            date_NgaySinh_NhanVien.Text =  dgv_ThongTinNV.Rows[0].Cells[3].Value.ToString();

            conn.Close();
        }
            
        public void Load_Data()
        {
            
            string sql = "select * from SUPERADMIN.NhanVien";
            command = new OracleCommand(sql, conn);

            DataTable data = new DataTable();
            adapter = new OracleDataAdapter(command);
            adapter.Fill(data);
            dgv_ThongTinNV.DataSource = data;

            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Globals.username.Substring(0, 2) == "BS")
            {
                BacSy_Main bs = new BacSy_Main();
                bs.ShowDialog();
            }
            if(Globals.username.Substring(0, 2) == "NC")
            {
                NghienCuu nc = new NghienCuu();
                nc.ShowDialog();    
            }
            if (Globals.username.Substring(0, 4) == "CSYT")
            {
                CoSoYTe_Main csyt = new CoSoYTe_Main();
                csyt.ShowDialog();
            }
            if (Globals.username.Substring(0, 2) == "TT")
            {
                ThanhTra_Main tt = new ThanhTra_Main();
                tt.ShowDialog();
            }



            this.Close();
        }

        

        private void BTN_cAPnHAT_THONGTIN_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "";
            if(txtHoTen.Text!="")
            {
                sql = @"Update SUPERADMIN.NHANVIEN set HO_TEN = :Hoten where ma_nv = '" + Globals.username + "'";
                command = new OracleCommand(sql, conn);
                command.Parameters.Add("Hoten", OracleDbType.NVarchar2, 40).Value = txtHoTen.Text;

                command.ExecuteNonQuery();
                
            }   
            if(cbb_Phai.Text.Length > 0)
            {
                int phai_num = -1;
                if (cbb_Phai.Text == "Nam")
                {
                    phai_num = 0;
                }
                else 
                {
                    phai_num = 1;
                }
                sql = @"Update SUPERADMIN.NHANVIEN set PHAI = :Phai where ma_nv = '" + Globals.username + "'";
                command = new OracleCommand(sql, conn);
                command.Parameters.Add("Phai", OracleDbType.Char, 1).Value = phai_num.ToString();

                command.ExecuteNonQuery();
            }
            if(date_NgaySinh_NhanVien.Text.Length > 0)
            {
                sql = @"Update SUPERADMIN.NHANVIEN set NGAY_SINH = :NgaySinh where ma_nv = '" + Globals.username + "'";
                command = new OracleCommand(sql, conn);
                command.Parameters.Add("NgaySinh", OracleDbType.Date).Value = date_NgaySinh_NhanVien.Text;

                command.ExecuteNonQuery();
            }
            if(txtCMND.Text.Length > 0)
            {
                if(txtCMND.Text.Length != 12)
                {
                    MessageBox.Show("CMND only 12 numbers length", "UPDATE FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sql = @"Update SUPERADMIN.NHANVIEN set CMND = :cmnd where ma_nv = '" + Globals.username + "'";
                command = new OracleCommand(sql, conn);
                command.Parameters.Add("cmnd", OracleDbType.Varchar2, 12).Value = txtCMND.Text;

                command.ExecuteNonQuery();
            }
            if(txtQueQuan.Text.Length > 0)
            {
                sql = @"Update SUPERADMIN.NHANVIEN set QUE_QUAN = :quequan where ma_nv = '" + Globals.username + "'";
                command = new OracleCommand(sql, conn);
                command.Parameters.Add("quequan", OracleDbType.NVarchar2, 20).Value = txtQueQuan.Text;

                command.ExecuteNonQuery();
            }
            if (txtSDT.Text.Length > 0)
            {
                if (txtSDT.Text.Length != 10)
                {
                    MessageBox.Show("SĐT only 10 numbers length", "UPDATE FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sql = @"Update SUPERADMIN.NHANVIEN set SO_DT = :sdt where ma_nv = '" + Globals.username + "'";
                command = new OracleCommand(sql, conn);
                command.Parameters.Add("sdt", OracleDbType.Varchar2, 10).Value = txtSDT.Text;

                command.ExecuteNonQuery();
            }


            Load_Data();
            conn.Close();


        }
    }
}
