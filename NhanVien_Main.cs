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
            BacSy_Main bs = new BacSy_Main();
            bs.ShowDialog();
            this.Close();
        }

        

        private void BTN_cAPnHAT_THONGTIN_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "";
            sql = @"Update SUPERADMIN.NHANVIEN set HO_TEN = :Hoten where ma_nv = '" + Globals.username + "'";
            command = new OracleCommand(sql, conn);
            command.Parameters.Add("Hoten",OracleDbType.NVarchar2, 40).Value = txtHoTen.Text;

            command.ExecuteNonQuery();
            dgv_ThongTinNV.Update();
            dgv_ThongTinNV.Refresh();
            Load_Data();
            conn.Close();


        }
    }
}
