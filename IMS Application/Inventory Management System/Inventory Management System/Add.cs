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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_CV_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button_AddSubmit_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;       //Hides ADD Form before opening the IMS form
            var IMS = new IMS();
            IMS.Show();
        }

        private void button_AddCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;      
            var IMS = new IMS();
            IMS.Show();
        }
    }
}
