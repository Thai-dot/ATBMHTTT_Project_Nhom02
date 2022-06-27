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
    public partial class BacSy_Main : Form
    {
        OracleConnection conn = new OracleConnection(Globals.Data_String);
        OracleDataAdapter adapter1;
        OracleDataAdapter adapter2;
        OracleCommand command1;
        OracleCommand command2;
        public BacSy_Main()
        {
            InitializeComponent();
        }

        private void BacSy_Main_Load(object sender, EventArgs e)
        {
            conn.Open();

            string sql1 = "select * from SUPERADMIN.HSBA";
            string sql2 = "select * from SUPERADMIN.HSBA_DV";
            command1 = new OracleCommand(sql1, conn);
            command2 = new OracleCommand(sql2, conn);

            DataTable data1 = new DataTable();
            adapter1 = new OracleDataAdapter(command1);
            adapter1.Fill(data1);
            dgv_HSBA_BS.DataSource = data1;

            DataTable data2 = new DataTable();
            adapter2 = new OracleDataAdapter(command2);
            adapter2.Fill(data2);
            dgv_HSBADV_BacSy.DataSource = data2;

            conn.Close();
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            String value = txb_Ma_BN.Text;

            if (value.Substring(0, 2) == "BN")
            {
                string sql = "select * from SUPERADMIN.BENH_NHAN where MA_BN = :ma_bn";
                command1 = new OracleCommand(sql, conn);
                command1.Parameters.Add("ma_bn", OracleDbType.Varchar2, 10).Value = value;

                DataTable data = new DataTable();
                adapter1 = new OracleDataAdapter(command1);
                adapter1.Fill(data);
                dgv_benhnhan_bacsy.DataSource = data;

            }

            else if (value.Substring(0, 2) == "33")
            {
                string sql = "select * from SUPERADMIN.BENH_NHAN where CMND = '" + value + "'";
                command1 = new OracleCommand(sql, conn);

                DataTable data = new DataTable();
                adapter1 = new OracleDataAdapter(command1);
                adapter1.Fill(data);
                dgv_benhnhan_bacsy.DataSource = data;
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien_Main nv = new NhanVien_Main();
            nv.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form lg = new Login_Form();
            lg.ShowDialog();
            this.Close();
           
        }

        private void button_TB_Click(object sender, EventArgs e)
        {
            this.Hide();
            ALL_THONGBAO a = new ALL_THONGBAO();
            a.ShowDialog();
            this.Close();
        }
    }
}
