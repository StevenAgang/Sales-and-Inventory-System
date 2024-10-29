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
    public partial class ProgressBars : Form
    {
        public static ProgressBars instance; 
        public ProgressBars()
        {
            InitializeComponent();
            instance = this;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
