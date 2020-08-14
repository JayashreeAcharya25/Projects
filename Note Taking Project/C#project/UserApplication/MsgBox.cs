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
    public partial class MsgBox : Form
    {
        public MsgBox()
        {
            InitializeComponent();
        }

        private void MsgBox_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"C:\Users\PERSONAL\Desktop\c#\images\image2.jpg");
            this.BackgroundImage = myimage;
            doubleBufferPanel1.BackColor = Color.FromArgb(125, Color.Black);

        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
