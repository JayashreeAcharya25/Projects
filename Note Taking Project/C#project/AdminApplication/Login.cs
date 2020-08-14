using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
       
       
        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(125, Color.Black);
            
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            Frontpage frm = new Frontpage();
            frm.Show();
        }

        
        
    }
    
    
}
