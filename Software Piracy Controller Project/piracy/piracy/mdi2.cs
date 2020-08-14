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
    public partial class mdi2 : Form
    {
        DataLayer dl = new DataLayer();
        public mdi2()
        {
            InitializeComponent();
        }

        private void mdi2_Load(object sender, EventArgs e)
        {
            lblSigup.Visible = false;
            panellogin.BackColor = System.Drawing.Color.FromArgb(90, 78, 67, 78);
            panelMDI.Visible = false;
            panelleftmain.Visible = false;
            // pictureBox2.Visible = false;
            //  pictureBox1.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            panelMDI.Visible = true;
            panelleftmain.Visible = true;
            panellogin.Visible = false;
            panelMDI.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Height = btnHome.Height;
            pictureBox1.Top = btnHome.Top;

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            panelMDI.Controls.Clear();
            panelMDI.Visible = true;
            change_password change = new change_password();
            change.TopLevel = false;
            change.AutoScroll = true;
            panelMDI.Controls.Add(change);
            change.Dock = DockStyle.Fill;
            change.Show();

            pictureBox1.Visible = true;
            pictureBox1.Height = btnChange.Height;
            pictureBox1.Top = btnChange.Top;
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {

            panelMDI.Controls.Clear();
            panelMDI.Visible = true;
            master change = new master();
            change.TopLevel = false;
            change.AutoScroll = true;
            panelMDI.Controls.Add(change);
            change.Dock = DockStyle.Fill;
            change.Show();

            pictureBox1.Visible = true;
            pictureBox1.Height = btnMaster.Height;
            pictureBox1.Top = btnMaster.Top;

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            panelMDI.Controls.Clear();
            panelMDI.Visible = true;
            client_request change = new client_request();
            change.TopLevel = false;
            change.AutoScroll = true;
            panelMDI.Controls.Add(change);
            change.Dock = DockStyle.Fill;
            change.Show();

            pictureBox1.Visible = true;
            pictureBox1.Height = btnClient.Height;
            pictureBox1.Top = btnClient.Top;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            panelMDI.Controls.Clear();
            panelMDI.Visible = true;
            user_creation change = new user_creation();
            change.TopLevel = false;
            change.AutoScroll = true;
            panelMDI.Controls.Add(change);
            change.Dock = DockStyle.Fill;
            change.Show();

            pictureBox1.Visible = true;
            pictureBox1.Height = btnUser.Height;
            pictureBox1.Top = btnUser.Top;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            btnLogin.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "User Name")
            {
                txtUsername.ForeColor = Color.Black;
                txtUsername.Text = "";
            }
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.PasswordChar = '\0';
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*';

            }
            if (txtUsername.Text == "")
            {

                txtUsername.Text = "User Name";
                txtUsername.ForeColor = Color.Silver;
            }

        }

        private void btnLogin_Click_2(object sender, EventArgs e)
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
                            panelleftmain.Visible = true;
                            panelMDI.Visible = true;

                        }
                        //else if (ds1.Tables[0].Rows[0]["user_type"].ToString() == "USER")
                        //{
                        //    DataLayer.uname = txtUsername.Text;

                        //}
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

        private void lblSigup_Click(object sender, EventArgs e)
        {
            
            DataSet ds = new DataSet();

            String str = "select * from user_creation";
            ds = dl.GetDataSet(str);

            if (ds.Tables[0].Rows.Count <= 0)
            {
                btnLogin.Enabled = false;
                txtPassword.Enabled = false;
                txtUsername.Enabled = false;
                lblSigup.Visible = true;
            }
            else
            {
                btnLogin.Enabled = true;
                txtPassword.Enabled = true;
                txtUsername.Enabled = true;
                lblSigup.Visible = false;
            }
        }

        private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgot_password frm = new forgot_password();
            frm.Show();
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

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }





        private void panelMDI_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panelMDI_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }
    }



    //custom doublebufferpanel

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
   

