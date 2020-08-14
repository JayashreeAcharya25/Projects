using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace piracy
{
    public partial class master : Form
    {
        public master()
        {
            InitializeComponent();
        }

        private void btnProduct_Click_1(object sender, EventArgs e)
        {
            product_master master = new product_master();
            master.Show();

        }

        private void btnBank_Click_1(object sender, EventArgs e)
        {
            bank_master master = new bank_master();
            master.Show();

        }

       
    }
}
