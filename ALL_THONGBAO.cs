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
    public partial class ALL_THONGBAO : Form
    {
        OracleConnection conn = new OracleConnection(Globals.Data_String);
        OracleDataAdapter adapter;
        OracleCommand command;
        public ALL_THONGBAO()
        {
            InitializeComponent();
        }

        private void ALL_THONGBAO_Load(object sender, EventArgs e)
        {
            conn.Open();
            string sql1 = "SELECT * FROM SUPERADMIN.THONG_BAO";
            command = new OracleCommand(sql1, conn);

            DataTable data2 = new DataTable();
            adapter = new OracleDataAdapter(command);
            adapter.Fill(data2);
            dataGridView1.DataSource = data2;

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Globals.username.Substring(0, 2) == "BS")
            {
                BacSy_Main bs = new BacSy_Main();
                bs.ShowDialog();
            }
            if (Globals.username.Substring(0, 2) == "NC")
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
    }
}
