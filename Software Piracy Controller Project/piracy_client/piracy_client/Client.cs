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
    public partial class Client : Form
    {
        DataLayer dl = new DataLayer();
        
        String str = "";
        public Client()
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
            String str = "select *  from bank_master";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            cmbBank.DataSource = ds;
            cmbBank.DisplayMember = "table.bank_name";
            cmbBank.ValueMember = "table.bankmaster_id";
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
               
                else if (txtPaid.Text == "")
                {
                    MessageBox.Show("Please enter Paid Amount");
                }
                else if (txtAuth.Text == "")
                {
                    MessageBox.Show("Please enter Authenticate code");
                }
                else if (txtPhoneno.Text == "")
                {
                    MessageBox.Show("Please enter Phone no");
                }
                else if (txtMobileno.Text == "")
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
                else if (txtAmount.Text == "")
                {
                    MessageBox.Show("Please enter Amount ");
                }
                else if (txtCvvno.Text == "")
                {
                    MessageBox.Show("Please enter Cvv No ");
                }
                else if (txtPd.Text == "")
                {
                    MessageBox.Show("Please enter Paid Amount");
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
                        str = "select * from client where mobile_no='" + txtMobileno.Text + "'";
                        DataSet ds1 = new DataSet();
                        ds1 = dl.GetDataSet(str);
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            MessageBox.Show("Mobile no already exist ");
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
                                str = "insert into client(fname, lname, address, phone_no, mobile_no, email,paid, authenticate_code,flag)values('" + txtFname.Text + "','" + txtLname.Text + "','" + txtAddress.Text + "','" + txtPhoneno.Text + "','" + txtMobileno.Text + "','" + txtEmail.Text + "','" + txtPaid.Text + "','" + txtAuth.Text + "','0')";
                                dl.DmlCmd(str);

                                String str1 = "insert into payment(product_id,bankmaster_id, debitcredit_no, amount, cvv_no, expiry_date,paid)values('" + cmbProduct.SelectedValue + "','" + cmbBank.SelectedValue + "','" + txtDebitcreditno.Text + "','" + txtAmount.Text + "','" + txtCvvno.Text + "','" + dtpExpirydate.Value.Date.ToString("yyyy-MM-dd") + "','" + txtPd.Text + "')";
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
            txtMobileno.Text = "";
            txtPaid.Text = "";
            txtPhoneno.Text = "";
            txtAddress.Text = "";
            cmbProduct.SelectedIndex = -1;
            cmbBank.SelectedIndex = -1;
            txtDebitcreditno.Text = "";
            txtCvvno.Text = "";
            txtAmount.Text = "";
            txtPd.Text = "";
        }
      
        private void client_Load(object sender, EventArgs e)
        {
            dropproduct();
            dropbank();

            String processorid = GetProcessorID();
            String harddiskid = GetHarddiskID();

            processorid = processorid.Substring(0, 7);
            harddiskid = harddiskid.Substring(0, 7);


            String auth = processorid + harddiskid;
            txtAuth.Text = auth.ToString();
        }

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) != true && char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) != true && char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtPhoneno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txtMobileno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txtCvvno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txtAuth_TextChanged(object sender, EventArgs e)
        {

        }

    }
}


      
    

