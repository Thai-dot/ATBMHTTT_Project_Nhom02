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
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace Test2
{
    
    public partial class Login_Form : Form
    {
       
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            username_login_textBox.Focus();
        }
        
        private void login_button_Click(object sender, EventArgs e)
        {
            string strConn = "Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = "+Globals.host+")(PORT = "+Globals.port+"))(CONNECT_DATA = (SERVICE_NAME = "+Globals.SID+"))); User Id = "+username_login_textBox.Text+"; Password = "+pw_login_textBox.Text+"; ";

            OracleConnection connect = new OracleConnection(strConn);

            if (!username_login_textBox.Text.All(Char.IsLetterOrDigit) || !pw_login_textBox.Text.All(Char.IsLetterOrDigit)) //prevent SQL injection 
            {
                MessageBox.Show("VALUE ONLY LETTERS AND NUMBER!", "LOGIN FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            try
            {
                if(connect == null)
                {
                    connect = new OracleConnection(strConn);
                }
                if(connect.State == ConnectionState.Closed)
                {
                    connect.Open();

                }

                
                
                this.Hide();
                Globals.Data_String = strConn;
                Globals.username = username_login_textBox.Text;

                if (username_login_textBox.Text == "SUPERADMIN")
                {
                    ADMIN_MAIN dglAd = new ADMIN_MAIN();
                    dglAd.ShowDialog();
                }
                if(username_login_textBox.Text.Substring(0,2) == "BS")
                {
                   BacSy_Main bs = new BacSy_Main();
                    bs.ShowDialog();
                }
                if (username_login_textBox.Text.Substring(0, 2) == "TT")
                {
                    ThanhTra_Main tt = new ThanhTra_Main();
                    tt.ShowDialog();
                }
                if (username_login_textBox.Text.Substring(0, 4) == "CSYT" || username_login_textBox.Text.Substring(0, 2) == "CS")
                {
                    CoSoYTe_Main csyt = new CoSoYTe_Main();
                    csyt.ShowDialog();
                }
                if (username_login_textBox.Text.Substring(0, 2) == "NC")
                {
                    NghienCuu nc = new NghienCuu();
                    nc.ShowDialog();
                }
                if (username_login_textBox.Text.Substring(0, 2) == "BN")
                {
                    BenhNhan_Main bn = new BenhNhan_Main();
                    bn.ShowDialog();
                }



                this.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("LOGIN FAIL!!!", "USERNAME OR PASSWORD INCORRECT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
                
            }

            return;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
