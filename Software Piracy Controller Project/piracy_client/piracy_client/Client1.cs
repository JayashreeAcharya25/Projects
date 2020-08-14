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

namespace piracy_client
{
    public partial class Client1 : Form
    {
        DataLayer dl = new DataLayer();
        String str = "";

        public Client1()
        {
            InitializeComponent();
        }

        public bool verification(string verify)
        {
            return Regex.IsMatch(verify, "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-z-A-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$");
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
        public void dropproduct()
        {
            String str = "select *  from product_master";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            cmbProduct.DataSource = ds;
            cmbProduct.DisplayMember = "table.product_name";
            cmbProduct.ValueMember = "table.product_id";

        }
        public void dropbank()
        {
            String str1 ="select * from bank_master";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str1);
            cmbBank.DataSource = ds;
            cmbBank.DisplayMember = "table.bank_name";
            cmbBank.ValueMember = "table.bankmaster_id";
        }

        public void dropbranch()
        {
           
        }


    
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (verification(txtEmail.Text.Trim()))
            {
                if (txtFname.Text == "")
                {
                    MessageBox.Show("Please enter First Name");
                }
                else if (txtLname.Text == "")
                {
                    MessageBox.Show("Please enter Last Name");
                }
                else if (txtAddress.Text == "")
                {
                    MessageBox.Show("Please enter Address");
                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Please enter Email");
                }
                else if (txtAuth.Text == "")
                {
                    MessageBox.Show("Please enter Authenticate code");
                }
                else if (txtPhoneno.Text == "")
                {
                    MessageBox.Show("Please enter Phone no");
                }
                else if (txtLandno.Text == "")
                {
                    MessageBox.Show("Please enter Mobile no");
                }
                else if (cmbProduct.Text == "")
                {
                    MessageBox.Show("Please enter Product name");
                }
                else if (cmbBank.Text == "")
                {
                    MessageBox.Show("Please enter Bank name");
                }
                else if (txtDebitcreditno.Text == "")
                {
                    MessageBox.Show("Please enter Debit Credit No ");
                }
                
                else if (txtCvvno.Text == "")
                {
                    MessageBox.Show("Please enter Cvv No ");
                }
                
                else if (txtDebitcreditno.Text.Length != 16)
                {
                    MessageBox.Show("Please enter 16 digits only");
                }
                else if (txtCvvno.Text.Length != 3)
                {
                    MessageBox.Show("Please enter 3 digits only");
                }
                else
                {
                    str = "select * from client where phone_no='" + txtPhoneno.Text + "'";
                    DataSet ds = new DataSet();
                    ds = dl.GetDataSet(str);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("Phone no already exist ");
                    }
                    else
                    {
                        str = "select * from client where land_no='" + txtLandno.Text + "'";
                        DataSet ds1 = new DataSet();
                        ds1 = dl.GetDataSet(str);
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            MessageBox.Show("Land no already exist ");
                        }
                        else
                        {
                            str = "select * from client where email='" + txtEmail.Text + "'";
                            DataSet ds2 = new DataSet();
                            ds2 = dl.GetDataSet(str);
                            if (ds2.Tables[0].Rows.Count > 0)
                            {
                                MessageBox.Show("Email already exist ");
                            }

                            else
                            {
                                str = "insert into client(firstname, lastname, address, phone_no, land_no, email,authenticate_code,flag)values('" + txtFname.Text + "','" + txtLname.Text + "','" + txtAddress.Text + "','" + txtPhoneno.Text + "','" + txtLandno.Text + "','" + txtEmail.Text + "','" + txtAuth.Text + "','0')";
                                dl.DmlCmd(str);

                                String str1 = "insert into payment(product_id, bankmaster_id, debitcredit_no, amount, cvv_no,account_no,ifsc)values('" + cmbProduct.SelectedValue + "','" + cmbBank.SelectedValue + "','" + txtDebitcreditno.Text + "','" + lblAmount.Text + "','" + txtCvvno.Text + "','"+lblAccount.Text+"','"+lblIfsc.Text+"')";
                                dl.DmlCmd(str1);

                                MessageBox.Show("record inserted successfully");
                            }
                        }
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
            txtAuth.Text = "";
            txtEmail.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtLandno.Text = "";
           
            txtPhoneno.Text = "";
            txtAddress.Text = "";
            cmbProduct.SelectedIndex = -1;
            cmbBank.SelectedIndex = -1;
            txtDebitcreditno.Text = "";
            txtCvvno.Text = "";
            lblAmount.Text = "";
            lblAccount.Text = "";
            lblIfsc.Text = "";
            
        }

        private void Client1_Load(object sender, EventArgs e)
        {
            dropproduct();
            dropbank();
            dropbranch();

            String processorid = GetProcessorID();
            String harddiskid = GetHarddiskID();

            processorid = processorid.Substring(0, 7);
            harddiskid = harddiskid.Substring(0, 7);


            String auth = processorid + harddiskid;
            txtAuth.Text = auth.ToString();
        }

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPhoneno_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMobileno_KeyPress(object sender, KeyPressEventArgs e)
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

        

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txtCvvno_KeyPress(object sender, KeyPressEventArgs e)
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

        

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDebitcreditno_KeyPress(object sender, KeyPressEventArgs e)
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



        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String str = "select *  from branch_master where bank_id='" + cmbBank.SelectedValue + "'";
                DataSet ds = new DataSet();
                ds = dl.GetDataSet(str);
                cmbBranch.DataSource = ds;
                cmbBranch.DisplayMember = "table.branch_name";
                cmbBranch.ValueMember = "table.branch_id";
            }
            catch (Exception ex) { }

        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            String str = "select amount from product_master where product_id='" + cmbProduct.SelectedValue + "'";

            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            
            if (ds.Tables[0].Rows.Count > 0)
            {
                lblAmount.Text = ds.Tables[0].Rows[0]["amount"].ToString();
                
            }

        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            String str = "select * from branch_master where branch_id='" + cmbBranch.SelectedValue + "'";

            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            if (ds.Tables[0].Rows.Count > 0)
            {
                lblAccount.Text = ds.Tables[0].Rows[0]["account_no"].ToString();
                lblIfsc.Text = ds.Tables[0].Rows[0]["ifsc"].ToString();
            }
        }

        private void lblAccount_Click(object sender, EventArgs e)
        {

        }

    }
}
