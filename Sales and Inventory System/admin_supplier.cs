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
using System.Threading;

namespace Sales_and_Inventory_System
{
    public partial class admin_supplier : UserControl
    {
        int index = 0;
        private int rowclick = 0;
        private string actionclick = "add";
        private DataTable data = new DataTable();
        private DataSet ds = new DataSet();
        public static admin_supplier instance;
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public MySqlConnection connection = new MySqlConnection(ConnectionString);

        public admin_supplier()
        {
            InitializeComponent();
            instance = this;
        }

        private DataTable Source()
        {
            if (Internet.CheckInternet() != false)
            {
                string command = @"SELECT product_id AS Product_ID,product_desc AS Description,product_size AS Size,product_price AS Price,date_added,(SELECT Product_Status FROM item_status WHERE stat_id = tbl_product.Status) AS Status FROM tbl_product ORDER BY product_id ASC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(command, connection);
                try
                {
                    connection.Open();
                    ds.Clear(); 
                    adapter.Fill(ds);
                    data = ds.Tables[0];
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
            return data;
        }

        public void Connection()
        {
            if (Internet.CheckInternet() != false)
            {
                string Command = "SELECT product_id AS Product_ID,product_desc AS Description,product_size AS Size,product_price AS Price,date_added,(SELECT Product_Status FROM item_status WHERE stat_id = tbl_product.Status) AS Status FROM tbl_product ORDER BY product_id ASC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(Command, connection);

                try
                {
                    connection.Open();
                    DataSet data = new DataSet();
                    adapter.Fill(data);
                    product_grid.DataSource = data.Tables[0];
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

        private void Style()
        {
            if (product_grid.Rows.Count != 0)
            {
                try
                {
                    for (int i = 0; i < product_grid.Rows.Count; i++)
                    {
                        if (product_grid.Rows[i].Cells[5].Value.ToString().Equals("Available"))
                        {
                            product_grid.Rows[i].Cells[5].Style.ForeColor = Color.Green;
                        }
                        else
                        {
                            product_grid.Rows[i].Cells[5].Style.ForeColor = Color.Red;
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void check_empty()
        {
            int check = 0;
            prod_desc.Text = prod_desc.Text.ToLower();
            int.TryParse(prod_price.Text, out check);
            if(prod_desc.Text == string.Format(""))
            {
                MessageBox.Show("product name required");
                prod_desc.Focus();
            }else if (prod_price.Text == string.Format(""))
            {
                MessageBox.Show("product price required");
                prod_price.Focus();
            }
            else if(check == 0)
            {
                MessageBox.Show("product price cannot be zero");
                prod_price.Focus();
            }
            else
            {
                actionclick = "add";
                CheckProductExist();
                product_grid.DataSource = Source();
                prod_id.Text = string.Format("");
                prod_desc.Text = string.Format("");
                size.SelectedIndex = 0;
                prod_price.Text = string.Format("");
            }
        }

        private void CheckProductExist()
        {
            if (product_grid.Rows.Count != 0)
            {
                int count = 0;
                for (int i = 0; i < product_grid.Rows.Count; i++)
                {
                    if (prod_desc.Text.Equals(product_grid.Rows[i].Cells[1].Value.ToString()) && size.SelectedItem.Equals(product_grid.Rows[i].Cells[2].Value.ToString()))
                    {
                        count += 1;
                    }
                }

                if (count != 0)
                {
                    MessageBox.Show("Product Already Exist", "Error_Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (actionclick == "add")
                    {
                        CheckStatus();
                    }
                    else
                    {
                        update_product();
                    }
                }
            }
            else
            {
                if (actionclick == "add")
                {
                    CheckStatus();
                }
                else
                {
                    update_product();
                }
            }
        }

        private int status;

        public void CheckStatus_OnLoad()
        {
            if (product_grid.Rows.Count != 0)
            {
                if (Internet.CheckInternet() != false)
                {
                    for (int i = 0; i < product_grid.Rows.Count; i++)
                    {
                        string commandstring = @"SELECT item_name,item_size FROM tbl_inventory WHERE product_id_fk = ?id AND item_name = ?name AND item_size = ?size AND item_quantity <> 0 ";
                        string commandstring1 = @"UPDATE tbl_product SET Status = " + 2 + " WHERE product_id = ?id";
                        string commandstring2 = @"UPDATE tbl_product SET Status = " + 1 + " WHERE product_id = ?id";
                        MySqlCommand command1 = new MySqlCommand(commandstring1, connection);
                        MySqlCommand command = new MySqlCommand(commandstring, connection);
                        MySqlCommand command2 = new MySqlCommand(commandstring2, connection);
                        command.Parameters.Add(new MySqlParameter("?name", MySqlDbType.VarChar)).Value = product_grid.Rows[i].Cells[1].Value;
                        command.Parameters.Add(new MySqlParameter("?size", MySqlDbType.VarChar)).Value = product_grid.Rows[i].Cells[2].Value;
                        command.Parameters.Add(new MySqlParameter("?id", MySqlDbType.Int32)).Value = product_grid.Rows[i].Cells[0].Value;
                        command1.Parameters.Add(new MySqlParameter("?id", MySqlDbType.Int32)).Value = product_grid.Rows[i].Cells[0].Value;
                        command2.Parameters.Add(new MySqlParameter("?id", MySqlDbType.Int16)).Value = product_grid.Rows[i].Cells[0].Value;

                        try
                        {
                            connection.Open();
                            MySqlDataReader reader = command.ExecuteReader();

                            if (reader.HasRows)
                            {
                                status = 1;
                            }
                            else
                            {
                                status = 2;
                            }
                            reader.Close();
                            if (status == 2)
                            {
                                MySqlDataReader reader1 = command1.ExecuteReader();
                                reader1.Read();
                                reader1.Close();
                            }
                            else
                            {
                                MySqlDataReader reader2 = command2.ExecuteReader();
                                reader2.Read();
                                reader2.Close();
                            }
                            connection.Close();
                            Connection();

                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                            connection.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please check your internet connection and try again");
                }
            }
            else
            {
                product_grid.DataSource = Source();
            }
        }

        private void CheckStatus()
        {
            if (Internet.CheckInternet() != false)
            {
                string commandstring = @"SELECT item_name,item_size FROM tbl_inventory WHERE item_name = ?name AND item_size = ?size AND item_quantity <> 0 ";
                MySqlCommand command = new MySqlCommand(commandstring, connection);
                command.Parameters.AddWithValue("?name", prod_desc.Text);
                command.Parameters.AddWithValue("?size", size.SelectedItem.ToString());
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        status = 1;
                    }
                    else
                    {
                        status = 2;
                    }
                    reader.Close();
                    connection.Close();
                    insert_product();
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

        private void insert_product()
        {
            if (Internet.CheckInternet() != false)
            {
                string Command = @"INSERT INTO tbl_product(product_desc,product_size,product_price,date_added,Status)VALUE(?name,?size,?price,?date,?status)";
                MySqlCommand command = new MySqlCommand(Command, connection);

                command.Parameters.Add(new MySqlParameter("?name", MySqlDbType.VarChar)).Value = prod_desc.Text;
                command.Parameters.Add(new MySqlParameter("?size", MySqlDbType.VarChar)).Value =  size.SelectedItem.ToString();
                command.Parameters.Add(new MySqlParameter("?price", MySqlDbType.Double)).Value = Convert.ToDouble(prod_price.Text);
                command.Parameters.Add(new MySqlParameter("?date", MySqlDbType.Date)).Value = DateTime.Now;
                command.Parameters.Add(new MySqlParameter("?status", MySqlDbType.Int16)).Value =  status;

                try
                {
                    connection.Open(); 
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    reader.Close();
                    connection.Close();
                    insertforeigntovalue();
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

        private void insertforeigntovalue()
        {
            if (Internet.CheckInternet() != false)
            {
                string Command1 = @"UPDATE tbl_inventory SET product_id_fk = (SELECT product_id FROM tbl_product WHERE product_id = LAST_INSERT_ID()) WHERE product_id_fk is ?value AND item_name = ?name AND item_size = ?size";
                MySqlCommand command1 = new MySqlCommand(Command1, connection);
                command1.Parameters.AddWithValue("?id", prod_id.Text);
                command1.Parameters.AddWithValue("?value", null);
                command1.Parameters.AddWithValue("?name", prod_desc.Text);
                command1.Parameters.AddWithValue("?size", size.SelectedItem.ToString());
                try
                {
                    connection.Open() ;
                    MySqlDataReader reader = command1.ExecuteReader();
                    reader.Read();
                    reader.Close();
                    connection.Close();
                    admin_stock.instance.Connection();
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

            public void updateforeigntovalue()
            {
            if (Internet.CheckInternet() != false)
            {
                string Command1 = @"UPDATE tbl_inventory SET product_id_fk = ?id WHERE product_id_fk is ?value AND item_name = ?name AND item_size = ?size";
                MySqlCommand command1 = new MySqlCommand(Command1, connection);
                command1.Parameters.AddWithValue("?id", prod_id.Text);
                command1.Parameters.AddWithValue("?value", null);
                command1.Parameters.AddWithValue("?name", prod_desc.Text);
                command1.Parameters.AddWithValue("?size", size.SelectedItem.ToString());
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
        }

        public void updateforeigntonull()
        {
            if (Internet.CheckInternet() != false)
            {
                string Command1 = @"UPDATE tbl_inventory SET product_id_fk = ?value WHERE product_id_fk = ?id AND item_name = ?name AND item_size = ?size";
                MySqlCommand command1 = new MySqlCommand(Command1, connection);
                command1.Parameters.AddWithValue("?id", prod_id.Text);
                command1.Parameters.AddWithValue("?value", null);
                command1.Parameters.AddWithValue("?name", product_grid.Rows[rowclick].Cells[1].Value.ToString());
                command1.Parameters.AddWithValue("?size", product_grid.Rows[rowclick].Cells[2].Value.ToString());

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
                updateforeigntovalue();
                updateforeigntonull();
                int price = 0;
                string Command = @"UPDATE tbl_product SET product_desc = ?name, product_size = ?size, product_price = ?price WHERE product_id = ?id";
                MySqlCommand command = new MySqlCommand(Command, connection);
                int.TryParse(prod_price.Text, out price);
                command.Parameters.AddWithValue("?id", prod_id.Text);
                command.Parameters.AddWithValue("?name", prod_desc.Text);
                command.Parameters.AddWithValue("?size", size.SelectedItem);
                command.Parameters.AddWithValue("?price", price);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    reader.Close();
                    connection.Close();
                    admin_stock.instance.Connection();
                    CheckStatus_OnLoad();
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
            updateforeigntonull();
            if (Internet.CheckInternet() != false)
            {
                string Command = @"DELETE FROM tbl_product WHERE product_id = ?id OR product_desc = ?name AND product_size = ?size AND product_price = ?price";
                MySqlCommand command = new MySqlCommand(Command, connection);

                command.Parameters.AddWithValue("?id", prod_id.Text);
                command.Parameters.AddWithValue("?name", prod_desc.Text);
                command.Parameters.AddWithValue("?size", size.Text);
                command.Parameters.AddWithValue("?price", prod_price.Text);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    reader.Close();
                    connection.Close();
                    admin_stock.instance.Connection();
                    
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
        private void insert_btn_Click(object sender, EventArgs e)
        {
            check_empty();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            CheckStatus_OnLoad();
        }

        private void product_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (product_grid.Rows.Count != 0)
            {
                try
                {
                    index = e.RowIndex;
                    DataGridViewRow row = product_grid.Rows[index];

                    prod_id.Text = row.Cells[0].Value.ToString();
                    prod_desc.Text = row.Cells[1].Value.ToString();
                    size.SelectedItem = row.Cells[2].Value.ToString();
                    prod_price.Text = row.Cells[3].Value.ToString();

                    rowclick = index;
                }
                catch
                {

                }
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            prod_desc.Text = prod_desc.Text.ToLower();
            if (prod_desc.Text.Equals(product_grid.Columns[1]))
            {

            }
            if (prod_desc.Text == string.Format(""))
            {
                MessageBox.Show("product name required");
                prod_desc.Focus();
            }
            else if (prod_price.Text == string.Format(""))
            {
                MessageBox.Show("product price required");
                prod_price.Focus();
            }
            else
            {
                actionclick = "update";
                CheckProductExist();
                product_grid.DataSource = Source();
                prod_id.Text = string.Format("");
                prod_desc.Text = string.Format("");
                size.SelectedIndex = 0;
                prod_price.Text = string.Format("");
            }
        }

        private void prod_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            prod_desc.Text = prod_desc.Text.ToLower();
            if (prod_desc.Text == string.Format(""))
            {
                MessageBox.Show("product name required");
                prod_desc.Focus();
            }
            else if (prod_price.Text == string.Format(""))
            {
                MessageBox.Show("product price required");
                prod_price.Focus();
            }
            else
            {
                delete_product();
                product_grid.DataSource = Source();
                prod_id.Text = string.Format("");
                prod_desc.Text = string.Format("");
                size.SelectedIndex = 0;
                prod_price.Text = string.Format("");
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            prod_id.Text = string.Format("Selected Product ID:");
            prod_desc.Text = string.Format("");
            size.SelectedIndex = 0;
            prod_price.Text = string.Format("");
        }

        private void search_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                DataView view = data.DefaultView;
                view.RowFilter = string.Format("Convert(Product_ID, 'System.String') like '%{0}%' or Description like '%{0}%' or Size like '%{0}%' or Convert(Price, 'System.String') like '%{0}%' or Status like '%{0}%'", search_txt.Text);
                product_grid.DataSource = view.ToTable();
            }
            catch (Exception)
            {

            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            if (search_txt.Text == string.Format(""))
            {
                Connection();
            }
        }

        private void admin_supplier_Load(object sender, EventArgs e)
        {
            product_grid.DataSource = Source();
            CheckStatus_OnLoad();
            size.SelectedIndex = 0;
        }

        private void product_grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            product_grid.ClearSelection();
            Style();
        }

        private void product_grid_MouseLeave(object sender, EventArgs e)
        {
            product_grid.ClearSelection();
        }
    }
}
