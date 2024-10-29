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
using System.IO.Compression;
using System.Threading;
using Microsoft.Office.Interop.Excel;
using System.Configuration;

namespace Sales_and_Inventory_System
{
    public partial class admin_transaction_history : UserControl
    {
        private System.Data.DataTable data = new System.Data.DataTable();
        private DataSet ds = new DataSet();
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public MySqlConnection connection = new MySqlConnection(ConnectionString);
        public static admin_transaction_history instance;

        public admin_transaction_history()
        {
            InitializeComponent();
            instance= this;
        }

        private void admin_transaction_history_Load(object sender, EventArgs e)
        {
            date.Value = DateTime.Now;
            date1.Value = DateTime.Now;
            timer.Start();
            transaction_grid.DataSource = Source();
        }

        public System.Data.DataTable Source()
        {
            if (Internet.CheckInternet() != false)
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = @" SELECT tbl_sales.transaction_id AS Transaction_ID,tbl_product.product_desc AS Description, tbl_product.product_size AS Size, tbl_product.product_price AS Price, tbl_sales.quantity AS Quantity, tbl_sales.senior AS Senior, tbl_sales.discount AS Discount, tbl_sales.total_price AS Total_Price, tbl_sales.date_purchase AS Date_Purchase FROM tbl_product RIGHT JOIN tbl_sales ON tbl_sales.product_id_fk = tbl_product.product_id ORDER BY tbl_sales.date_purchase DESC";
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
                string Command = @"SELECT tbl_sales.transaction_id AS Transaction_ID,tbl_product.product_desc AS Description, tbl_product.product_size AS Size, tbl_product.product_price AS Price, tbl_sales.quantity AS Quantity, tbl_sales.senior AS Senior, tbl_sales.discount AS Discount, tbl_sales.total_price AS Total_Price, tbl_sales.date_purchase AS Date_Purchase FROM tbl_product RIGHT JOIN tbl_sales ON tbl_sales.product_id_fk = tbl_product.product_id ORDER BY tbl_sales.date_purchase DESC";
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

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            Connection();
            date.Value = DateTime.Now;
            date1.Value = DateTime.Now;
        }


        private void record()
        {
            if (transaction_grid.Rows.Count != 0)
            {
                int records = 0;
                double calculate = 0;
                for (int i = 0; i < transaction_grid.Rows.Count; i++)
                {
                    records += 1;
                    calculate = calculate + Convert.ToDouble(transaction_grid.Rows[i].Cells[7].Value);
                }
                total_records.Text = records.ToString();
                total_sales.Text = calculate.ToString();
            }
            else
            {
                int records = 0;
                int calculate = 0;
                total_records.Text = records.ToString();
                total_sales.Text = calculate.ToString();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            current_date.Text = DateTime.Now.ToString();
        }

        private void date_search()
        {
            if (date.Value != date1.Value)
            {
                if (transaction_grid.Rows.Count != 0)
                {
                    if (Internet.CheckInternet() != false)
                    {
                        string Command = "SELECT tbl_sales.transaction_id AS Transaction_ID,tbl_product.product_desc AS Description, tbl_product.product_size AS Size, tbl_product.product_price AS Price, tbl_sales.quantity AS Quantity, tbl_sales.senior AS Senior, tbl_sales.discount AS Discount, tbl_sales.total_price AS Total_Price, tbl_sales.date_purchase AS Date_Purchase FROM tbl_product RIGHT JOIN tbl_sales ON tbl_sales.product_id_fk = tbl_product.product_id WHERE tbl_sales.date_purchase BETWEEN ?date AND ?date1";
                        MySqlCommand command = new MySqlCommand(Command, connection);
                        command.Parameters.Add(new MySqlParameter("?date", MySqlDbType.Date)).Value = Convert.ToDateTime(date.Value);
                        command.Parameters.Add(new MySqlParameter("?date1", MySqlDbType.Date)).Value = Convert.ToDateTime(date1.Value);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);

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
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            if (transaction_grid.Rows.Count != 0)
            {
                var progress = new Progress<int>(value =>
                {
                    ProgressBars.instance.progressbar.Value = value;
                    if (ProgressBars.instance.progressbar.Value != ProgressBars.instance.progressbar.Maximum)
                    {
                        this.Enabled = false;
                        ProgressBars.instance.result.Text = string.Format($"Processing...{value}%");
                        ProgressBars.instance.close_btn.Visible = false;
                    }
                    else
                    {
                        this.Enabled = true;
                        ProgressBars.instance.result.Text = string.Format($"Export Completed");
                        ProgressBars.instance.close_btn.Visible = true;
                        this.Enabled = true;
                    }
                });
                Export2Excel(transaction_grid.Rows.Count - 1, progress);
            }
            else
            {
                MessageBox.Show("No data found","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private async void Export2Excel(int count, IProgress<int> progress)
        {
            using (SaveFileDialog save = new SaveFileDialog()
            {
                InitialDirectory = "C:",
                Title = "Save as excel file",
                FileName = "",
                Filter = "Excel|*.xlsx"
            })
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ProgressBars status = new ProgressBars();
                        status.Show();
                        await Task.Run(() =>
                        {
                            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                            excel.Application.Workbooks.Add(Type.Missing);

                            excel.Columns.ColumnWidth = 20;

                            Worksheet sheesh = (Worksheet)excel.ActiveSheet;
                            sheesh.Cells[1, 1] = "Transaction ID";
                            sheesh.Cells[1, 2] = "Description";
                            sheesh.Cells[1, 3] = "Size";
                            sheesh.Cells[1, 4] = "Price";
                            sheesh.Cells[1, 5] = "Quantity";
                            sheesh.Cells[1, 6] = "Senior";
                            sheesh.Cells[1, 7] = "Discount";
                            sheesh.Cells[1, 8] = "Total Price";
                            sheesh.Cells[1, 9] = "Date Of Purchase";

                            for (int i = 0; i < transaction_grid.Rows.Count; i++)
                            {
                                //Thread.Sleep(10);
                                var complete = i * 100 / count;
                                progress.Report(complete);
                                for (int x = 0; x < transaction_grid.Columns.Count; x++)
                                {
                                    excel.Cells[i + 2, x + 1] = transaction_grid.Rows[i].Cells[x].Value.ToString();
                                }
                            }

                            excel.ActiveWorkbook.SaveCopyAs(save.FileName.ToString());
                            excel.ActiveWorkbook.Saved = true;
                            excel.Quit();
                        });
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }

                }
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            if (transaction_grid.Rows.Count != 0)
            {
                date_search();
            }
            else
            {
                date_search();
            }
        }

        private void transaction_grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            transaction_grid.ClearSelection();
            record();
        }

        private void transaction_grid_MouseLeave(object sender, EventArgs e)
        {
            transaction_grid.ClearSelection();
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
                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
