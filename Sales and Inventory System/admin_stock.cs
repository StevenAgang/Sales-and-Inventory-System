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
    public partial class admin_stock : UserControl
    {
        int index = 0;
        int rowclick = 0;
        private bool click = false;
        private DataTable data = new DataTable();
        private DataSet ds = new DataSet();
        private DataTable data1 = new DataTable();
        private DataSet ds1 = new DataSet();
        public static admin_stock instance;
        private static string ConnectionString = "server = 127.0.0.1; port = 3306; username = root; password=toor; database = sales_inventory; integrated security = true;";
        public MySqlConnection connection = new MySqlConnection(ConnectionString);

        public admin_stock()
        {
            InitializeComponent();
            instance = this;
        }

        private void admin_stock_Load(object sender, EventArgs e)
        {
            inventory_item.DataSource = Source();
            size.SelectedIndex = 0;
        }

        public void Connection()
        {
            if (Internet.CheckInternet() != false)
            {
                string Command = @"SELECT item_code AS Item_ID,product_id_fk AS Product_ID,item_name AS Description,item_size AS Size,item_quantity AS Quantity,item_Expiration AS Expiration_Date FROM tbl_inventory ORDER BY item_expiration DESC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(Command, connection);

                try
                {
                    connection.Open();
                    DataSet data = new DataSet();
                    adapter.Fill(data);
                    inventory_item.DataSource = data.Tables[0];
                    connection.Close();
                    inventory_item.ClearSelection();
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

        public void expired_Connection()
        {
            if (Internet.CheckInternet() != false)
            {
                string Command = @"SELECT expired_code AS Expired_ID,expired_name AS Description,expired_size AS Size,expired_quantity AS Quantity,date_expired AS Expired_Date FROM expired_item ORDER BY date_expired DESC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(Command, connection);

                try
                {
                    connection.Open();
                    DataSet data = new DataSet();
                    adapter.Fill(data);
                    inventory_item.DataSource = data.Tables[0];
                    connection.Close();
                    inventory_item.ClearSelection();
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

        private DataTable Source1()
        {
            if (Internet.CheckInternet() != false)
            {
                string command = @"SELECT expired_code AS Expired_ID,expired_name AS Description,expired_size AS Size,expired_quantity AS Quantity,date_expired AS Expired_Date FROM expired_item ORDER BY date_expired DESC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(command, connection);
                try
                {
                    connection.Open();
                    ds1.Clear();
                    adapter.Fill(ds1);
                    data1 = ds1.Tables[0];
                    connection.Close();
                    inventory_item.ClearSelection();
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

        private DataTable Source()
        {
            if (Internet.CheckInternet() != false)
            {
                string command = @"SELECT item_code AS Item_ID, product_id_fk AS Product_ID, item_name AS Description, item_size AS Size, item_quantity AS Quantity, item_Expiration AS Expiration_Date FROM tbl_inventory ORDER BY item_expiration DESC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(command, connection);
                try
                {
                    connection.Open();
                    ds.Clear();
                    adapter.Fill(ds);
                    data = ds.Tables[0];
                    connection.Close();
                    inventory_item.ClearSelection();
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

        private void expired_btn_Click(object sender, EventArgs e)
        {
            expired_btn.Enabled = false;
            show_all.Enabled = true;
            click = true;
            clear.Visible = true;
            item_name.Enabled = false;
            size.Enabled = false;
            item_quantity.Enabled = false;
            label1.Enabled = false;
            label2.Enabled = false;
            update_btn.Enabled = false;
            delete_btn.Enabled = false;
            clear_input.Enabled = false;
            item_name.Text = string.Format("");
            size.Text = string.Format("");
            item_quantity.Text = string.Format("");
            inventory_item.DataSource = Source1();
            expired_Connection();
            search_txt.Text = string.Format("");
        }

        private void show_all_Click(object sender, EventArgs e)
        {
            expired_btn.Enabled = true;
            show_all.Enabled = false;
            click = false;
            clear.Visible = false;
            item_name.Enabled = true;
            size.Enabled = true;
            item_quantity.Enabled = true;
            label1.Enabled = true;
            label2.Enabled = true;
            update_btn.Enabled = true;
            delete_btn.Enabled = true;
            clear_input.Enabled = true;
            item_name.Text = string.Format("");
            size.Text = string.Format("");
            item_quantity.Text = string.Format("");
            inventory_item.DataSource = Source();
            Connection();
            search_txt.Text = string.Format("");
        }

        private void search_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (click == true)
            {
                DataView view = data1.DefaultView;
                view.RowFilter = string.Format("Convert(Expired_ID, 'System.String') like '%{0}%' or Description like '%{0}%' or Size like '%{0}%'", search_txt.Text);
                inventory_item.DataSource = view.ToTable();
            }
            else
            {
                try
                {
                    DataView view = data.DefaultView;
                    view.RowFilter = string.Format("Convert(Item_ID, 'System.String') like '%{0}%' or Convert(Product_ID, 'System.String') like '%{0}%'or Description like '%{0}%' or Size like '%{0}%' or Convert(Quantity, 'System.String') like '%{0}%' ", search_txt.Text);
                    inventory_item.DataSource = view.ToTable();
                }
                catch (Exception)
                {

                }
            }
        }
        public void updateforeigntovalue()
        {
            if (Internet.CheckInternet() != false)
            {
                int product_id;
                string commandstring = @"SELECT product_id FROM tbl_product WHERE product_desc = ?name AND product_size = ?size";
                MySqlCommand command = new MySqlCommand(commandstring, connection);
                command.Parameters.Add(new MySqlParameter("?name", MySqlDbType.VarChar)).Value = item_name.Text;
                command.Parameters.Add(new MySqlParameter("?size", MySqlDbType.VarChar)).Value = size.SelectedItem.ToString();

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        product_id = Convert.ToInt32(result);
                        Console.WriteLine(product_id.ToString());
                        string Command1 = @"UPDATE tbl_inventory SET product_id_fk = ?product_id WHERE item_name = ?name AND item_size = ?size";
                        MySqlCommand command1 = new MySqlCommand(Command1, connection);
                        command1.Parameters.Add(new MySqlParameter("?product_id", MySqlDbType.Int32)).Value = product_id;
                        command1.Parameters.Add(new MySqlParameter("?name", MySqlDbType.VarChar)).Value = item_name.Text;
                        command1.Parameters.Add(new MySqlParameter("?size", MySqlDbType.VarChar)).Value = size.SelectedItem.ToString();
                        MySqlDataReader reader = command1.ExecuteReader();
                        reader.Read();
                        reader.Close();
                    }
                    else
                    {
                        connection.Close();
                        updateforeigntonull();
                    }
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

        public void updateforeigntonull()
        {
            if (Internet.CheckInternet() != false)
            {
                string Command1 = @"UPDATE tbl_inventory SET product_id_fk = null WHERE item_name = ?name AND item_size = ?size";
                MySqlCommand command1 = new MySqlCommand(Command1, connection);
                command1.Parameters.Add(new MySqlParameter("?name", MySqlDbType.VarChar)).Value = item_name.Text;
                command1.Parameters.Add(new MySqlParameter("?size", MySqlDbType.VarChar)).Value = size.SelectedItem.ToString();
              
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command1.ExecuteReader();
                    reader.Read();
                    reader.Close();
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

        private void update_product()
        {
            if (Internet.CheckInternet() != false)
            {
                int quantity = 0;
                string Command = @"UPDATE tbl_inventory SET item_name = ?name, item_size = ?size, item_quantity = ?quantity, item_code = ?code WHERE item_code = ?code";
                MySqlCommand command = new MySqlCommand(Command, connection);
                int.TryParse(item_quantity.Text, out quantity);
                command.Parameters.Add(new MySqlParameter("?name", MySqlDbType.VarChar)).Value = item_name.Text;
                command.Parameters.Add(new MySqlParameter("?size", MySqlDbType.VarChar)).Value = size.Text;
                command.Parameters.Add(new MySqlParameter("?quantity", MySqlDbType.Int32)).Value = quantity;
                command.Parameters.Add(new MySqlParameter("?code",  MySqlDbType.Int32)).Value = Convert.ToInt32(prod_id.Text);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    reader.Close();
                    connection.Close();
                    updateforeigntovalue();
                    admin_supplier.instance.CheckStatus_OnLoad();
                    Connection();
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

        private void delete_product()
        {
            if (Internet.CheckInternet() != false)
            {
                updateforeigntonull();
                string Command = @"DELETE FROM tbl_inventory WHERE item_name = ?name AND item_size = ?size AND item_code = ?code";
                MySqlCommand command = new MySqlCommand(Command, connection);

                command.Parameters.Add(new MySqlParameter("?name", MySqlDbType.VarChar)).Value = item_name.Text;
                command.Parameters.Add(new MySqlParameter("?size", MySqlDbType.VarChar)).Value = size.Text;
                command.Parameters.Add(new MySqlParameter("?code", MySqlDbType.Int32)).Value = Convert.ToInt32(prod_id.Text);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    reader.Close();
                    connection.Close();
                    admin_supplier.instance.CheckStatus_OnLoad();
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

        private void inventory_item_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (inventory_item.Rows.Count != 0)
            {
                try
                {
                    index = e.RowIndex;
                    DataGridViewRow row = inventory_item.Rows[index];

                    prod_id.Text = row.Cells[0].Value.ToString();
                    item_name.Text = row.Cells[2].Value.ToString();
                    size.Text = row.Cells[3].Value.ToString();
                    item_quantity.Text = row.Cells[4].Value.ToString();

                    rowclick = index;
                }
                catch(Exception)
                {

                }
            }
        }

        private void item_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (inventory_item.Rows.Count != 0)
            {
                if (item_name.Text.Equals(""))
                {
                    MessageBox.Show("item name required");
                    item_name.Focus();
                }
                else if (item_quantity.Text == string.Format(""))
                {
                    MessageBox.Show("item quantity required");
                    item_quantity.Focus();
                }
                else
                {
                    update_product();
                    inventory_item.DataSource = Source();
                    prod_id.Text = string.Format("Selected Product ID:");
                    item_name.Text = string.Format("");
                    size.Text = string.Format("");
                    item_quantity.Text = string.Format("");
                }
            }
            else
            {
                MessageBox.Show("Stock is empty");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (inventory_item.Rows.Count != 0)
            {
                if (item_name.Text == string.Format(""))
                {
                    MessageBox.Show("item name required");
                    item_name.Focus();
                }
                else if (item_quantity.Text == string.Format(""))
                {
                    MessageBox.Show("item quantity required");
                    item_quantity.Focus();
                }
                else
                {
                    delete_product();
                    inventory_item.DataSource = Source();
                    item_name.Text = string.Format("");
                    size.Text = string.Format("");
                    item_quantity.Text = string.Format("");
                }
            }
            else
            {
                MessageBox.Show("Stock is empty");
            }
        }

        private void clear_input_Click(object sender, EventArgs e)
        {
            prod_id.Text = string.Format("Selected Item ID:");
            item_name.Text = string.Format("");
            size.SelectedIndex = 0;
            item_quantity.Text = string.Format("");
        }

        private void item_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                size.Focus();
            }
        }

        private void item_size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    item_quantity.Focus();
                }
            }
        }

        private void item_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void clear_all()
        {
            if (Internet.CheckInternet() != false)
            {
                string Command = @"TRUNCATE TABLE expired_item";
                MySqlCommand command = new MySqlCommand(Command, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Close();
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

        private void clear_Click(object sender, EventArgs e)
        {
            clear_all();
            expired_Connection();
        }

        private void inventory_item_MouseLeave(object sender, EventArgs e)
        {
            inventory_item.ClearSelection();
        }

        private void inventory_item_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            inventory_item.ClearSelection();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            if (click == false)
            {
                Connection();
            }
            else
            {
                expired_Connection();
            }
        }
    }
}
