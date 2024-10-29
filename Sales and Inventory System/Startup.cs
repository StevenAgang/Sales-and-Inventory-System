using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sales_and_Inventory_System
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
            timer1.Stop();
            timer1.Enabled = false;
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Start();
        }
    }
}
