using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Sales_and_Inventory_System
{
    public partial class account_manage : UserControl
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public MySqlConnection connection = new MySqlConnection(ConnectionString);
        public static account_manage instance;
        public account_manage()
        {
            InitializeComponent();
            instance = this;
        }

        private int index = 0, index1 = 0;
        private bool click = true;
        private int accont_id = 0;
        private DataTable data = new DataTable();
        private DataSet ds = new DataSet();
        private DataTable data1 = new DataTable();
        private DataSet ds1 = new DataSet();
        public void staff_account_connection()
        {
            if (Internet.CheckInternet() != false)
            {
                string Command = "SELECT staff_id_fk AS ID, staff_email AS Email,staff_password AS Password FROM tbl_staff";
                MySqlDataAdapter adapter = new MySqlDataAdapter(Command, connection);

                try
                {
                    connection.Open();
                    DataSet data = new DataSet();
                    adapter.Fill(data);
                    account.DataSource = data.Tables[0];
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
        }

        public DataTable Source1()
        {
            if (Internet.CheckInternet() != false)
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT staff_id AS ID, staff_firstname AS Firsname,staff_lastname AS Lastname, staff_contact AS Contact_Number, staff_address AS Address FROM staff_information WHERE staff_id = ?id";
                    command.Parameters.Add(new MySqlParameter("?id", MySqlDbType.Int32)).Value = accont_id;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    ds1.Clear();
                    adapter.Fill(ds1);
                    data1 = ds1.Tables[0];
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
            return data1;
        }

        public DataTable Source()
        {
            if (Internet.CheckInternet() != false)
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT staff_id_fk AS ID, staff_email AS Email,staff_password AS Password FROM tbl_staff";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    ds.Clear();
                    adapter.Fill(ds);
                    data = ds.Tables[0];
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
            return data;
        }

        private void account_manage_Load(object sender, EventArgs e)
        {
           account.DataSource = Source();
        }

        private void staff_information()
        {
            info.DataSource = Source1();
        }
        private void staff_account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (account.Rows.Count != 0)
                {
                    index = e.RowIndex;
                    DataGridViewRow view = account.Rows[index];

                    accont_id = Convert.ToInt32(view.Cells[0].Value);
                    _id.Text = view.Cells[0].Value.ToString();
                    email.Text = view.Cells[1].Value.ToString();
                    password.Text = view.Cells[2].Value.ToString();
                    staff_information();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (account.Rows.Count != 0)
                {
                    index = e.RowIndex;
                    DataGridViewRow view = info.Rows[index];

                    _id.Text = view.Cells[0].Value.ToString();
                    email.Text = view.Cells[1].Value.ToString();
                    password.Text = view.Cells[2].Value.ToString();
                    Contact.Text = view.Cells[3].Value.ToString();
                    Address.Text = view.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void update_check_empty()
        {
            if (click == true)
            {
                if (email.Text == string.Format(""))
                {
                    MessageBox.Show("email required");
                }
                else if (password.Text == string.Format(""))
                {
                    MessageBox.Show("password required");
                }
                else
                {
                    update_info();
                    clear_inputs();
                }
            }
            else
            {
                if (email.Text == string.Format(""))
                {
                    MessageBox.Show("Firsname required");
                }
                else if (password.Text == string.Format(""))
                {
                    MessageBox.Show("lastname required");
                }
                else if (Contact.Text.Equals(""))
                {
                    MessageBox.Show("Contact required");
                }
                else if (Address.Text.Equals(""))
                {
                    MessageBox.Show("Address required");
                }
                else
                {
                    if (Contact.Text[0].Equals('0') && Contact.Text[1].Equals('9') && Contact.Text.Length == 11)
                    {
                        update_info();
                        clear_inputs();
                    }
                    else
                    {
                        MessageBox.Show("Contact number is invalid, must be tsart with 09 + 9 numbers","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void delete_check_empty()
        {
            if (click == false)
            {
                if (email.Text == string.Format(""))
                {
                    MessageBox.Show("email required");
                }
                else if (password.Text == string.Format(""))
                {
                    MessageBox.Show("password required");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Note: if you delete information the account will also be deleted, proceed with caution","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        delete_info();
                        clear_inputs();
                    }
                }
            }
            else
            {
                MessageBox.Show("if you want to delete an information delete account first");
                _id.Text = string.Format("");
                email.Text = string.Format("");
                password.Text = string.Format("");
            }

        }

        private void update_info()
        {
            if (Internet.CheckInternet() != false)
            {
                if (click == true)
                {
                    string Command = @"UPDATE tbl_staff SET staff_email = ?email, staff_password = ?password WHERE staff_id_fk = ?id";
                    MySqlCommand command = new MySqlCommand(Command, connection);

                    command.Parameters.Add(new MySqlParameter("?id", MySqlDbType.Int32)).Value = Convert.ToInt32(_id.Text);
                    command.Parameters.Add(new MySqlParameter("?email", MySqlDbType.VarChar)).Value = email.Text;
                    command.Parameters.Add(new MySqlParameter("?password", MySqlDbType.VarChar)).Value = password.Text;

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        staff_account_connection();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        connection.Close();
                    }
                }
                else
                {
                    string Command = @"UPDATE staff_information SET staff_firstname = ?name, staff_lastname = ?lastname, staff_contact = ?contact , staff_address = ?address WHERE staff_id = ?id";
                    MySqlCommand command = new MySqlCommand(Command, connection);

                    command.Parameters.Add(new MySqlParameter("?id", MySqlDbType.Int32)).Value = Convert.ToInt32(_id.Text);
                    command.Parameters.Add(new MySqlParameter("?name", MySqlDbType.VarChar)).Value = email.Text;
                    command.Parameters.Add(new MySqlParameter("?lastname", MySqlDbType.VarChar)).Value = password.Text;
                    command.Parameters.Add(new MySqlParameter("?contact", MySqlDbType.Text)).Value = Contact.Text;
                    command.Parameters.Add(new MySqlParameter("?address", MySqlDbType.VarChar)).Value = Address.Text;
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        staff_information();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
           
        }

        private void delete_info()
        {
            if (Internet.CheckInternet() != false)
            {
                string Command = @"DELETE FROM staff_information WHERE staff_id = ?id";
                MySqlCommand command = new MySqlCommand(Command, connection);

                command.Parameters.Add(new MySqlParameter("?id", MySqlDbType.Int32)).Value = Convert.ToInt32(_id.Text); ;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    staff_account_connection();
                    staff_information();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
           update_check_empty();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            delete_check_empty();
        }

        private void clear_inputs()
        {
            _id.Text = string.Format("0");
            email.Text = string.Format("");
            password.Text = string.Format("");
            Contact.Text = string.Format("");
            Address.Text = string.Format("");
        }
        private void clear_input_Click(object sender, EventArgs e)
        {
            clear_inputs();
        }

        private void account_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            account.ClearSelection();
        }

        private void info_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            info.ClearSelection();
            if (info.Rows.Count != 0)
            {
                folder_icon.Image = Properties.Resources.open;
            }
        }

        private void account_btn_Click(object sender, EventArgs e)
        {
            click = true;
            account.Enabled = true;
            info.Enabled = false;
            delete_btn.Visible = false;
            disable2.Visible = true;
            disable1.Visible = false;
            _id.Text = string.Format("0");
            selectedID.Text = string.Format("Selected Account ID");
            email.HintText = string.Format("Email");
            password.HintText = string.Format("Password");
            email.Text = string.Format("");
            password.Text = string.Format("");
            Contact.Visible = false;
            Address.Visible = false;
        }

        private void staff_btn_Click(object sender, EventArgs e)
        {
            click = false;
            info.Enabled = true;
            account.Enabled = false;
            delete_btn.Visible = true;
            disable1.Visible = true;
            disable2.Visible = false;
            _id.Text = string.Format("0");
            selectedID.Text = string.Format("Selected Information ID");
            email.HintText = string.Format("Firstname");
            password.HintText = string.Format("Lastname");
            email.Text = string.Format("");
            password.Text = string.Format("");
            Contact.Visible = true;
            Address.Visible = true;
            Contact.Text = string.Format("");
            Address.Text = string.Format("");
        }

        private void account_MouseLeave(object sender, EventArgs e)
        {
            account.ClearSelection();
        }

        private void Contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void info_MouseLeave(object sender, EventArgs e)
        {
            info.ClearSelection();
        }
    }
}
