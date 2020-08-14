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
    public partial class mdi : Form
    {

        DataLayer dl = new DataLayer();
        public mdi()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
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
            else if (txtPassword.Text.Length < 8 || txtPassword.Text.Length > 12)
            {
                MessageBox.Show("password should be <8 and >12");
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
                            menuStrip1.Visible = true;
                            panel2.Visible = false;


                            //disable mandina enable manpi
                            //panelLogin disab;e
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            forgot_password frm = new forgot_password();
            frm.Show();
        }


       
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user_creation frm = new user_creation();
            frm.MdiParent = this;
            frm.Show();

        }

        private void productToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           // this.Controls.Clear();
            menuStrip1.Visible = true;

            product_master frm = new product_master();
            frm.Show();
        }

        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bank_master frm = new bank_master();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clientRequestToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            client_request frm = new client_request();
            frm.MdiParent = this;
            frm.Show();
        }

        private void changePasswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            change_password frm = new change_password();
            frm.MdiParent = this;
            frm.Show();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) != true && char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void mdi_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            panel2.BackColor = System.Drawing.Color.FromArgb(90, 20, 20, 20);
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "user name")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = System.Drawing.Color.Black;
            }
        }

      

       
       

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      
       
    }
}
