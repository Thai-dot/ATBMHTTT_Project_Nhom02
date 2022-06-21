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

    public partial class CoSoYTe_Main : Form
    {
        OracleConnection conn = new OracleConnection(Globals.Data_String);
        OracleDataAdapter adapter;
        OracleCommand command;
        public CoSoYTe_Main()
        {
            InitializeComponent();
        }

        private void CoSoYTe_Main_Load(object sender, EventArgs e)
        {
            conn.Open();

            string sql = "select * from SUPERADMIN.HSBA";
            command = new OracleCommand(sql, conn);

            DataTable data = new DataTable();
            adapter = new OracleDataAdapter(command);
            adapter.Fill(data);
            dataGridView_HSBA.DataSource = data;

            conn.Close();
        }

        private void dataGridView_HSBA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();

            int i;
            i = dataGridView_HSBA.CurrentRow.Index;

            string sql = "select * from SUPERADMIN.HSBA_DV WHERE MA_HSBA =:ma_hsba";
            command = new OracleCommand(sql, conn);
            command.Parameters.Add("ma_hsba", OracleDbType.Varchar2, 50).Value = dataGridView_HSBA.Rows[i].Cells[0].Value.ToString();

            DataTable data = new DataTable();
            adapter = new OracleDataAdapter(command);
            adapter.Fill(data);
            dataGridView_HSBADV.DataSource = data;

            conn.Close();
        }

        private void button_themhsba_Click(object sender, EventArgs e)
        {
            conn.Open();

            string sql = @"INSERT INTO SUPERADMIN.HSBA (MA_HSBA, MA_BN, NGAY, CHAN_DOAN, MA_BS, MA_KHOA, MA_CSYT, KET_LUAN) VALUES (:mahsba, :mabn, :ngay, :chandoan, :mabs, :makhoa, :macsyt, :ketluan)";
            command = new OracleCommand(sql, conn);
            command.Parameters.Add("mahsba", OracleDbType.Int32, 6).Value = Int32.Parse(textBox_mahsba.Text);
            command.Parameters.Add("mabn", OracleDbType.Int32, 6).Value = Int32.Parse(textBox_mabn.Text);
            command.Parameters.Add("ngay", OracleDbType.Date, 7).Value = dateTimePicker_ngaythemhsba.Value;
            command.Parameters.Add("chandoan", OracleDbType.NVarchar2, 40).Value = textBox_chandoan.Text;
            command.Parameters.Add("mabs", OracleDbType.Int32, 6).Value = Int32.Parse(textBox_mabacsi.Text);
            command.Parameters.Add("makhoa", OracleDbType.Int32, 6).Value = Int32.Parse(textBox_makhoa.Text);
            command.Parameters.Add("macsyt", OracleDbType.Int32, 6).Value = Int32.Parse(textBox_macsyt.Text);
            command.Parameters.Add("ketluan", OracleDbType.NVarchar2, 40).Value = richTextBox_ketluan.Text;
            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm HSBA thành công!");
            }
            else
            {
                MessageBox.Show("Thêm HSBA thất bại!");
            }

            conn.Close();
        }

        private void button_reloadhsba_Click(object sender, EventArgs e)
        {
            CoSoYTe_Main_Load(sender, e);
        }

        private void button_xoahsba_Click(object sender, EventArgs e)
        {
            conn.Open();

            string sql = "DELETE FROM SUPERADMIN.HSBA WHERE MA_HSBA = :mahsba";
            command = new OracleCommand(sql, conn);
            command.Parameters.Add("mahsba", OracleDbType.Int32, 6).Value = Int32.Parse(textBox_mahsba.Text);
            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Xóa HSBA thành công!");
            }
            else
            {
                MessageBox.Show("Xóa HSBA thất bại!");
            }    

            conn.Close();
        }

        private void button_themdv_Click(object sender, EventArgs e)
        {
            conn.Open();

            string sql = @"INSERT INTO SUPERADMIN.HSBA_DV (MA_HSBA, MA_DV, NGAY, MA_KTV, KET_QUA) VALUES (:mahsba, :madv, :ngay, :maktv, :ketqua)";
            command = new OracleCommand(sql, conn);
            command.Parameters.Add("mahsba", OracleDbType.Int32, 6).Value = Int32.Parse(textBox_mahsbadv.Text);
            command.Parameters.Add("madv", OracleDbType.Int32, 6).Value = Int32.Parse(textBox_madv.Text);
            command.Parameters.Add("ngay", OracleDbType.Date, 7).Value = dateTimePicker_ngaythemdv.Value;
            command.Parameters.Add("maktv", OracleDbType.Int32, 6).Value = Int32.Parse(textBox_maktv.Text);
            command.Parameters.Add("ketqua", OracleDbType.NVarchar2, 40).Value = richTextBox_ketqua.Text;
            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm dịch vụ thành công!");
            }
            else
            {
                MessageBox.Show("Thêm dịch vụ thất bại!");
            }

            conn.Close();
        }

        private void button_xoadv_Click(object sender, EventArgs e)
        {
            conn.Open();

            string sql = "DELETE FROM SUPERADMIN.HSBA_DV WHERE MA_HSBA = :mahsba AND MA_DV = :madv AND NGAY = :ngay";
            command = new OracleCommand(sql, conn);
            command.Parameters.Add("mahsba", OracleDbType.Int32, 6).Value = Int32.Parse(textBox_xoamahsbadv.Text);
            command.Parameters.Add("madv", OracleDbType.Int32, 6).Value = Int32.Parse(textBox_xoamadv.Text);
            command.Parameters.Add("ngay", OracleDbType.Date, 7).Value = dateTimePicker_xoangaythemdv.Value;
            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Xóa HSBA thành công!");
            }
            else
            {
                MessageBox.Show("Xóa HSBA thất bại!");
            }

            conn.Close();
        }

        private void dataGridView_HSBADV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();

            int i;
            i = dataGridView_HSBADV.CurrentRow.Index;
            textBox_xoamahsbadv.Text = dataGridView_HSBADV.Rows[i].Cells[0].Value.ToString();
            textBox_xoamadv.Text = dataGridView_HSBADV.Rows[i].Cells[1].Value.ToString();
            dateTimePicker_xoangaythemdv.Text = dataGridView_HSBADV.Rows[i].Cells[2].Value.ToString();

            conn.Close();
        }
    }
}
