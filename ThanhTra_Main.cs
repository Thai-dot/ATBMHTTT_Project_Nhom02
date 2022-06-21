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
using System.Configuration;

namespace Test2
{
    public partial class ThanhTra_Main : Form
    {
        OracleConnection conn = new OracleConnection(Globals.Data_String);
        OracleDataAdapter adapter;
        OracleCommand command;
        public ThanhTra_Main()
        {
            InitializeComponent();
        }

        private void ThanhTra_Main_Load(object sender, EventArgs e)
        {
            conn.Open();

            string sql = "select * from SUPERADMIN.HSBA";
            command = new OracleCommand(sql, conn);

            DataTable data = new DataTable();
            adapter = new OracleDataAdapter(command);
            adapter.Fill(data);
            dataGridView_HSBA.DataSource = data;

            string sql1 = "SELECT * FROM SUPERADMIN.HSBA_DV";
            command = new OracleCommand(sql1, conn);

            DataTable data2 = new DataTable();
            adapter = new OracleDataAdapter(command);
            adapter.Fill(data2);
            dataGridView_HSBADV.DataSource = data2;

            string sql2 = "SELECT * FROM SUPERADMIN.NHANVIEN";
            command = new OracleCommand(sql2, conn);

            DataTable data3 = new DataTable();
            adapter = new OracleDataAdapter(command);
            adapter.Fill(data3);
            dataGridView_NV.DataSource = data3;

            string sql3 = "SELECT * FROM SUPERADMIN.KHOA";
            command = new OracleCommand(sql3, conn);

            DataTable data4 = new DataTable();
            adapter = new OracleDataAdapter(command);
            adapter.Fill(data4);
            dataGridView_Khoa.DataSource = data4;

            string sql4 = "SELECT * FROM SUPERADMIN.BENH_NHAN";
            command = new OracleCommand(sql4, conn);

            DataTable data5 = new DataTable();
            adapter = new OracleDataAdapter(command);
            adapter.Fill(data5);
            dataGridView_BenhNhan.DataSource = data5;

            string sql5 = "SELECT * FROM SUPERADMIN.CSYT";
            command = new OracleCommand(sql5, conn);

            DataTable data6 = new DataTable();
            adapter = new OracleDataAdapter(command);
            adapter.Fill(data6);
            dataGridView_CSYT.DataSource = data6;

            dataGridView_BenhNhan.ReadOnly = true;
            dataGridView_CSYT.ReadOnly = true;
            dataGridView_HSBA.ReadOnly = true;
            dataGridView_HSBADV.ReadOnly = true;
            dataGridView_Khoa.ReadOnly = true;
            dataGridView_NV.ReadOnly = true;

            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NhanVien_Main nv = new NhanVien_Main();
            this.Hide();
            nv.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form lg = new Login_Form();
            lg.ShowDialog();
            this.Close();
        }
    }
}
