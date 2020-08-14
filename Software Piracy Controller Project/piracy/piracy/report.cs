using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.IO;
//using System.Drawing.Printing;

namespace piracy
{
    public partial class report : Form
    {
        DataLayer dl = new DataLayer();
        public report()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void report_Load(object sender, EventArgs e)
        {
            String str = "select firstname, lastname, address, phone_no, land_no, email,authenticate_code from client where flag=0";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Table";
        }

        private void rdbrequest_CheckedChanged(object sender, EventArgs e)
        {
            String str = "select firstname, lastname, address, phone_no, land_no, email,authenticate_code from client where flag=0";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Table";
        }

        private void rdbsent_CheckedChanged(object sender, EventArgs e)
        {
            String str = "select firstname, lastname, address, phone_no, land_no, email,authenticate_code from client where flag=1";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Table";
        }

        private void rdbapplied_CheckedChanged(object sender, EventArgs e)
        {
            String str = "select firstname, lastname, address, phone_no, land_no, email,authenticate_code from client where flag=2";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Table";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            PrintScreen();
            printPreviewDialog1.ShowDialog(); 
        }
        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
           
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;   
        private void PrintScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }  
   
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
