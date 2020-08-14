using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace piracy
{
    public partial class forgot_password : Form
    {
        DataLayer dl = new DataLayer();
        public forgot_password()
        {
            InitializeComponent();
        }

        private void btnGetpassword_Click(object sender, EventArgs e)
        {
            encpass enc = new encpass();

            String str = "select * from user_creation where user_name='" + txtUsername.Text + "'";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            if (ds.Tables[0].Rows.Count > 0)
            {
                String email = ds.Tables[0].Rows[0]["email"].ToString();
                Random r = new Random();
                String s = r.NextDouble().ToString();
                s = s.Substring(3, 8);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;

                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("harshitakarkala@gmail.com", "achhu9880055037");
                MailMessage msg = new MailMessage();
                msg.To.Add(email);
                msg.From = new MailAddress(email);
                msg.Subject = "forgot password";
                msg.Body = "your new password is='" + s + "'";
                client.Send(msg);
                str = "update user_creation set password='" + enc.EncryptConnectionString(s) + "' where user_name='" + txtUsername.Text + "'";
                dl.DmlCmd(str);
            }
            else
            {
                MessageBox.Show("invalid user");
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true)
            {
                e.Handled = true;
            }

            if (char.IsControl(e.KeyChar) != true && char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }  
}
