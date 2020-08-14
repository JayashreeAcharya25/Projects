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
    public partial class login : Form
    {
        DataLayer dl = new DataLayer();
        public login()
        {

            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            encpass enc = new encpass();

            if (txtUsername.Text == "")
            {
                MessageBox.Show("please input user name");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("please input password");
            }
            else if (txtPassword.Text.Length != 8)
            {
                MessageBox.Show("Password must be of 8 characters only");
            }
            else
            {
                String str = "select * from user_creation where user_name='" + txtUsername.Text + "'";
                DataSet ds = new DataSet();
                ds = dl.GetDataSet(str);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    String str1 = "select * from user_creation where password='" + enc.EncryptConnectionString(txtPassword.Text) + "'";
                    DataSet ds1 = new DataSet();
                    ds1 = dl.GetDataSet(str1);
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        if (ds1.Tables[0].Rows[0]["user_type"].ToString() == "ADMIN")
                        {
                            DataLayer.uname = txtUsername.Text;

                        }
                        else if (ds1.Tables[0].Rows[0]["user_type"].ToString() == "USER")
                        {
                            DataLayer.uname = txtUsername.Text;

                        }
                        else
                        {
                            MessageBox.Show("invalid password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("invalid password");
                    }
                }
                else
                {

                    MessageBox.Show("invalid user name");
                }
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnForgotPassword_Click_1(object sender, EventArgs e)
        {
            forgot_password frm = new forgot_password();
            frm.Show();
        }

        private void txtUsername_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
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





        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void login_Load(object sender, EventArgs e)
        {

        }

    }  
}
