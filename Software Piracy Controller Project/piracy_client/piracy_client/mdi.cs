using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace piracy_client
{
    public partial class mdi : Form
    {
        public mdi()
        {
            InitializeComponent();
        }

        public static string GetProcessorID()
        {
            string sProcessorID = "";
            string sQuery = "SELECT ProcessorId FROM Win32_Processor";
            ManagementObjectSearcher oManagementObjectSearcher = new ManagementObjectSearcher(sQuery);
            ManagementObjectCollection oCollection = oManagementObjectSearcher.Get();
            foreach (ManagementObject oManagementObject in oCollection)
            {
                sProcessorID = (string)oManagementObject["ProcessorId"];
            }
            return (sProcessorID);
        }

        public String GetHarddiskID()
        {
            ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                result = Convert.ToString(strt["VolumeSerialNumber"]);
                return (result);
            }
            return (result);
        }
        
        private void registerProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            String str1 = GetProcessorID();
            String str2 = GetHarddiskID();
            str1 = str1.Substring(0, 7);
            str2 = str2.Substring(0, 7);
            String auth = str1 + str2;
            String str = "select flag from client where authenticate_code = '" + auth + "' and flag=2";
            DataSet ds = new DataSet();
            DataLayer dl = new DataLayer();
            ds = dl.GetDataSet(str);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("You have been already registered");
            }
            else
            {
                Serial_key frm = new Serial_key();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void mdi_Load(object sender, EventArgs e)
        {
            

            String str1 = GetProcessorID();
            String str2 = GetHarddiskID();
            str1 = str1.Substring(0, 7);
            str2 = str2.Substring(0, 7);
            String auth = str1 + str2;
            String str = "select flag from client where authenticate_code = '" + auth + "' and flag=2";
            DataSet ds = new DataSet();
            DataLayer dl = new DataLayer();
            ds = dl.GetDataSet(str);
            if (ds.Tables[0].Rows.Count > 0)
            {
            }
            else
            {
                MessageBox.Show("Your trail peroid has expired. Please register your product.");
            }
            panel1.Visible = false;
            Serial_key frm = new Serial_key();
            frm.MdiParent = this;
            frm.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
