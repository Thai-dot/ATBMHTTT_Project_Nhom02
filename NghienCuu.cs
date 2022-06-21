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
	public partial class NghienCuu : Form
	{
		OracleConnection conn = new OracleConnection(Globals.Data_String);
		OracleDataAdapter adapter1;
		OracleDataAdapter adapter2;
		OracleDataAdapter adapter3;
		OracleCommand command1;
		OracleCommand command2;
		OracleCommand command3;
		public NghienCuu()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			conn.Open();

			string orclsql1 = " select * from SUPERADMIN.HSBA";
			string orclsql2 = "select MA_HSBA from SUPERADMIN.HSBA";
			command1 = new OracleCommand(orclsql1, conn);
			command2 = new OracleCommand(orclsql2, conn);

			DataTable data1 = new DataTable();
			adapter1 = new OracleDataAdapter(command1);
			adapter1.Fill(data1);
			dataGridView1.DataSource = data1;

			DataTable data2 = new DataTable();
			adapter2 = new OracleDataAdapter(command2);
			adapter2.Fill(data2);
			comboBox1.DataSource = data2;
			comboBox1.DisplayMember = "MA_HSBA";
			comboBox1.ValueMember = "MA_HSBA";

			conn.Close();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			conn.Open();
			string HSBA_ID = (string)comboBox1.SelectedValue;
			string orclsql3 = "select * from SUPERADMIN.HSBA_DV where MA_HSBA = '" + HSBA_ID +"'";
			command3 = new OracleCommand(orclsql3, conn);
			DataTable data3 = new DataTable();
			adapter3 = new OracleDataAdapter(command3);
			adapter3.Fill(data3);
			dataGridView2.DataSource = data3;
			conn.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			NhanVien_Main nv = new NhanVien_Main();
			nv.ShowDialog();
			this.Close();
		}
	}
}
