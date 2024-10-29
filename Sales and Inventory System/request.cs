using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_and_Inventory_System
{
    public partial class request : UserControl
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public MySqlConnection connection = new MySqlConnection(ConnectionString);
        private int index = 0;
        public static request instance;
        public request()
        {
            InitializeComponent();
            instance= this;
        }

        public void Source()
        {
            if (Internet.CheckInternet() != false)
            {
                string commandString = @"SELECT request_id as Request_ID, email as Email, password as Password,firstname as FirstName, lastname as LastName, number as Contact, address as Address FROM account_request";
                MySqlDataAdapter adapter = new MySqlDataAdapter(commandString, connection);

                try
                {
                    connection.Open();
                    DataSet data = new DataSet();
                    adapter.Fill(data);
                    approval.DataSource = data.Tables[0];
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
        }

        private void request_Load(object sender, EventArgs e)
        {
           Source();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Source();
        }

        private void approval_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            approval.ClearSelection();
        }

        private void approval_MouseLeave(object sender, EventArgs e)
        {
            approval.ClearSelection();
        }

        private void Declines(int id)
        {
            if (Internet.CheckInternet() != false)
            {
                string commandString = @"DELETE FROM account_request WHERE request_id = ?id";
                MySqlCommand command = new MySqlCommand(commandString, connection);
                command.Parameters.Add(new MySqlParameter("?id", MySqlDbType.Int32)).Value = id;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    Source();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
        }

        private void Approve(int id)
        {
            if (Internet.CheckInternet() != false)
            {
                string commandString = @"INSERT INTO staff_information(staff_firstname,staff_lastname,staff_contact,staff_address)VALUES(?fname,?lname,?contact,?address)";
                string commandString1 = @"INSERT INTO tbl_staff(staff_id_fk,staff_email,staff_password)VALUES((SELECT staff_id FROM staff_information WHERE staff_firstname = ?fname AND staff_lastname = ?lname AND staff_contact = ?contact AND staff_address = ?address AND staff_id = last_insert_id()),?email,?password)";
                MySqlCommand command = new MySqlCommand(commandString, connection);
                MySqlCommand command1 = new MySqlCommand(commandString1, connection);
                command.Parameters.Add(new MySqlParameter("?fname", MySqlDbType.VarChar)).Value = approval.Rows[id].Cells[5].Value;
                command.Parameters.Add(new MySqlParameter("?lname", MySqlDbType.VarChar)).Value = approval.Rows[id].Cells[6].Value;
                command.Parameters.Add(new MySqlParameter("?contact", MySqlDbType.VarChar)).Value = approval.Rows[id].Cells[7].Value;
                command.Parameters.Add(new MySqlParameter("?address", MySqlDbType.VarChar)).Value = approval.Rows[id].Cells[8].Value;
                command1.Parameters.Add(new MySqlParameter("?email", MySqlDbType.VarChar)).Value = approval.Rows[id].Cells[3].Value;
                command1.Parameters.Add(new MySqlParameter("?password", MySqlDbType.VarChar)).Value = approval.Rows[id].Cells[4].Value;
                command1.Parameters.Add(new MySqlParameter("?fname", MySqlDbType.VarChar)).Value = approval.Rows[id].Cells[5].Value;
                command1.Parameters.Add(new MySqlParameter("?lname", MySqlDbType.VarChar)).Value = approval.Rows[id].Cells[6].Value;
                command1.Parameters.Add(new MySqlParameter("?contact", MySqlDbType.VarChar)).Value = approval.Rows[id].Cells[7].Value;
                command1.Parameters.Add(new MySqlParameter("?address", MySqlDbType.VarChar)).Value = approval.Rows[id].Cells[8].Value;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    command1.ExecuteNonQuery();
                    connection.Close();
                    Declines(Convert.ToInt32(approval.Rows[id].Cells[2].Value));
                    Source();
                    account_manage.instance.staff_account_connection();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
        }

        private void approval_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (approval.Columns[e.ColumnIndex].Name == "Decline")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to decline this account?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (result.Equals(DialogResult.Yes))
                {
                    index = e.RowIndex;

                    DataGridViewRow row = approval.Rows[index];
                    Declines(Convert.ToInt32(row.Cells[2].Value));
                }
            }
            else if (approval.Columns[e.ColumnIndex].Name == "Action")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Approve this account?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result.Equals(DialogResult.Yes))
                {
                    index = e.RowIndex;
                    Approve(index);
                }
            }
        }
       

        private void approval_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
