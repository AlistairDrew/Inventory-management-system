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
    public partial class Dump : Form
    {
        public Dump()
        {
            InitializeComponent();
        }

        private void button_DumpSubmit_Click(object sender, EventArgs e)
        {
            this.Visible = false;       //Hides Dump Form before opening the IMS form
            var IMS = new IMS();
            IMS.Show();
        }

        private void button_DumpCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;       
            var IMS = new IMS();
            IMS.Show();
        }
    }
}
