using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace piracy
{
    public partial class user_creation : Form
    {
        DataLayer dl = new DataLayer();
        public void fillgrid()
        {
            String str = "select * from user_creation";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "table";
        }

        public user_creation()
        {
            InitializeComponent();
        }

        public bool verification(string verify)
        {
            return Regex.IsMatch(verify, "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-z-A-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            encpass enc = new encpass();

            if (verification(txtEmail.Text.Trim()))
            {
                if (txtUsername.Text == "")
                {
                    MessageBox.Show("please input username");
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("please input password");
                }
                else if (cmbUsertype.Text == "")
                {
                    MessageBox.Show("please select usertype");
                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("please input email");
                }
                else if (txtConfirmpassword.Text != txtPassword.Text)
                {
                    MessageBox.Show("password does not match");
                }
                else if (txtPno.Text == "")
                {
                    MessageBox.Show("please input phone number");
                }
                else if (txtPassword.Text.Length != 8)
                {
                    MessageBox.Show("Password must be of 8 characters or digits only");
                }
                else if (txtPno.Text.Length < 10 || txtPno.Text.Length > 10)
                {
                    MessageBox.Show("invalid phoneno");
                }
                else
                {
                    String str1 = "select * from  user_creation where user_name='" + txtUsername.Text + "'";
                    DataSet ds = new DataSet();
                    ds = dl.GetDataSet(str1);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("username already exist");
                    }
                    else
                    {

                        String str = "insert into user_creation( user_name, password, user_type, email, phone)values('" + txtUsername.Text + "','" + enc.EncryptConnectionString(txtPassword.Text) + "','" + cmbUsertype.Text + "','" + txtEmail.Text + "','" + txtPno.Text + "')";
                        dl.DmlCmd(str);
                        fillgrid();
                        MessageBox.Show("record inserted successfully");
                    }
                }
            }
            else
            {
                MessageBox.Show("INVALID EMAIL");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            cmbUsertype.SelectedIndex = -1;
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtPno.Text = "";
            txtConfirmpassword.Text = "";

        }

        private void user_creation_Load(object sender, EventArgs e)
        {
            fillgrid();
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

        private void txtPno_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true)
            {
                e.Handled = true;
            }

            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }

        }

        private void txtPassword_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
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





        private void btnClear_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPno_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbUsertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtUsername_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_OnValueChanged_2(object sender, EventArgs e)
        {

        }

        private void txtConfirmpassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void cmbUsertype_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataMemberChanged(object sender, EventArgs e)
        {


        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
