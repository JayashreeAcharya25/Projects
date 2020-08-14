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
    public partial class product_master : Form
    {
        public static string id = "";
        DataLayer dl = new DataLayer();
        String str = "";
        public void fillgrid()
        {
            String str = "select * from product_master";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "table";
        }
        public product_master()
        {
            InitializeComponent();
        }

       
        private void txtSubmit_Click(object sender, EventArgs e)
        {
            if (txtProductname.Text == "")
            {
                MessageBox.Show("insert product name");
            }
            else if (txtAmount.Text == "")
            {
                MessageBox.Show("Please enter Amount");
            }
            else if(int.Parse(txtAmount.Text)<=0)
            {
                MessageBox.Show("Amount should be greater than zero");
            }
            else
            {
                str = "select * from product_master where product_name='" + txtProductname.Text + "'";
                DataSet ds = new DataSet();
                ds = dl.GetDataSet(str);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("product name already exist ");
                }
                else
                {

                    str = "insert into product_master(product_name,amount)values('" + txtProductname.Text + "','"+txtAmount.Text+"')";
                    dl.DmlCmd(str);
                    fillgrid();
                    MessageBox.Show("record inserted successfully");
                }
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductname.Text = "";
            txtAmount.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            String str = "select * from product_master where product_name='" + txtProductname.Text + "'";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("product name already exist ");
            }
            else
            {
                str = "update product_master set product_name='" + txtProductname.Text + "' where product_id='" + id + "'";
                dl.DmlCmd(str);
                fillgrid();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String str = "delete from product_master where product_id='" + id + "'";
            dl.DmlCmd(str);
            fillgrid();
        }

       private void product_master_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txtProductname.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            txtAmount.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
        }


        private void txtProductname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_DataMemberChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            String str = "select * from product_master";
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
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




        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtProductname_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_TextChanged(object sender, EventArgs e)
        {

        }

    }
}