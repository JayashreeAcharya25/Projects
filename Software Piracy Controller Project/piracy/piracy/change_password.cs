using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace piracy
{
    public partial class change_password : Form
    {
        DataLayer dl=new DataLayer();
        public change_password()
        {
            InitializeComponent();
        }

        private void btnChangepassword_Click(object sender, EventArgs e)
        {
            encpass enc = new encpass();

            if (txtNewpassword.Text == "")
            {
                MessageBox.Show("Please input New Password");
            }
            else if (txtConfirmpassword.Text != txtNewpassword.Text)
            {
                MessageBox.Show("Password does not match");
            }
            else if (txtCurrentpassword.Text == "")
            {
                MessageBox.Show("Please input Current Password");
            }
            else if (txtNewpassword.Text.Length != 8)
            {
                MessageBox.Show("Password must be of 8 characters or digits only");
            }
            else if (txtCurrentpassword.Text.Length != 8)
            {
                MessageBox.Show("Password must be of 8 characters or digits only");
            }
            else
            {
                String str = "select * from user_creation where user_name='" + DataLayer.uname.ToString() + "' and password='" + enc.EncryptConnectionString(txtCurrentpassword.Text) + "'";
                DataSet ds = new DataSet();
                ds = dl.GetDataSet(str);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (txtNewpassword.Text == txtConfirmpassword.Text)
                    {
                        str = "update user_creation set password='" + enc.EncryptConnectionString(txtNewpassword.Text) + "' where user_name='" + DataLayer.uname.ToString() + "'";
                        dl.DmlCmd(str);
                        MessageBox.Show("password changed successful");
                    }
                    else
                    {
                        MessageBox.Show("password does not match");
                    }
                }
                else
                {
                    MessageBox.Show("invalid password");
                }

            }
          
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNewpassword.Text = "";
            txtConfirmpassword.Text = "";
            txtCurrentpassword.Text = "";
        }

        private void txtCurrentpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true)
            {
                e.Handled = true;
            }

        }

        private void txtNewpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true)
            {
                e.Handled = true;
            }

        }

        private void txtConfirmpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true)
            {
                e.Handled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
