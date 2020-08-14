using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;
using Accolade_SMS;


namespace piracy
{
    public partial class client_request : Form
    {
        DataLayer dl = new DataLayer();
       
        public client_request()
        {
            InitializeComponent();
        }

       
        
        public void fillgrid()
        {
            //String str = "select * from client_request";
            //DataSet ds = new DataSet();
            //ds = dl.GetDataSet(str);
            //dataGridView1.DataSource = ds;
            //dataGridView1.DataMember = "table";
            String str = "select firstname, lastname, address, phone_no, land_no, email,authenticate_code from client where flag=0";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Table";
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
            string HardDiskID = "";
            foreach (ManagementObject strt in mcol)
            {
                HardDiskID = Convert.ToString(strt["VolumeSerialNumber"]);
                return (HardDiskID);
            }
            return (HardDiskID);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdb128bit.Checked = false;
            rdb192bit.Checked = false;
            rdb256bit.Checked = false;
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtSerialkey.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
       private void btnGenserialkey_Click(object sender, EventArgs e)
       {
          
               if (rdb128bit.Checked == false && rdb192bit.Checked == false && rdb256bit.Checked == false)
               {
                   MessageBox.Show("Select any AES method");
               }
              
               else if (txtPassword.Text == "")
               {
                   MessageBox.Show("Enter password");
               }
               else if (txtPassword.Text.Length != 8)
               {
                   MessageBox.Show("Password must be of 8 characters or digits only");
               }
               else
               {
                   try
                   {
                       String auth = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
                       String email = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                       String name = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();

                       String useremail = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                       txtEmail.Text = useremail.ToString();

                       int bit = 0;
                       if (rdb128bit.Checked == true)
                           bit = 128;
                       else if (rdb192bit.Checked == true)
                           bit = 192;
                       else
                           bit = 256;

                       String pass = txtPassword.Text;
                       String pd = auth;

                       AES a = new AES();

                       String data = a.Encrypt(pd, pass, bit);
                       data = bit.ToString() + pass + data;
                       txtSerialkey.Text = data;
                   }
                   catch (Exception ex)
                   {
                      
                   }
               }
           }
          
        
        private void btnSendserialkey_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("harshitakarkala@gmail.com", "achhu9880055037");
                MailMessage msg = new MailMessage();
                msg.To.Add(txtEmail.Text);
                msg.From = new MailAddress("harshitakarkala@gmail.com");
                msg.Subject = txtSerialkey.Text;

                //Attachment data = new Attachment(txtserial.Text);
                //msg.Attachments.Add(data);
                client.Send(msg);
                MessageBox.Show("Message Sent Successfully ");
                String str = "update client set flag=1,paid='yes' where firstname = '" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString() + "'";
                dl.DmlCmd(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           // ATS_SMS sms = new ATS_SMS();
            //sms.sendsms("9880055037", "test msg");
        }


        private void client_request_Load(object sender, EventArgs e)
        {
            fillgrid();

            String processorid = GetProcessorID();
            String harddiskid = GetHarddiskID();

            processorid = processorid.Substring(0, 8);
            harddiskid = harddiskid.Substring(0, 8);

            String auth = processorid + harddiskid;

        }


        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
             if(char.IsWhiteSpace(e.KeyChar)==true)
               {
                   e.Handled=true;
               }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
