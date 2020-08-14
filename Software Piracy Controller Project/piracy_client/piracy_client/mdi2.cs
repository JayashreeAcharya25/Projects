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

    public partial class panelMDI : Form
    {
        DataLayer dl = new DataLayer();

        public panelMDI()
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

        private void btnUtility_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox4.Height = btnUtility.Height;
            pictureBox4.Top = btnUtility.Top;
          
            panel1.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Visible = true;
            utility change = new utility();
            change.TopLevel = false;
            change.AutoScroll = true;
            panel1.Controls.Add(change);
            change.Dock = DockStyle.Fill;
            change.Show();

            
            
            //panelMdi.Visible = true;
           // panelUtility.Visible = true;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox4.Height = btnHelp.Height;
            pictureBox4.Top = btnHelp.Top;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox4.Height = btnExit.Height;
            pictureBox4.Top = btnExit.Top;     
        }

      
       
      
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
           

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void btnCal_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnNotepad_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnEMI_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnbuy_Click_1(object sender, EventArgs e)
        {
            Client1 frm = new Client1();
            frm.Show();

        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            txtserial.Text = "";
        }

        private void btnsub_Click_1(object sender, EventArgs e)
        {
             if (txtserial.Text == "")
            {
                MessageBox.Show("Enter the key to decrypt");
            }
            else
            {
                try
                {
                    String s = txtserial.Text;
                    int bit = int.Parse(s.Substring(0, 3));
                    String password = s.Substring(3, 8);
                    String data = s.Substring(11, s.Length - 11);
                    AES a = new AES();

                    String str1 = GetProcessorID();
                    String str2 = GetHarddiskID();
                    str1 = str1.Substring(0, 7);
                    str2 = str2.Substring(0, 7);
                    String auth = str1 + str2;

                    String data1 = a.Encrypt(auth, password, bit);
                    if (data == data1)
                    {
                        MessageBox.Show("Your product is activated");
                        String str = "update client set flag = 2 where authenticate_code = '" + auth + "'";
                        dl.DmlCmd(str);

                        panelleftmain.Visible = true;
                        panelSerial.Visible = false;
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid serial key");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //this.Close();
        }

        private void panelMDI_Load(object sender, EventArgs e)
        {
            panelleftmain.Visible = false;
            panelSerial.Visible = false;
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
                panelleftmain.Visible = false; 

            }
            else
            {
                //panelleftmain.Enabled = false;
                panelSerial.Visible = true;
                MessageBox.Show("Your trail peroid has expired. Please register your product.");
            }
           // panelSerial.Visible = true;
            Serial frm = new Serial();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        

          

        
      }

    }

   
    
