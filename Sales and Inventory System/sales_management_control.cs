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
using System.Security.Cryptography;
using static System.Resources.ResXFileRef;
using System.Collections;
using System.Threading;
using System.Configuration;

namespace Sales_and_Inventory_System
{
    public partial class sales_management_control : UserControl
    {
        private static List<string> code = new List<string>();
        private static List<int> stock = new List<int>();

        private static List<int> number = new List<int>();
        private static List<int> total = new List<int>();
        int index = 0;
        int transaction = 1;
        public static sales_management_control instance;
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public MySqlConnection connection = new MySqlConnection(ConnectionString);

        public sales_management_control()
        {
            InitializeComponent();
            instance = this;
        }

        private void sales_management_control_Load(object sender, EventArgs e)
        {
            getproduct_info();
            prod_desc.SelectedIndex = 0;
            prod_size.SelectedIndex = 0;
            regular_btn.Checked = true;
            time.Start();
            transaction_number.Text = transaction.ToString();
        }

        private void cust_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cust_money_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    check_empty();
                    break;
            }
        }

        private void availability()
        {
            if (Internet.CheckInternet() != false)
            {
                code.Clear();
                stock.Clear();
                string Command1 = @"SELECT item_code,item_quantity FROM tbl_inventory WHERE product_id_fk = ?id AND item_quantity <> 0";
                MySqlCommand command1 = new MySqlCommand(Command1, connection);

                command1.Parameters.Add(new MySqlParameter("?id",MySqlDbType.Int32)).Value = int.Parse(id.Text);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command1.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            code.Add(reader.GetString(0));
                            stock.Add(int.Parse(reader.GetString(1)));
                        }
                    }
                    else
                    {
                        MessageBox.Show("the specific item for the product is out of stock\nsystem will update the stock information and try to\nfind available item for the product you need\n\n\nor the product information \nis not equal to the stock item information\ncheck the product information and modify specific product if needed\n\n\nif the stock item is the problem then contact the admin\nand explain the situation ");
                    }
                    reader.Close();
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

        private void delete_empty()
        {
            if (Internet.CheckInternet() != false)
            {
                string Command = "DELETE FROM tbl_inventory WHERE item_quantity = 0";
                MySqlCommand command = new MySqlCommand(Command, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Close();
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

        public void getproduct_info()
        {
            if (Internet.CheckInternet() != false)
            {
                string Command = @"SELECT DISTINCT product_desc FROM tbl_product";
                MySqlCommand command = new MySqlCommand(Command, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader1 = command.ExecuteReader();

                    if (reader1.HasRows)
                    {
                        prod_desc.Items.Clear();

                        while (reader1.Read())
                        {
                            prod_desc.Items.Add(reader1.GetString(0));
                        }
                    }
                    else
                    {
                        prod_desc.Items.Clear();
                        prod_desc.Items.Add("Description");
                    }
                    reader1.Close();
                    connection.Close();
                    prod_desc.SelectedIndex = 0;
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

        public void getproduct_size()
        {
            if (Internet.CheckInternet() != false)
            {
                string Command = @"SELECT DISTINCT product_size FROM tbl_product WHERE product_desc = ?description";
                MySqlCommand command = new MySqlCommand(Command, connection);
                command.Parameters.AddWithValue("?description", prod_desc.SelectedItem.ToString());

                try
                {
                    connection.Open();
                    MySqlDataReader reader1 = command.ExecuteReader();

                    if (reader1.HasRows)
                    {
                        prod_size.Items.Clear();
                        while (reader1.Read())
                        {
                            prod_size.Items.Add(reader1.GetString(0));
                        }
                    }
                    else
                    {
                        prod_size.Items.Clear();
                        prod_size.Items.Add("Size");
                    }
                    reader1.Close();
                    connection.Close();
                    prod_size.SelectedIndex = 0;
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

        private void getproduct_id()
        {
            if (Internet.CheckInternet() != false)
            {
                string Command = @"SELECT product_id FROM tbl_product WHERE product_desc = ?description AND product_size = ?size";
                MySqlCommand command = new MySqlCommand(Command, connection);
                command.Parameters.AddWithValue("?description", prod_desc.SelectedItem.ToString());
                command.Parameters.AddWithValue("?size", prod_size.SelectedItem.ToString());

                try
                {
                    MySqlDataReader reader1 = command.ExecuteReader();

                    if (reader1.HasRows)
                    {
                        while (reader1.Read())
                        {
                            id.Text = reader1.GetString(0);
                        }
                    }
                    else
                    {
                        id.Text = string.Format("Selected Product ID:");
                    }
                    reader1.Close();
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

        private void getproduct_price()
        {
            if (Internet.CheckInternet() != false)
            {
                string Command = @"SELECT DISTINCT product_price FROM tbl_product WHERE product_desc = ?description AND product_size = ?size";
                MySqlCommand command = new MySqlCommand(Command, connection);
                command.Parameters.AddWithValue("?description", prod_desc.SelectedItem.ToString());
                command.Parameters.AddWithValue("?size", prod_size.SelectedItem.ToString());

                try
                {
                    connection.Open();
                    MySqlDataReader reader1 = command.ExecuteReader();

                    if (reader1.HasRows)
                    {
                        while (reader1.Read())
                        {
                            prod_price.Text = reader1.GetString(0);
                        }
                    }
                    else
                    {
                        prod_price.Text = string.Format("Product Price");
                    }
                    reader1.Close();
                    getproduct_id();
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

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            check_empty();   
        }

        private void check_empty()
        {

            if (prod_desc.SelectedItem.ToString().Equals("Description"))
            {
                MessageBox.Show("Product list empty, Insert product in the product list first","info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (prod_size.SelectedItem.ToString().Equals("Size"))
            {
                MessageBox.Show("Product list empty, Insert product in the product list first", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (prod_quantity.Text.Equals(""))
            {
                MessageBox.Show("product quantity is required","info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                prod_quantity.Focus();
            }
            else if (prod_quantity.Text.Equals("0"))
            {
                MessageBox.Show("product quantity cannot be zero", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                prod_quantity.Text = string.Format("");
                prod_quantity.Focus();
            }
            else
            {
                if (record_grid.Rows.Count != 0)
                {
                    availability();
                    if (stock.Count != 0 && code.Count != 0)
                    {
                        int total_order = 0;
                        for (int i = 0; i < record_grid.Rows.Count; i++)
                        {
                            if (id.Text.Equals(record_grid.Rows[i].Cells[0].Value))
                            {
                                try
                                {
                                    total_order = total_order + int.Parse(record_grid.Rows[i].Cells[3].Value.ToString());
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }
                        }
                        int sum = 0;
                        try
                        {
                            sum = total_order + int.Parse(prod_quantity.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("only number is allowed in quantity");
                        }
                        Console.WriteLine(sum.ToString());
                        if (sum > stock.Sum())
                        {
                            MessageBox.Show("order exceeded the stock item", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            prod_quantity.Text = string.Format("");
                        }
                        else
                        {
                            int count = 0;
                            record_grid.Focus();
                            for (int i = 0; i < record_grid.Rows.Count; i++)
                            {
                                index = index + i;
                            }
                            for (int i = 0; i < record_grid.Rows.Count; i++)
                            {
                                if (id.Text.Equals(record_grid.Rows[i].Cells[0].Value))
                                {
                                    count = 0;
                                    DataGridViewRow data = record_grid.Rows[i];
                                    data.Cells[3].Value = Convert.ToInt32(prod_quantity.Text) + Convert.ToInt32(record_grid.Rows[i].Cells[3].Value);
                                    data.Cells[5].Value = Convert.ToInt32(tot_price.Text) + Convert.ToInt32(record_grid.Rows[i].Cells[5].Value);
                                    if (senior_btn.Enabled == false)
                                    {
                                        senior_discount();
                                    }
                                    calGrid();
                                    clearinput();
                                    break;
                                }
                                else
                                {
                                    count = 1;
                                }
                            }

                            if (count == 1)
                            {
                                record_grid.Rows.Add(id.Text, prod_desc.SelectedItem, prod_size.SelectedItem, prod_quantity.Text, prod_price.Text, tot_price.Text);
                                clearinput();
                                prod_quantity.Focus();
                                record_grid.ClearSelection();
                                if (senior_btn.Enabled == false)
                                {
                                    senior_discount();
                                }
                                calGrid();
                                count = 0;
                            }
                        }
                    }
                    else
                    {
                        clearinput();
                    }
                }
                else
                {
                    availability();
                    int converters;
                    int.TryParse(prod_quantity.Text, out converters);

                    if (stock.Count != 0 && code.Count != 0)
                    {
                        if (converters > stock.Sum())
                        {
                            MessageBox.Show("order exceeded the stock item", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            prod_quantity.Text = string.Format("");
                        }
                        else
                        {
                            record_grid.Rows.Add(id.Text, prod_desc.SelectedItem.ToString(), prod_size.SelectedItem.ToString(), prod_quantity.Text, prod_price.Text, tot_price.Text);
                            record_grid.Focus();
                            clearinput();
                            prod_quantity.Focus();
                            record_grid.ClearSelection();
                            code.Clear();
                            stock.Clear();
                            if (senior_btn.Enabled == false)
                            {
                                senior_discount();
                            }
                        }
                    }
                    else
                    {
                        clearinput();
                    }
                }
            }
        }

        private void check_empty1()
        {
            int check = 0;
            int.TryParse(prod_quantity.Text, out check);
            if (record_grid.Rows.Count.Equals(0)) 
            {
                MessageBox.Show("Insert Order First");
            }
            else if (prod_desc.SelectedItem.ToString().Equals("Description"))
            {
                MessageBox.Show("Product Description is required");
            }
            else if (prod_size.SelectedItem.ToString().Equals("Size"))
            {
                MessageBox.Show("Product Size is required");
            }
            else if (prod_quantity.Text == string.Format(""))
            {
                MessageBox.Show("product quantity is required");
                prod_quantity.Focus();
            }
            else if (check == 0)
            {
                MessageBox.Show("product quantity cannot be zero");
                prod_quantity.Focus();
            }
            else
            {
                availability();
                int converters;
                int.TryParse(prod_quantity.Text, out converters);

                if (stock.Count != 0 && code.Count != 0)
                {
                    if (converters > stock.Sum())
                    {
                        MessageBox.Show("order exceeded the stock item");
                        prod_quantity.Text = string.Format("");
                    }
                    else
                    {
                        DataGridViewRow data = record_grid.Rows[index];
                        data.Cells[0].Value = id.Text;
                        data.Cells[1].Value = prod_desc.SelectedItem.ToString();
                        data.Cells[2].Value = prod_size.SelectedItem.ToString();
                        data.Cells[3].Value = prod_quantity.Text;
                        data.Cells[4].Value = prod_price.Text;
                        data.Cells[5].Value = tot_price.Text;
                        clearinput();
                        calGrid();
                        code.Clear();
                        stock.Clear();
                        if (senior_btn.Enabled == false)
                        {
                            senior_discount();
                        }
                    }
                }
                else
                {
                    clearinput();
                }
            }
        }

        private void Value_Change()
        {
            int converter = 0;
            int converter1 = 0;
            double totalprice = 0;
            Int32.TryParse(prod_price.Text, out converter);
            Int32.TryParse(prod_quantity.Text, out converter1);

            totalprice = (double)converter * converter1;

            tot_price.Text = totalprice.ToString();
        }

        private void prod_quantity_OnValueChanged(object sender, EventArgs e)
        {
            Value_Change();
        }

        static string yes = "", off = "";
        double[] storage = new double[100];
        double store = 0;

        private void calGrid()
        {
            double calculate = 0;
            if (record_grid.Rows.Count != 0)
            {
                for (int i = 0; i < record_grid.Rows.Count; i++)
                {
                    try
                    {
                        calculate = calculate + double.Parse(record_grid.Rows[i].Cells[5].Value.ToString());
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    order_total.Text = calculate.ToString();
                    store = calculate;
                    if (senior_btn.Enabled == false)
                    {
                        senior_discount();
                    }
                }
            }
            else
            {
                order_total.Text = string.Format("");
            }
            
        }

        private void cust_money_OnValueChanged(object sender, EventArgs e)
        {
            if (record_grid.Rows.Count != 0)
            {
                if (cust_money.Text != string.Format(""))
                {
                    double totalprice, converter, calculate;
                    double.TryParse(order_total.Text, out converter);
                    double.TryParse(cust_money.Text, out calculate);

                    totalprice = calculate - converter;

                    cust_change.Text = totalprice.ToString();
                }
                else
                {
                    cust_change.Text = string.Format("");
                }
            }
        }

        private void senior_discount()
        {
            double sum;
            double order_price = 0;
            double totals;
            for (int i = 0; i < record_grid.Rows.Count; i++)
            {
                try
                {
                    double calculate = 0;
                    double total = 0;
                    double senior_discount = 0;
                    calculate = double.Parse(record_grid.Rows[i].Cells[5].Value.ToString());
                    senior_discount = calculate * 0.2;
                    storage[i] = senior_discount;
                    total = calculate - senior_discount;
                    order_price += calculate;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            sum = storage.Sum();
            totals = order_price - sum;
            order_total.Text = totals.ToString();
            store = double.Parse(order_total.Text);
            label3.Visible = true;
            discount.Visible = true;
            cust_money.Text = string.Format("");
            cust_change.Text = string.Format("");
            yes = "Yes";
            off = "20%";
        }

        private void regularcustomer()
        {
            double calculate = 0;
            for (int i = 0; i < record_grid.Rows.Count; i++)
            {
                try
                {
                    double revert = storage[i];
                    double total = 0;
                    calculate = calculate + double.Parse(record_grid.Rows[i].Cells[5].Value.ToString());
                    total = revert + calculate;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                order_total.Text = calculate.ToString();
                store = calculate;
            }
            record_grid.Focus();
            label3.Visible = false;
            discount.Visible = false;
            cust_money.Text = string.Format("");
            cust_change.Text = string.Format("");
        }

        private void senior_btn_Click(object sender, EventArgs e)
        {
            senior_btn.Enabled = false;
            regular_btn.Enabled = true;
            senior_discount();
        }

        private void regular_btn_Click(object sender, EventArgs e)
        {
            senior_btn.Enabled = true;
            regular_btn.Enabled = false;
            regularcustomer();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clearinput();
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (record_grid.Rows.Count != 0)
            {
                index = record_grid.CurrentCell.RowIndex;
                record_grid.Rows.RemoveAt(index);

                //code.RemoveAt(index);
                
                for (int i = 0; i <= index; i++)
                {
                    storage[index] = 0;
                }

                if (record_grid.Rows.Count == 0)
                {
                    for (int i = 0; i < storage.Length; i++)
                    {
                        storage[i] = 0;
                    }
                }
                clearinput();
            }
            else
            {
                MessageBox.Show("Insert order first");
            }

            if (record_grid.Rows.Count == 0)
            {
                order_total.Text = string.Format("");
                cust_money.Text = string.Format("");
                cust_change.Text = string.Format("");
            }

            if (senior_btn.Enabled == false)
            {
                senior_discount();
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            check_empty1();
        }

        private void record_grid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (record_grid.Rows.Count != 0)
            {
                try
                {
                    index = e.RowIndex;
                    DataGridViewRow row = record_grid.Rows[index];
                    id.Text = row.Cells[0].Value.ToString();
                    prod_desc.Text = row.Cells[1].Value.ToString();
                    size.Text = row.Cells[2].Value.ToString();
                    prod_quantity.Text = row.Cells[3].Value.ToString();
                    prod_price.Text = row.Cells[4].Value.ToString();
                    tot_price.Text = row.Cells[5].Value.ToString();
                    prod_quantity.Enabled = true;
                }
                catch (Exception)
                {

                }
            }
        }

        private void clearinput()
        {
            prod_desc.SelectedIndex = 0;
            prod_size.SelectedIndex = 0;
            prod_quantity.Text = string.Format("");
            tot_price.Text = string.Format("0");
            record_grid.ClearSelection();
        }

        private void save()
        {
            if (record_grid.Rows.Count != 0)
            {
                if (cust_money.Text == string.Format(""))
                {
                    MessageBox.Show("Customer Money Required");
                    cust_money.Focus();
                }
                else
                {
                    double money = 0;
                    double.TryParse(cust_money.Text, out money);
                    if (store > money)
                    {
                        MessageBox.Show("Please provide exact amount or more");
                    }
                    else
                    {
                        CheckAvailability();
                        order_total.Text = string.Format("");
                    }
                }
            }
            else
            {
                MessageBox.Show("Insert order first");
            }
        }
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            save();
        }

        private int iterate = 0;
        private void CheckAvailability()
        {
            if (Internet.CheckInternet() != false)
            {
                for (int i = 0; i < record_grid.Rows.Count; i++)
                {
                    iterate = i;
                    code.Clear();
                    stock.Clear();
                    string Command1 = @"SELECT item_code,item_quantity FROM tbl_inventory WHERE product_id_fk = ?id AND item_quantity <> 0";
                    MySqlCommand command1 = new MySqlCommand(Command1, connection);
                    command1.Parameters.Add(new MySqlParameter("id", MySqlDbType.Int32)).Value = Convert.ToInt32(record_grid.Rows[i].Cells[0].Value);

                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = command1.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                code.Add(reader.GetString(0));
                                stock.Add(Convert.ToInt32(reader.GetString(1)));
                            }
                        }
                        else
                        {
                            MessageBox.Show("the specific item for the product is out of stock\nsystem will update the stock information and try to\nfind available item for the product you need\n\n\nor the product information \nis not equal to the stock item information\ncheck the product information and modify specific product if needed\n\n\nif the stock item is the problem then contact the admin\nand explain the situation ");
                        }
                        reader.Close();
                        connection.Close();
                        int orders_quantity = Convert.ToInt32(record_grid.Rows[i].Cells[3].Value);
                        int deduct, count = 0;
                        if (orders_quantity >= stock.Sum())
                        {
                            Set2Zero();
                        }
                        else
                        {
                            for (int x = 0; x < stock.Count; x++)
                            {
                                if (orders_quantity >= stock[x])
                                {
                                    orders_quantity = orders_quantity - stock[x];
                                    stock[x] = 0;
                                }
                                else if (orders_quantity < stock[x])
                                {
                                    deduct = stock[x] - orders_quantity;
                                    stock[x] = deduct;
                                    orders_quantity = 0;
                                    count = 1;
                                }
                            }
                            if (count == 1)
                            {
                                deduct_sale();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        connection.Close();
                    }
                }
                order_total.Text = string.Format(""); 
                record_grid.Rows.Clear();
                iterate = 0;
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
        }

        private void Set2Zero()
        {
            for (int i = 0; i < code.Count; i++)
            {
                string commandString = @"UPDATE tbl_inventory SET item_quantity = " + 0 + " WHERE item_code = ?code";
                MySqlCommand command = new MySqlCommand(commandString, connection);
                command.Parameters.Add(new MySqlParameter("?code", MySqlDbType.Int32)).Value = Convert.ToInt32(code[i]);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    reader.Close();
                    connection.Close();
                    insert_order();
                    delete_empty();
                    product_management_control.instance.Connection();
                    supplier.instance.CheckStatus_OnLoad();
                    transaction_history.instance.Connection();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    connection.Close();
                }
            }
        }

        private void deduct_sale()
        {
            for (int i = 0; i < code.Count; i++)
            {
                string commandstring = @"UPDATE tbl_inventory SET item_quantity = ?quantity WHERE item_code = ?code";
                MySqlCommand command = new MySqlCommand(commandstring, connection);

                command.Parameters.Add(new MySqlParameter("?code", MySqlDbType.Int32)).Value = Convert.ToInt32(code[i]);
                command.Parameters.Add(new MySqlParameter("?quantity", MySqlDbType.Int32)).Value = stock[i];

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    reader.Close();
                    connection.Close();
                    insert_order();
                    delete_empty();
                    product_management_control.instance.Connection();
                    supplier.instance.Connection();
                    transaction_history.instance.Connection();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    connection.Close();
                }
            }
        }

        private void insert_order()
        {
            if (Internet.CheckInternet() != false)
            {
                 double total;
                double.TryParse(record_grid.Rows[iterate].Cells[5].Value.ToString(), out total);

                string Command = @"INSERT INTO tbl_sales(product_id_fk,quantity,senior,discount,total_price,date_purchase)VALUES(@id,@quantity,@senior,@discount,@total,?date)";
                MySqlCommand command = new MySqlCommand(Command, connection);

                command.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32)).Value = Convert.ToInt32(record_grid.Rows[iterate].Cells[0].Value);
                command.Parameters.Add(new MySqlParameter("@quantity", MySqlDbType.Int32)).Value = Convert.ToInt32(record_grid.Rows[iterate].Cells[3].Value);
                command.Parameters.Add(new MySqlParameter("?date",MySqlDbType.Date)).Value = DateTime.Now;

                if (senior_btn.Checked == true)
                {
                    command.Parameters.Add(new MySqlParameter("@senior", MySqlDbType.Text)).Value = yes;
                    command.Parameters.Add(new MySqlParameter("@discount", MySqlDbType.Text)).Value = off;
                    total = total - (total * 0.2);
                    command.Parameters.Add(new MySqlParameter("@total", MySqlDbType.Double)).Value = Convert.ToDouble(total);
                }
                else if (regular_btn.Checked == true)
                {
                    command.Parameters.Add(new MySqlParameter("@senior", MySqlDbType.Text)).Value = "No";
                    command.Parameters.Add(new MySqlParameter("@discount", MySqlDbType.Text)).Value = "0%";
                    command.Parameters.Add(new MySqlParameter("@total", MySqlDbType.Double)).Value = Convert.ToInt32(record_grid.Rows[iterate].Cells[5].Value);
                }


                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    reader.Close();
                    connection.Close();
                    clearinput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }

                for (int i = 0; i < storage.Length; i++)
                {
                    storage[i] = 0;
                }
                transaction += 1;
                store = 0;
                cust_money.Text = string.Format("");
                cust_change.Text = string.Format("");
                transaction_number.Text = transaction.ToString();
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
        }

        private void update_item()
        {
            if (Internet.CheckInternet() != false)
            {
                for (int i = 0; i < record_grid.Rows.Count; i++)
                {
                    int calculate = int.Parse(record_grid.Rows[i].Cells[3].Value.ToString());
                    total[i] = number[i] - calculate;
                }
                connection.Open();
                string Command = @"UPDATE valenzuela_inventory SET item_quantity = @minus WHERE item_code = ?code";
                for (int i = 0; i < record_grid.Rows.Count; i++)
                {



                    MySqlCommand command = new MySqlCommand(Command, connection);
                    command.Parameters.AddWithValue("@minus", total[i]);
                    command.Parameters.AddWithValue("?code", code[i]);

                    try
                    {

                        MySqlDataReader reader1 = command.ExecuteReader();
                        reader1.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        connection.Close();
                    }
                }
                connection.Close();
                number.Clear();
                total.Clear();
                code.Clear();
                record_grid.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
            
        }

        private void select_item()
        {
            if (Internet.CheckInternet() != false)
            {
                connection.Open();
                for (int i = 0; i < record_grid.Rows.Count; i++)
                {
                    string Command = @"SELECT item_quantity FROM valenzuela_inventory WHERE item_code = ?code";
                    MySqlCommand command = new MySqlCommand(Command, connection);

                    command.Parameters.AddWithValue("?code", code[i]);

                    try
                    {

                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            number[i] = int.Parse(reader.GetValue(0).ToString());
                        }
                        reader.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        connection.Close();
                    }

                }
                connection.Close();
                update_item();

            }
        }

        private void cust_money_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    save();
                    break;
            }
        }

        private void prod_desc_SelectedIndexChanged(object sender, EventArgs e)
        {
            getproduct_size();
        }

        private void prod_size_SelectedIndexChanged(object sender, EventArgs e)
        {
           getproduct_price();
        }

        private void prod_desc_Click(object sender, EventArgs e)
        {
            record_grid.ClearSelection();
        }

        private void prod_size_Click(object sender, EventArgs e)
        {
            record_grid.ClearSelection();
        }

        private void prod_quantity_Click(object sender, EventArgs e)
        {
            record_grid.ClearSelection();
        }

        private void record_grid_MouseLeave(object sender, EventArgs e)
        {
            record_grid.ClearSelection();
        }

        private void record_grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            calGrid();
        }

        private void record_grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calGrid();
        }

        private void prod_price_TextChanged(object sender, EventArgs e)
        {
            Value_Change();
        }

        private void time_Tick(object sender, EventArgs e)
        {
            current_date.Text = DateTime.Now.ToString();
        }
    }
}
