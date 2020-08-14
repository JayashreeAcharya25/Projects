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
    public partial class bank_master : Form
    {
        public static string id = "";

        DataLayer dl = new DataLayer();
        String str = "";
        public void fillgrid()
        {
            String str = "select * from bank_master";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "table";
        }
        public bank_master()
        {
            InitializeComponent();

        }
        public void dropbank()
        {
            string str = "select * from bank_master";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            cmbBankname.DataSource = ds;
            cmbBankname.DisplayMember = "table.bank_name";
            cmbBankname.ValueMember = "table.bankmaster_id";
        }

        public bool verification(string verify)
        {
            return Regex.IsMatch(verify, "[A-Z a-z][A-Z a-z][A-Z a-z][A-Z a-z][0-9][0-9][0-9][0-9][0-9][0-9][0-9]");
        }

        private void bank_master_Load(object sender, EventArgs e)
        {
            fillgrid();
            dropbank();
        }

        private void dataGridView1_DataMemberChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            String str = "select * from bank_master";
            ds = dl.GetDataSet(str);

            if (ds.Tables[0].Rows.Count <= 0)
            {
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
            }
            else if (ds.Tables[0].Rows.Count > 0)
            {
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
            }
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (txtBankname.Text == "")
            {
                MessageBox.Show("insert bank name");
            }
            else
            {
                str = "select * from bank_master where bank_name='" + txtBankname.Text + "'";
                DataSet ds = new DataSet();
                ds = dl.GetDataSet(str);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("bank name already exist ");
                }
                else
                {
                    str = "insert into bank_master(bank_name)values('" + txtBankname.Text + "')";
                    dl.DmlCmd(str);
                    dropbank();
                    fillgrid(); txtBankname.Text = "";
                    MessageBox.Show("record inserted successfully");


                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtBankname.Text = "";
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            String str = "delete from bank_master where bankmaster_id='" + id + "'";
            dl.DmlCmd(str);

            fillgrid();

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            String str = "select * from bank_master where bank_name='" + txtBankname.Text + "'";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("bank name already exist ");
            }
            else
            {
                str = "update  bank_master set bank_name ='" + txtBankname.Text + "'where bankmaster_id='" + id + "'";
                dl.DmlCmd(str);
                fillgrid();
            }
        }

        private void btnSub_Click_1(object sender, EventArgs e)
        {
            if (verification(txtIfsc.Text.Trim()))
            {
                if (cmbBankname.Text == "")
                {
                    MessageBox.Show("Please enter Bank Name");
                }
                if (txtBranchname.Text == "")
                {
                    MessageBox.Show("Please enter Branch Name");
                }
                if (txtAccount.Text == "")
                {
                    MessageBox.Show("Please enter Account Number");
                }
                else if (txtAccount.Text.Length != 14)
                {
                    MessageBox.Show("please enter 14 digits only");
                }
                else
                {
                    str = "select * from  branch_master where branch_name ='" + txtBranchname.Text + "'";
                    DataSet ds = new DataSet();
                    ds = dl.GetDataSet(str);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("branchname already exist ");
                    }
                    else
                    {

                        str = "insert into branch_master(bank_id, branch_name, account_no, ifsc)values('" + cmbBankname.SelectedValue + "','" + txtBranchname.Text + "','" + txtAccount.Text + "','" + txtIfsc.Text + "')";
                        dl.DmlCmd(str);
                        MessageBox.Show("record inserted successfully");
                    }
                }
            }
            else
            {
                MessageBox.Show("INVALID IFSC");
            }

        }

        private void btnClr_Click_1(object sender, EventArgs e)
        {
            cmbBankname.SelectedIndex = -1;
            txtBranchname.Text = "";
            txtAccount.Text = "";
            txtIfsc.Text = "";
        }

        private void txtBankname_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtAccount_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void cmbBankname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtBranchname_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtIfsc_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }


       private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

       




        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
       

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

     
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseUp_1(object sender, MouseEventArgs e)
        {
            id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txtBankname.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
        }       
    }
}