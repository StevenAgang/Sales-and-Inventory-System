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
    public partial class login_histiory : UserControl
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public MySqlConnection connection = new MySqlConnection(ConnectionString);
        public static login_histiory instance;
        public login_histiory()
        {
            InitializeComponent();
            instance = this;
        }

        private void login_histiory_Load(object sender, EventArgs e)
        {
            _loginhistory.DataSource = Source();
        }

        private DataTable data = new DataTable();
        private DataSet ds = new DataSet();

        public DataTable Source()
        {
            if (Internet.CheckInternet() != false)
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    
                    command.CommandText = "SELECT log AS Login_History FROM login_history";
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

        public void Connection()
        {
            if (Internet.CheckInternet() != false)
            {
                try
                {
                    string Command = "SELECT log AS History FROM login_history";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(Command, connection);
                    connection.Open();
                    DataSet data = new DataSet();
                    adapter.Fill(data);
                    _loginhistory.DataSource = data.Tables[0];
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

        private void Clearlog()
        {
            if (Internet.CheckInternet() != false)
            {
                string Command = @"TRUNCATE TABLE login_history";
                MySqlCommand command = new MySqlCommand(Command, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
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
        private void clear_btn_Click(object sender, EventArgs e)
        {
            Clearlog();
            Connection();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Connection();
        }
    }
}
