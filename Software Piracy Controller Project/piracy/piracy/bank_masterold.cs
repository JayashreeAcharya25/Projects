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
        public void dropbankname()
        {
            String str = "select *  from bank_master";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            cmbBankname.DataSource = ds;
            cmbBankname.DisplayMember = "table.bank_name";
            cmbBankname.ValueMember = "table.bankmaster_id";
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtBankname.Text = "";
        }

        private void txtSubmit_Click(object sender, EventArgs e)
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
                    fillgrid();
                    MessageBox.Show("record inserted successfully");
                }
               
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {

            if (cmbBankname.Text == "")
            {
                MessageBox.Show("Please enter Bank Name");
            }
            if (txtBranchname.Text == "")
            {
                MessageBox.Show("Please enter Branch Name");
            }
            if (txtIfsc.Text == "")
            {
                MessageBox.Show("Please enter ifsc code");
            }
           
            else
            {
                str = "select * from branch_master where branch_name='" + txtBranchname.Text + "'";
                DataSet ds = new DataSet();
                ds = dl.GetDataSet(str);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Branch name already exist ");
                }
                else
                {
                    str = "insert into branch_master(bank_id, ifsc, branch_name)values('"+cmbBankname.SelectedValue+"','" + txtIfsc.Text + "','" + txtBranchname.Text + "')";
                    dl.DmlCmd(str);
                    MessageBox.Show("record inserted successfully");
                }
            }
        }
        private void btnClr_Click(object sender, EventArgs e)
        {
            cmbBankname.SelectedIndex = -1;
            txtBranchname.Text = "";
            txtIfsc.Text = "";
           
        }

        private void bank_master_Load(object sender, EventArgs e)
        {
            fillgrid();
            dropbankname();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txtBankname.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            String str = "update bank_master set bank_name='" + txtBankname.Text + "' where bankmaster_id='" + id + "'";
            dl.DmlCmd(str);
            fillgrid();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            String str = "delete from bank_master where bankmaster_id='" + id + "'";
            dl.DmlCmd(str);
            fillgrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBankname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) != true && char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtBranchname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) != true && char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }
    }
}