using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AdminApplication
{
    
    public partial class Register : Form
    {
        
        public void fillgrid()
        {
            String str = "select * from Register";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "table";
        }
        public Register()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
