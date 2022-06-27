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
    }
}
