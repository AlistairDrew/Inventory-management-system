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
    public partial class IMS : Form
    {
        public IMS()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IMS_Load(object sender, EventArgs e)
        {
           
        }

        private void InventoryDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_ADD_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;       //Hides IMS Form before opening the ADD form
            var Add = new Add();
            Add.Show();
            

            
    }

        private void button_DUMP_Click(object sender, EventArgs e)
        {
            this.Visible = false;       //Hides IMS Form before opening the Dump form
            var Dump = new Dump();
            Dump.Show();
        }

        private void button_SELL_Click(object sender, EventArgs e)
        {
            this.Visible = false;       //Hides IMS Form before opening the Sell form
            var Sell = new Sell();
            Sell.Show();
        }

        private void button_CUSTOM_Click(object sender, EventArgs e)
        {

        }

        private void ShipWeight_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
    
}
