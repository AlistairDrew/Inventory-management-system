using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
        }

        private void button_SellSubmit_Click(object sender, EventArgs e)
        {
            this.Visible = false;       //Hides Sell Form before opening the IMS form
            var IMS = new IMS();
            IMS.Show();
        }

        private void button_SellCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;       
            var IMS = new IMS();
            IMS.Show();
        }
    }
}
