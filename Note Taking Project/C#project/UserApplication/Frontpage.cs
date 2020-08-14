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

    public partial class Frontpage : Form
    {
       
        public Frontpage()
        {
            InitializeComponent();
            
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            doubleBufferPanel1.BackColor = Color.FromArgb(125, Color.Black);

            Image myimage = new Bitmap(@"C:\Users\PERSONAL\Desktop\c#\images\download (1).jpg");
            this.BackgroundImage = myimage;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdClickhere_Click_1(object sender, EventArgs e)
        {
            Index frm = new Index();
            frm.Show();
        }

        private void doubleBufferPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        
    }
    public class DoubleBufferPanel : Panel
    {

        public DoubleBufferPanel()
        {

            // Set the value of the double-buffering style bits to true.
            this.DoubleBuffered = true;



            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint |
             ControlStyles.AllPaintingInWmPaint, true);


            this.UpdateStyles();


        }


    }
   
}

        
    

