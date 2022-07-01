using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Oracle.ManagedDataAccess.Client;

namespace Test2
{
    public partial class BenhNhan_Main : Form
    {
        OracleConnection conn = new OracleConnection(Globals.Data_String);
        OracleDataAdapter adapter;
        OracleCommand command;
        public BenhNhan_Main()
        {
            InitializeComponent();

        }


        private void BenhNhan_Main_Load(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "select * from SUPERADMIN.Benh_Nhan";
            command = new OracleCommand(sql, conn);

            DataTable data = new DataTable();
            adapter = new OracleDataAdapter(command);
            adapter.Fill(data);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            dgv_ThongTinBN.DataSource = tbl;
            dgv_ThongTinBN.Columns[0].HeaderText = "MÃ BỆNH NHÂN";
            dgv_ThongTinBN.Columns[1].HeaderText = "CƠ SỞ Y TẾ";
            dgv_ThongTinBN.Columns[2].HeaderText = "TÊN BỆNH NHÂN";
            dgv_ThongTinBN.Columns[3].HeaderText = "SỐ CMND";
            dgv_ThongTinBN.Columns[4].HeaderText = "NGÀY SINH";
            dgv_ThongTinBN.Columns[5].HeaderText = "SỐ NHÀ";
            dgv_ThongTinBN.Columns[6].HeaderText = "TÊN ĐƯỜNG";
            dgv_ThongTinBN.Columns[7].HeaderText = "QUẬN/HUYỆN";
            dgv_ThongTinBN.Columns[8].HeaderText = "TỈNH/THÀNH PHỐ";
            dgv_ThongTinBN.Columns[9].HeaderText = "DỰ ĐOÁN";
            dgv_ThongTinBN.Columns[10].HeaderText = "TIỀN SỬ BỆNH";
            dgv_ThongTinBN.Columns[11].HeaderText = "DỊ ỨNG THUỐC";
            dgv_ThongTinBN.EditMode = DataGridViewEditMode.EditProgrammatically;

            //textBox_tenBN.Text = dgv_ThongTinBN.CurrentCell.
            conn.Close();
        }

        public void Load_Data()
        {
            string sql = "select * from SUPERADMIN.Benh_Nhan";
            command = new OracleCommand(sql, conn);

            DataTable data = new DataTable();
            adapter = new OracleDataAdapter(command);
            adapter.Fill(data);
            dgv_ThongTinBN.DataSource = data;
        }

        private void dgv_ThongTinBN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_tenBN.Text = dgv_ThongTinBN.CurrentRow.Cells["TEN_BN"].Value.ToString();
            textBox_CMND_BN.Text = dgv_ThongTinBN.CurrentRow.Cells["CMND"].Value.ToString();
            textBox_quanHuyenBN.Text = dgv_ThongTinBN.CurrentRow.Cells["QUAN_HUYEN"].Value.ToString();
            textBox_soNhaBN.Text = dgv_ThongTinBN.CurrentRow.Cells["SO_NHA"].Value.ToString();
            textBox_tenDuongBN.Text = dgv_ThongTinBN.CurrentRow.Cells["TEN_DUONG"].Value.ToString();
            textBox_tinhThanhPho_BN.Text = dgv_ThongTinBN.CurrentRow.Cells["TINH_TP"].Value.ToString();
        }

        private void button_capNhatBN_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "";
            sql = @"Update SUPERADMIN.BENH_NHAN set TEN_BN = :Hoten , CMND = :SoCMND , SO_NHA = :sonha , TEN_DUONG = :tenduong , QUAN_HUYEN = :quanhuyen , TINH_TP = :tinhtp where MA_BN = '" + Globals.username + "'";
            command = new OracleCommand(sql, conn);
            command.Parameters.Add("Hoten", OracleDbType.NVarchar2, 40).Value = textBox_tenBN.Text;
            command.Parameters.Add("SoCMND", OracleDbType.NVarchar2, 15).Value = textBox_CMND_BN.Text;
            command.Parameters.Add("sonha", OracleDbType.NVarchar2, 10).Value = textBox_soNhaBN.Text;
            command.Parameters.Add("tenduong", OracleDbType.NVarchar2, 40).Value = textBox_tenDuongBN.Text;
            command.Parameters.Add("quanhuyen", OracleDbType.NVarchar2, 40).Value = textBox_quanHuyenBN.Text;
            command.Parameters.Add("tinhtp", OracleDbType.NVarchar2, 40).Value = textBox_tinhThanhPho_BN.Text;

            command.ExecuteNonQuery();
            dgv_ThongTinBN.Update();
            dgv_ThongTinBN.Refresh();
            Load_Data();
            conn.Close();
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form lg = new Login_Form();
            lg.ShowDialog();
            
        }

        private void button_TB_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ALL_THONGBAO a = new ALL_THONGBAO();
            a.ShowDialog();
            //this.Close();
        }
    }
}
