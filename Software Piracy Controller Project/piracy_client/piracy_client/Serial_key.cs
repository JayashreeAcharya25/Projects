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
    public partial class Serial_key : Form
    {
        DataLayer dl = new DataLayer();
        public Serial_key()
        {
            InitializeComponent();
        }

        private void btnsub_Click(object sender, EventArgs e)
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
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtserial.Text = "";
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

        private void btnbuy_Click_1(object sender, EventArgs e)
        {
            Client frm = new Client();
           frm.Show();
        }
    }
}
