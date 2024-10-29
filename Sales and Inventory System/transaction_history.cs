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
    // to be continued, account management, login history, sold out item;
    public partial class transaction_history : UserControl
    {
        public static transaction_history instance;
        private static string ConnectionString = "server = 127.0.0.1; port = 3306; username = root; password=toor; database = sales_inventory; integrated security = true;";
        public MySqlConnection connection = new MySqlConnection(ConnectionString);
        public transaction_history()
        {
            InitializeComponent();
            instance = this;
        }
        private void transaction_history_Load(object sender, EventArgs e)
        {
            timer.Start();
            transaction_grid.DataSource = Source();
            transaction_grid.Focus();
        }

        private DataTable data = new DataTable();
        private DataSet ds = new DataSet();

        public DataTable Source()
        {
            if (Internet.CheckInternet() != false)
            {
                string command = @" SELECT tbl_sales.transaction_id AS Transaction_ID,tbl_product.product_desc AS Description, tbl_product.product_size AS Size, tbl_product.product_price AS Price, tbl_sales.quantity AS Quantity, tbl_sales.senior AS Senior, tbl_sales.discount AS Discount, tbl_sales.total_price AS Total_Price, tbl_sales.date_purchase AS Date_Purchase FROM tbl_product RIGHT JOIN tbl_sales ON tbl_sales.product_id_fk = tbl_product.product_id WHERE tbl_sales.date_purchase = CURRENT_DATE ORDER BY tbl_sales.date_purchase DESC";
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
                    connection.Close();
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
                string Command = "SELECT tbl_sales.transaction_id AS Transaction_ID,tbl_product.product_desc AS Description, tbl_product.product_size AS Size, tbl_product.product_price AS Price, tbl_sales.quantity AS Quantity, tbl_sales.senior AS Senior, tbl_sales.discount AS Discount, tbl_sales.total_price AS Total_Price, tbl_sales.date_purchase AS Date_Purchase FROM tbl_product RIGHT JOIN tbl_sales ON tbl_sales.product_id_fk = tbl_product.product_id WHERE tbl_sales.date_purchase = CURRENT_DATE ORDER BY tbl_sales.date_purchase DESC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(Command, connection);

                try
                {
                    connection.Open();
                    DataSet data = new DataSet();
                    adapter.Fill(data);
                    transaction_grid.DataSource = data.Tables[0];
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

        private void timer_Tick(object sender, EventArgs e)
        {
            current_date.Text = DateTime.Now.ToString();
        }

        private void sum()
        {
            double converter = 0;
            try
            {
                for (int i = 0; i < transaction_grid.Rows.Count; i++)
                {
                    converter = converter + double.Parse(transaction_grid.Rows[i].Cells[7].Value.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            total_sales.Text = converter.ToString();
        }

        private void search_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (transaction_grid.Rows.Count != 0)
            {
                try
                {
                    DataView view = data.DefaultView;
                    view.RowFilter = string.Format("Convert(Transaction_ID,'System.String') like '{0}' or Description like '%{0}%' or Size like '%{0}%' or Convert(Price,'System.String') like '{0}' or Convert(Quantity,'System.String') like '{0}' or Senior like '%{0}%'", search_txt.Text);
                    transaction_grid.DataSource = view.ToTable();
                    sum();
                }
                catch (Exception)
                {
                }
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            Connection();
            transaction_grid.Focus();
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            if (search_txt.Text == string.Format(""))
            {
                Connection();
                sum();
            }
        }

        private void transaction_grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            transaction_grid.ClearSelection();
        }

        private void transaction_grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            sum();
        }

        private void transaction_grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            sum();
        }

        private void transaction_grid_MouseLeave(object sender, EventArgs e)
        {
            transaction_grid.ClearSelection();
        }
    }
}
