using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Resources.ResXFileRef;

namespace Sales_and_Inventory_System
{
    public partial class Add_item : Form
    {
        public static Add_item instance;
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public MySqlConnection connection = new MySqlConnection(ConnectionString);
        public Add_item(product_management_control manage)
        {
            InitializeComponent();
            instance = this;
        }
        private void Add_item_Load(object sender, EventArgs e)
        {
            desc.SelectedIndex = 0;
            size.SelectedIndex = 0;
            getproduct_info();
        }
        private void Exit_panel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkEmpty()
        {
            int check = 0;
            int.TryParse(item_quantity.Text, out check);

             if (desc.Text.Equals("Description"))
            {
                MessageBox.Show("Description of the item is required");
            }
            else if (item_quantity.Text.Equals(null))
            {
                MessageBox.Show("Quantity of the item is required");
                item_quantity.Focus();
            }
            else if (check.Equals(0))
            {
                MessageBox.Show("Quantity of the item cannot be zero");
                item_quantity.Focus();
            }
            else
            {
                UpdateStatus();
                Close();
            }
        }

        private void UpdateStatus()
        {
            if (Internet.CheckInternet() != false)
            {
                string commandString = @"UPDATE tbl_product SET Status = ?status WHERE product_desc = ?desc AND product_size = ?size AND Status = 2 OR status = 3 ";
                MySqlCommand command = new MySqlCommand(commandString, connection);

                command.Parameters.AddWithValue("?desc", desc.SelectedItem.ToString());
                command.Parameters.AddWithValue("?size", size.SelectedItem.ToString());
                command.Parameters.AddWithValue("?status", 1);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    reader.Close();
                    Insert_Item();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
        }

        private void Insert_Item()
        {
            if (Internet.CheckInternet() != false)
            {
                string Command = @"INSERT INTO tbl_inventory(product_id_fk,item_name,item_size,item_quantity,item_expiration) VALUES ((SELECT product_id FROM tbl_product WHERE product_desc = @name AND product_size = @size),@name,@size,@quantity,date_add(now(),INTERVAL 14 DAY))";
                MySqlCommand command = new MySqlCommand(Command, connection);

                command.Parameters.AddWithValue("@name", desc.Text);
                command.Parameters.AddWithValue("@size", size.Text);
                command.Parameters.AddWithValue("@quantity", item_quantity.Text);

                command.CommandTimeout = 60;

                try
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    reader.Close();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
                Insert();
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
                        desc.Items.Clear();
                        while (reader1.Read())
                        {
                            desc.Items.Add(reader1.GetString(0));
                        }
                    }
                    reader1.Close();
                    connection.Close();
                    desc.SelectedIndex= 0;
                   
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

        private void getproduct_size()
        {
            if (Internet.CheckInternet() != false)
            {
                string Command = @"SELECT DISTINCT product_size FROM tbl_product WHERE product_desc = ?description";
                MySqlCommand command = new MySqlCommand(Command, connection);
                command.Parameters.AddWithValue("?description", desc.SelectedItem.ToString());

                try
                {
                    connection.Open();
                    MySqlDataReader reader1 = command.ExecuteReader();

                    if (reader1.HasRows)
                    {
                        size.Items.Clear();
                        while (reader1.Read())
                        {
                            size.Items.Add(reader1.GetString(0));
                        }
                    }
                    reader1.Close();
                    connection.Close();
                    size.SelectedIndex = 0;
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

        private void Signin_btn_Click(object sender, EventArgs e)
        {
            checkEmpty();
        }

        private void item_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Insert()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
            supplier.instance.CheckStatus_OnLoad();
        }

        private void product_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Numbers only");
            }
        }

        private void desc_SelectedIndexChanged(object sender, EventArgs e)
        {
            getproduct_size();
        }

        private void item_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    UpdateStatus();
                    break;
            }
        }
    }
}
