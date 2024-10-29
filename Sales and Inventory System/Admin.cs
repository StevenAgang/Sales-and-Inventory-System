using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_and_Inventory_System
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void supplier_btn_Click(object sender, EventArgs e)
        {
            if (supplier_btn.Checked) supplier1.BringToFront();
        }

        private void transac_history_Click(object sender, EventArgs e)
        {
            if (transac_history.Checked) admin_transaction_history1.BringToFront();
        }

        private void product_btn_Click(object sender, EventArgs e)
        {
            if (stock_btn.Checked) admin_stock1.BringToFront();
        }

        private void sales_btn_Click(object sender, EventArgs e)
        {
            if (account_btn.Checked) account_manage1.BringToFront();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_btn.Checked) login_histiory1.BringToFront();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void backup_Click(object sender, EventArgs e)
        {
            if(backup.Checked) data1.BringToFront();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            if (gunaAdvenceButton2.Checked) request1.BringToFront();
        }
    }
}
