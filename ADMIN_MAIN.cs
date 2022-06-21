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
    public partial class ADMIN_MAIN : Form
    {
        OracleConnection conn = new OracleConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        OracleDataAdapter adapter;
        OracleCommand command;
        public ADMIN_MAIN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string sql = "select * from DBA_USERS";
                command = new OracleCommand(sql, conn);

                DataTable data = new DataTable();
                adapter = new OracleDataAdapter(command);
                adapter.Fill(data);
                dgv_users.DataSource = data;

                string sql1 = "SELECT * FROM DBA_ROLES";
                command = new OracleCommand(sql1, conn);

                DataTable data2 = new DataTable();
                adapter = new OracleDataAdapter(command);
                adapter.Fill(data2);
                dgv_role.DataSource = data2;



                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = new OracleCommand("DROP_ROLE", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@roleName", OracleDbType.Varchar2).Value = tb_roleName.Text;

                command.ExecuteNonQuery();
                MessageBox.Show("Role successful deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = new OracleCommand("ADD_USER", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@userName", OracleDbType.Varchar2).Value = tb_userName_create.Text;
                command.Parameters.Add("@pass", OracleDbType.Varchar2).Value = tb_userPass_Create.Text;

                command.ExecuteNonQuery();
                MessageBox.Show("User successful created");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void bt_role_create_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = new OracleCommand("ADD_ROLE", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@roleName", OracleDbType.Varchar2).Value = tb_roleName.Text;

                command.ExecuteNonQuery();
                MessageBox.Show("Role successful created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void bt_user_delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = new OracleCommand("DROP_USER", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@userName", OracleDbType.Varchar2).Value = tb_username_del.Text;

                command.ExecuteNonQuery();
                MessageBox.Show("User successful deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgv_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = dgv_users.CurrentRow.Index;
            user_name_text.Text = dgv_users.Rows[numrow].Cells[0].Value.ToString();
        }

        private void dgv_roles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string sql = "select * from DBA_USERS";
                command = new OracleCommand(sql, conn);

                DataTable data = new DataTable();
                adapter = new OracleDataAdapter(command);
                adapter.Fill(data);
                dgv_users.DataSource = data;

                string sql1 = "select * from DBA_ROLES";
                command = new OracleCommand(sql1, conn);

                DataTable data2 = new DataTable();
                adapter = new OracleDataAdapter(command);
                adapter.Fill(data2);
                dgv_role.DataSource = data2;



                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                if (check_with.Checked == false)
                {
                    if (tb_col.Text == "")
                    {
                        if (check_select.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string sql1 = String.Format("grant select on {0} to {1}", tableName, name);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                        if (check_insert.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string sql1 = String.Format("grant insert on {0} to {1}", tableName, name);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                        if (check_update.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string sql1 = String.Format("grant update on {0} to {1}", tableName, name);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                        if (check_delete.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string sql1 = String.Format("grant delete on {0} to {1}", tableName, name);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                    }
                    else if (tb_col.Text != "")
                    {
                        if (check_select.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string columnName = tb_col.Text;
                            string sql1 = String.Format("grant select ({2}) on {0} to {1}", tableName, name, columnName);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                        if (check_insert.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string columnName = tb_col.Text;
                            string sql1 = String.Format("grant insert ({2}) on {0} to {1}", tableName, name, columnName);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                        if (check_update.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string columnName = tb_col.Text;
                            string sql1 = String.Format("grant update ({2}) on {0} to {1}", tableName, name, columnName);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                        if (check_delete.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string columnName = tb_col.Text;
                            string sql1 = String.Format("grant delete ({2}) on {0} to {1}", tableName, name, columnName);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                else if (check_with.Checked == true)
                {
                    if (tb_col.Text == "")
                    {
                        if (check_select.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string sql1 = String.Format("grant select on {0} to {1} with grant option", tableName, name);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                        if (check_insert.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string sql1 = String.Format("grant insert on {0} to {1} with grant option", tableName, name);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                        if (check_update.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string sql1 = String.Format("grant update on {0} to {1} with grant option", tableName, name);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                        if (check_delete.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string sql1 = String.Format("grant delete on {0} to {1} with grant option", tableName, name);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                    }
                    else if (tb_col.Text != "")
                    {
                        if (check_select.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string columnName = tb_col.Text;
                            string sql1 = String.Format("grant select ({2}) on {0} to {1} with grant option", tableName, name, columnName);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                        if (check_insert.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string columnName = tb_col.Text;
                            string sql1 = String.Format("grant insert ({2}) on {0} to {1} with grant option", tableName, name, columnName);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                        if (check_update.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string columnName = tb_col.Text;
                            string sql1 = String.Format("grant update ({2}) on {0} to {1} with grant option", tableName, name, columnName);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                        if (check_delete.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string columnName = tb_col.Text;
                            string sql1 = String.Format("grant delete ({2}) on {0} to {1} with grant option", tableName, name, columnName);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                    }
                }    

                

                string sql = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE =:name_user";
                command = new OracleCommand(sql, conn);
                command.Parameters.Add("name_user", OracleDbType.Varchar2, 50).Value = tb_name_pri.Text;

                DataTable data2 = new DataTable();
                adapter = new OracleDataAdapter(command);
                adapter.Fill(data2);
                dgv_check_pri.DataSource = data2;


                MessageBox.Show("Successful granted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {               
                if (check_with.Checked == false)
                {
                    if (tb_col.Text == "")
                    {
                        if (check_select.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string sql1 = String.Format("revoke select on {0} from {1}", tableName, name);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                        if (check_insert.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string sql1 = String.Format("revoke insert on {0} from {1}", tableName, name);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                        if (check_update.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string sql1 = String.Format("revoke update on {0} from {1}", tableName, name);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                        if (check_delete.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string sql1 = String.Format("revoke delete on {0} from {1}", tableName, name);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                    }
                    else if (tb_col.Text != "")
                    {
                        if (check_select.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string columnName = tb_col.Text;
                            string sql1 = String.Format("revoke select ({2}) on {0} from {1}", tableName, name, columnName);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                        if (check_insert.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string columnName = tb_col.Text;
                            string sql1 = String.Format("revoke insert ({2}) on {0} from {1}", tableName, name, columnName);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                        if (check_update.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string columnName = tb_col.Text;
                            string sql1 = String.Format("revoke update ({2}) on {0} from {1}", tableName, name, columnName);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                        if (check_delete.Checked == true)
                        {
                            string name = tb_name_pri.Text;
                            string tableName = cb_name_table.Text;
                            string columnName = tb_col.Text;
                            string sql1 = String.Format("revoke delete ({2}) on {0} from {1}", tableName, name, columnName);
                            command = new OracleCommand(sql1, conn);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                else if (check_with.Checked == true)
                {
                    string sql1 = "revoke select on :tableName from :name with grant option";
                    command = new OracleCommand(sql1, conn);
                    command.ExecuteNonQuery();
                }

                

                string sql = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE =:name_user";
                command = new OracleCommand(sql, conn);
                command.Parameters.Add("name_user", OracleDbType.Varchar2, 50).Value = tb_name_pri.Text;

                DataTable data2 = new DataTable();
                adapter = new OracleDataAdapter(command);
                adapter.Fill(data2);
                dgv_check_pri.DataSource = data2;


                MessageBox.Show("Successful revoked");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string user = tb_user.Text;
                string role = tb_role.Text;
                string sql1 = String.Format("grant {0} to {1}", role, user);
                command = new OracleCommand(sql1, conn);
                command.ExecuteNonQuery();

                MessageBox.Show("Successful granted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string user = tb_user.Text;
                string role = tb_role.Text;
                string sql1 = String.Format("revoke {0} from {1}", role, user);
                command = new OracleCommand(sql1, conn);
                command.ExecuteNonQuery();

                MessageBox.Show("Successful revoked");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                command = new OracleCommand("USER_ALTER", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@name_user", OracleDbType.Varchar2).Value = tb_update_name.Text;
                command.Parameters.Add("@new_pass", OracleDbType.Varchar2).Value = tb_new_pass.Text;

                command.ExecuteNonQuery();
                MessageBox.Show("Successful Changed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            conn.Open();
            try
            {
                string sql = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE =:name_user";
                command = new OracleCommand(sql, conn);
                command.Parameters.Add("name_user", OracleDbType.Varchar2, 50).Value = user_name_text.Text;

                DataTable data = new DataTable();
                adapter = new OracleDataAdapter(command);
                adapter.Fill(data);
                dgv_user_privi.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                if (check_with_ad.Checked == false)
                {
                    string user = tb_user_sp.Text;
                    string sp = cb_user_sp.Text;
                    string sql1 = String.Format("grant {0} to {1}", sp, user);
                    command = new OracleCommand(sql1, conn);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Successful granted");
                }
                else if (check_with_ad.Checked == true)
                {
                    string user = tb_user_sp.Text;
                    string sp = cb_user_sp.Text;
                    string sql1 = String.Format("grant {0} to {1} with admin option", sp, user);
                    command = new OracleCommand(sql1, conn);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Successful granted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string user = tb_user_sp.Text;
                string sp = cb_user_sp.Text;
                string sql1 = String.Format("revoke {0} from {1}", sp, user);
                command = new OracleCommand(sql1, conn);
                command.ExecuteNonQuery();

                MessageBox.Show("Successful revoked");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {

            conn.Open();
            try
            {
                string sql = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE =:name_role";
                command = new OracleCommand(sql, conn);
                command.Parameters.Add("name_role", OracleDbType.Varchar2, 50).Value = rolename_textbox.Text;

                DataTable data = new DataTable();
                adapter = new OracleDataAdapter(command);
                adapter.Fill(data);
                dgv_role2.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgv_role_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = dgv_role.CurrentRow.Index;
            rolename_textbox.Text = dgv_role.Rows[numrow].Cells[0].Value.ToString();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}