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
using System.Threading;
using System.Configuration;

namespace Sales_and_Inventory_System
{
    public partial class product_management_control : UserControl
    {
        private DataTable data = new DataTable();
        private DataSet ds = new DataSet();
        private DataTable data1 = new DataTable();
        private DataSet ds1 = new DataSet();
        public static product_management_control instance;
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public MySqlConnection connection = new MySqlConnection(ConnectionString);

        public product_management_control()
        {
            InitializeComponent();
            instance= this;
        }

        private void product_management_control_Load(object sender, EventArgs e)
        {
            inventory_item.DataSource = Source();
            migrate_data();
        }
        private void migrate_data()
        {
            if (Internet.CheckInternet() != false)
            {
                string Command = @"INSERT INTO expired_item(expired_code,expired_name,expired_size,expired_quantity,date_expired) SELECT item_code,item_name,item_size,item_quantity,item_expiration FROM tbl_inventory WHERE item_expiration < CURRENT_DATE";                 
                MySqlCommand command = new MySqlCommand(Command, connection);
                try
                {
                    connection.Open();
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
                delete_expired();
            }
            else
            {
                MessageBox.Show("Please check your internet connection and try again");
            }
           
        }

        private void delete_expired()
        {
            if (Internet.CheckInternet() != false)
            {
                string Command = @"DELETE FROM tbl_inventory WHERE item_expiration < CURRENT_DATE";
                MySqlCommand command = new MySqlCommand(Command, connection);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Close();
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
            Thread.Sleep(1000);
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

        private void insert_btn_Click_1(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Add_item"] as Add_item) != null)
            {
                MessageBox.Show("window already open");

            }
            else
            {
                Add_item add = new Add_item(this);
                add.UpdateEventHandler += form2_UpdateEventHandler1;
                add.Show();
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

        public void form2_UpdateEventHandler1(object sender, Add_item.UpdateEventArgs args)
        {
            inventory_item.DataSource = Source();
            Connection();
        }

        private void search_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (click == true)
            {
                try
                {
                    DataView view = data1.DefaultView;
                    view.RowFilter = string.Format("Convert(Expired_ID, 'System.String') like '%{0}%' or Description like '%{0}%' or Size like '%{0}%'", search_txt.Text);
                    inventory_item.DataSource = view.ToTable();
                }
                catch (Exception)
                {

                }
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

        private void show_all_Click(object sender, EventArgs e)
        {
            click = false;
            inventory_item.DataSource = Source();
            search_txt.Text = string.Format("");
            show_all.Enabled = false;
            expired_btn.Enabled = true;
        }

        private bool click = false;
        private void expired_btn_Click(object sender, EventArgs e)
        {
            click = true;
            inventory_item.DataSource = Source1();
            search_txt.Text = string.Format("");
            show_all.Enabled = true;
            expired_btn.Enabled = false;
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            if (search_txt.Text == string.Format(""))
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

        private void inventory_item_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            inventory_item.ClearSelection();
        }

        private void inventory_item_MouseLeave(object sender, EventArgs e)
        {
            inventory_item.ClearSelection();
        }
    }
}
