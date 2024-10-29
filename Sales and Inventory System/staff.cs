    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sales_and_Inventory_System
{
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void product_btn_Click(object sender, EventArgs e)
        {
            if (product_btn.Checked) product_management_control1.BringToFront();
            
        }

        private void sales_btn_Click(object sender, EventArgs e)
        {
            if (sales_btn.Checked) sales_management_control1.BringToFront();
        }

        private void supplier_btn_Click(object sender, EventArgs e)
        {
            if (supplier_btn.Checked) supplier1.BringToFront();
        }
  
        private void transac_history_Click(object sender, EventArgs e)
        {
            if (transac_history.Checked) transaction_history1.BringToFront();
        }
        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["account_view"] as account_view) != null)
            {
                MessageBox.Show("Account window already open");
            }
            else
            {
                account_view user = new account_view();
                user.Show();
            }
            
        }

        private void staff_Load(object sender, EventArgs e)
        {
        }
    }
}
