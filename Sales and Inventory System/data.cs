using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_and_Inventory_System
{
    public partial class data : UserControl
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public MySqlConnection connection = new MySqlConnection(ConnectionString);
        private int click_btn = 0;
        public data()
        {
            InitializeComponent();
        }

        private void Get_log()
        {
            if (Internet.CheckInternet() != false)
            {
                string commandString = @"SELECT log AS LOG FROM backup_log";
                MySqlDataAdapter adapter= new MySqlDataAdapter(commandString, connection);
                try
                {
                    connection.Open();
                    DataSet data = new DataSet();
                    adapter.Fill(data);
                    _backup_log.DataSource = data.Tables[0];
                    connection.Close();

                }catch (Exception e)
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

        string path;

        private void restores()
        {
            click_btn = 1;
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open Database";
            open.Filter = "database file(*.sql)|*.sql";
            open.FilterIndex = 2;
            open.RestoreDirectory = true;
            open.DefaultExt = "sql";

            if (open.ShowDialog().Equals(DialogResult.OK))
            {
                path = open.FileName;
            }
        }

        private void backups()
        {
            click_btn = 0;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "database file(*.sql)|*.sql";
            save.FilterIndex = 2;
            save.DefaultExt = "sql";
            save.RestoreDirectory = true;
            save.Title = "save database";

            if (save.ShowDialog().Equals(DialogResult.OK))
            {
                path = save.FileName;
            }
        }

        MySqlBackup db;
        private void Backup_Database()
        {
            Thread.Sleep(100);
            using (MySqlCommand cmd = new MySqlCommand())
            {
                using (db = new MySqlBackup(cmd))
                {
                    try
                    {
                        cmd.Connection = connection;
                        connection.Open();
                        db.ExportProgressChanged += backup_progresschanged;
                        db.ExportCompleted += backup_completed;
                        db.ExportInfo.IntervalForProgressReport = (int)500;
                        db.ExportToFile(path);
                        connection.Close();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        connection.Close();
                        return;
                    }
                }
            }
        }

        private void Restore_Database()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                using (db = new MySqlBackup(cmd))
                {
                    try
                    {
                        cmd.Connection = connection;
                        connection.Open();
                        db.ImportProgressChanged += restore_progresschanged;
                        db.ImportCompleted += restore_completed;
                        db.ImportFromFile(path);
                        connection.Close();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        connection.Close();
                        return;
                    }
                }
            }
        }

         private static double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

        private void restore_progresschanged(object sender, ImportProgressArgs e)
        {
            string f = ConvertBytesToMegabytes(e.CurrentBytes).ToString("0.000");
            string f1 = ConvertBytesToMegabytes(e.TotalBytes).ToString("0.000");
            Label.CheckForIllegalCrossThreadCalls = false;
            progressbar.Maximum = 100;
            progressbar.Value = Convert.ToInt32(e.PercentageCompleted);
        }

        private async void restore_completed(object sender, ImportCompleteArgs e)
        {
            MessageBox.Show("Database restore complete","Completed",MessageBoxButtons.OK,MessageBoxIcon.Information);
            await Task.Run(() => insert_log());
        }

        private void backup_progresschanged(object sender, ExportProgressArgs e)
        {
            Label.CheckForIllegalCrossThreadCalls = false;
            progressbar.Maximum = Convert.ToInt32(e.CurrentTableIndex);
            progressbar.Value = Convert.ToInt32(e.CurrentTableIndex);
        }

        private async void backup_completed(object sender, ExportCompleteArgs e)
        {
            MessageBox.Show("Database export completed","Complete",MessageBoxButtons.OK,MessageBoxIcon.Information);
            await Task.Run( () => insert_log());
        }

        private void data_Load(object sender, EventArgs e)
        {
            Get_log();
        }

        private void _backup_log_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            _backup_log.ClearSelection();
        }

        private void _backup_log_MouseLeave(object sender, EventArgs e)
        {

            _backup_log.ClearSelection();
        }

        private void backup_Click(object sender, EventArgs e)
        {
            backups();
            action();
        }

        private void restore_Click(object sender, EventArgs e)
        {
            restores();
            action();
        } 
        private async void action()
        {
            if (click_btn == 0)
            {
                await Task.Run(() => Backup_Database());
            }
            else
            {
               await Task.Run(() =>  Restore_Database());
            }
        }

        private void data_Load_1(object sender, EventArgs e)
        {
            Get_log();
        }

        private void insert_log()
        {
            Thread.Sleep(1000);
            string commandString = @"INSERT INTO backup_log(log)VALUES(?log)";
            MySqlCommand command = new MySqlCommand(commandString, connection);


            if (click_btn == 0)
            {
                command.Parameters.Add(new MySqlParameter("?log", MySqlDbType.Text)).Value = "Successfully backup at" +DateTime.Now;
            }
            else
            {
                command.Parameters.Add(new MySqlParameter("?log", MySqlDbType.Text)).Value = "Successfully Restore at" + DateTime.Now;
            }
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                progressbar.Value = 0;
                path = "";
                Get_log();
                admin_stock.instance.Connection();
                admin_supplier.instance.Connection();
                account_manage.instance.staff_account_connection();
                admin_transaction_history.instance.Connection();
                login_histiory.instance.Connection();
                request.instance.Source();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                connection.Close();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
        }
    }
}
